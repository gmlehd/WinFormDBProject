using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDBProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;database=mydb;uid=root;pwd=020402");
            dataAdapter = new MySqlDataAdapter("SELECT * FROM book", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "book");
            dataGridView1.DataSource = dataSet.Tables["book"];
            //dataSet.Clear();
            //dataAdapter.Fill(dataSet, "book");
            //dataGridView1.DataSource = dataSet.Tables["book"];

        }

        #region Table Select
        private void RbBook_CheckedChanged(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter("SELECT * FROM book", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "book");
            dataGridView1.DataSource = dataSet.Tables["book"];

            gbBook.Visible = true;
            gbCustomer.Visible = false;
            gbOrders.Visible = false;

        }
        private void RbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter("SELECT * FROM customer", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "customer");
            dataGridView1.DataSource = dataSet.Tables["customer"];

            gbBook.Visible = false;
            gbCustomer.Visible = true;
            gbOrders.Visible = false;

        }
        private void RbOrders_CheckedChanged(object sender, EventArgs e)
        {
            dataAdapter = new MySqlDataAdapter("SELECT orderid, custid, bookid, saleprice, orderdate FROM orders", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "orders");
            dataGridView1.DataSource = dataSet.Tables["orders"];

            gbBook.Visible = false;
            gbCustomer.Visible = false;
            gbOrders.Visible = true;
        }
        #endregion

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                #region Book Table Select
                string queryStr;
                string[] conditions = new string[5];
                conditions[0] = (tbBookID.Text != "") ? "bookid=@bookid" : null;
                conditions[1] = (tbBookName.Text != "") ? "bookname=@bookname" : null;
                conditions[2] = (tbBookPublisher.Text != "") ? "publisher=@publisher" : null;
                conditions[3] = (tbPrice.Text != "") ? "price=@price" : null;


                //질문!!!!!!!!!!!!!!!!!!!!!!
                if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)  //만약 데이터가 다 들어있으면
                {
                    queryStr = $"SELECT * FROM book WHERE ";
                    bool firstCondition = true;    //firstCondition을 true로 해두고
                    for (int i = 0; i < conditions.Length; i++)  //conditions의 길이(5)만큼 for문을 돌려서
                    {
                        if (conditions[i] != null)
                            if (firstCondition)
                            {
                                queryStr += conditions[i];
                                firstCondition = false;
                            }
                            else
                            {
                                queryStr += " and " + conditions[i];
                            }
                    }
                }
                else
                {
                    queryStr = "SELECT * FROM book";
                }
                #region SelectCommand 객체 생성 및 Parameters 설정
                dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@bookid", tbBookID.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@bookname", tbBookName.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@publisher", tbBookPublisher.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@price", tbPrice.Text);
                #endregion

                try
                {
                    conn.Open();
                    dataSet.Clear();
                    if (dataAdapter.Fill(dataSet, "book") > 0)
                        dataGridView1.DataSource = dataSet.Tables["book"];
                    else
                        MessageBox.Show("찾는 데이터가 없습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
            else if(rbCustomer.Checked)
            {
                #region Customer Table select
                string queryStr;
                string[] conditions = new string[5];
                conditions[0] = (tbCustID.Text != "") ? "custid=@custid" : null;
                conditions[1] = (tbCustName.Text != "") ? "name=@name" : null;
                conditions[2] = (tbCustAddress.Text != "") ? "address=@address" : null;
                conditions[3] = (tbCustPhone.Text != "") ? "phone=@phone" : null;


                //질문!!!!!!!!!!!!!!!!!!!!!!
                if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)  //만약 데이터가 다 들어있으면
                {
                    queryStr = $"SELECT * FROM customer WHERE ";
                    bool firstCondition = true;    //firstCondition을 true로 해두고
                    for (int i = 0; i < conditions.Length; i++)  //conditions의 길이(5)만큼 for문을 돌려서
                    {
                        if (conditions[i] != null)
                            if (firstCondition)
                            {
                                queryStr += conditions[i];
                                firstCondition = false;
                            }
                            else
                            {
                                queryStr += " and " + conditions[i];
                            }
                    }
                }
                else
                {
                    queryStr = "SELECT * FROM customer";
                }
                #region SelectCommand 객체 생성 및 Parameters 설정
                dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@custid", tbCustID.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@name", tbCustName.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@address", tbCustAddress.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@phone", tbCustPhone.Text);
                #endregion

                try
                {
                    conn.Open();
                    dataSet.Clear();
                    if (dataAdapter.Fill(dataSet, "customer") > 0)
                        dataGridView1.DataSource = dataSet.Tables["customer"];
                    else
                        MessageBox.Show("찾는 데이터가 없습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
            else
            {
                #region Orders Table Select
                string queryStr;
                string[] conditions = new string[5];
                conditions[0] = (tbOrderID.Text != "") ? "orderid=@orderid" : null;
                conditions[1] = (tbCustomerID.Text != "") ? "custid=@custid" : null;
                conditions[2] = (tbBooksID.Text != "") ? "bookid=@bookid" : null;
                conditions[3] = (tbSalePrice.Text != "") ? "saleprice=@saleprice" : null;
                conditions[4] = (tbOrderDate.Text != "") ? "orderdate=@orderdate" : null;


                //질문!!!!!!!!!!!!!!!!!!!!!!
                if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)  //만약 데이터가 다 들어있으면
                {
                    queryStr = $"SELECT * FROM orders WHERE ";
                    bool firstCondition = true;    //firstCondition을 true로 해두고
                    for (int i = 0; i < conditions.Length; i++)  //conditions의 길이(6)만큼 for문을 돌려서
                    {
                        if (conditions[i] != null)
                            if (firstCondition)
                            {
                                queryStr += conditions[i];
                                firstCondition = false;
                            }
                            else
                            {
                                queryStr += " and " + conditions[i];
                            }
                    }
                }
                else
                {
                    queryStr = "SELECT * FROM orders";
                }
                #region SelectCommand 객체 생성 및 Parameters 설정
                dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@orderid", tbOrderID.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@custid", tbCustomerID.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@bookid", tbBooksID.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@saleprice", tbSalePrice.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@orderdate", tbOrderDate.Text);
                #endregion

                try
                {
                    conn.Open();
                    dataSet.Clear();
                    if (dataAdapter.Fill(dataSet, "orders") > 0)
                        dataGridView1.DataSource = dataSet.Tables["orders"];
                    else
                        MessageBox.Show("찾는 데이터가 없습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                #region Book Table insert
                string[] rowDatas = {
                    tbBookID.Text,
                    tbBookName.Text,
                    tbBookPublisher.Text,
                    tbPrice.Text
                };

                string queryStr = "INSERT INTO book (bookid, bookname, publisher, price) " +
                    "VALUES(@bookid, @bookname, @publisher, @price)";
                dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.InsertCommand.Parameters.Add("@bookid", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@bookname", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@publisher", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@price", MySqlDbType.Int32);

                //Parameter를 이용한 처리
                dataAdapter.InsertCommand.Parameters["@bookid"].Value = rowDatas[0];
                dataAdapter.InsertCommand.Parameters["@bookname"].Value = rowDatas[1];
                dataAdapter.InsertCommand.Parameters["@publisher"].Value = rowDatas[2];
                dataAdapter.InsertCommand.Parameters["@price"].Value = rowDatas[3];

                try
                {
                    conn.Open();
                    dataAdapter.InsertCommand.ExecuteNonQuery();

                    dataSet.Clear();                                        // Clear로 이전 데이터 지우기
                    dataAdapter.Fill(dataSet, "book");
                    dataGridView1.DataSource = dataSet.Tables["book"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
            else if (rbCustomer.Checked)
            {
                #region Customer Table insert
                string[] rowDatas = {
                    tbCustID.Text,
                    tbCustName.Text,
                    tbCustAddress.Text,
                    tbCustPhone.Text
                };

                string queryStr = "INSERT INTO customer (custid, name, address, phone) " +
                    "VALUES(@custid, @name, @address, @phone)";
                dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.InsertCommand.Parameters.Add("@custid", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@address", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@phone", MySqlDbType.VarChar);

                //Parameter를 이용한 처리
                dataAdapter.InsertCommand.Parameters["@custid"].Value = rowDatas[0];
                dataAdapter.InsertCommand.Parameters["@name"].Value = rowDatas[1];
                dataAdapter.InsertCommand.Parameters["@address"].Value = rowDatas[2];
                dataAdapter.InsertCommand.Parameters["@phone"].Value = rowDatas[3];

                try
                {
                    conn.Open();
                    dataAdapter.InsertCommand.ExecuteNonQuery();

                    dataSet.Clear();                                        // Clear로 이전 데이터 지우기
                    dataAdapter.Fill(dataSet, "customer");
                    dataGridView1.DataSource = dataSet.Tables["customer"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
            else
            {
                #region Orders Table insert
                string[] rowDatas = {
                    tbOrderID.Text,
                    tbCustomerID.Text,
                    tbBooksID.Text,
                    tbSalePrice.Text,
                    tbOrderDate.Text
                };

                string queryStr = "INSERT INTO orders (orderid, custid, bookid, saleprice, orderdate) " +
                    "VALUES(@orderid, @custid, @bookid, @saleprice, @orderdate)";
                dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.InsertCommand.Parameters.Add("@orderid", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@custid", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@bookid", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@saleprice", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@orderdate", MySqlDbType.VarChar);

                //Parameter를 이용한 처리
                dataAdapter.InsertCommand.Parameters["@orderid"].Value = rowDatas[0];
                dataAdapter.InsertCommand.Parameters["@custid"].Value = rowDatas[1];
                dataAdapter.InsertCommand.Parameters["@bookid"].Value = rowDatas[2];
                dataAdapter.InsertCommand.Parameters["@saleprice"].Value = rowDatas[3];
                dataAdapter.InsertCommand.Parameters["@orderdate"].Value = rowDatas[4];

                try
                {
                    conn.Open();
                    dataAdapter.InsertCommand.ExecuteNonQuery();

                    dataSet.Clear();                                        // Clear로 이전 데이터 지우기
                    dataAdapter.Fill(dataSet, "orders");
                    dataGridView1.DataSource = dataSet.Tables["orders"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                #region Book Table update
                string sql = "UPDATE book SET bookid=@bookid, bookname=@bookname, publisher=@publisher, price=@price where bookid=@bookid";
                dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookid", tbBookID.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookname", tbBookName.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@publisher", tbBookPublisher.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@price", tbPrice.Text);

                try
                {
                    conn.Open();
                    dataAdapter.UpdateCommand.ExecuteNonQuery();

                    dataSet.Clear();  // 이전 데이터 지우기
                    dataAdapter.Fill(dataSet, "book");
                    dataGridView1.DataSource = dataSet.Tables["book"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
            else if (rbCustomer.Checked)
            {
                #region Customer Table update
                string sql = "UPDATE customer SET custid=@custid, name=@name, address=@address, phone=@phone where custid=@custid";
                dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@custid", tbCustID.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", tbCustName.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@address", tbCustAddress.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@phone", tbCustPhone.Text);

                try
                {
                    conn.Open();
                    dataAdapter.UpdateCommand.ExecuteNonQuery();

                    dataSet.Clear();  // 이전 데이터 지우기
                    dataAdapter.Fill(dataSet, "customer");
                    dataGridView1.DataSource = dataSet.Tables["customer"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
            else
            {
                #region Orders Table update
                string sql = "UPDATE orders SET orderid=@orderid, custid=@custid, bookid=@bookid, saleprice=@saleprice, orderdate=@orderdate where orderid=@orderid";
                dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@orderid", tbOrderID.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@custid", tbCustomerID.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookid", tbBooksID.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@saleprice", tbSalePrice.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@orderdate", tbOrderDate.Text);

                try
                {
                    conn.Open();
                    dataAdapter.UpdateCommand.ExecuteNonQuery();

                    dataSet.Clear();  // 이전 데이터 지우기
                    dataAdapter.Fill(dataSet, "orders");
                    dataGridView1.DataSource = dataSet.Tables["orders"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }//orders DB update안됨

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                #region Book Table delete
                int id;
                string sql = "DELETE FROM book WHERE bookid=@bookid";
                dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapter.DeleteCommand.Parameters.Add("@bookid", MySqlDbType.Int32);
                id = (int)dataGridView1.SelectedRows[0].Cells["bookid"].Value;
                dataAdapter.DeleteCommand.Parameters["@bookid"].Value = id;

                try
                {
                    conn.Open();
                    dataAdapter.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "book");
                    dataGridView1.DataSource = dataSet.Tables["book"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
            else if (rbCustomer.Checked)
            {
                #region Customer Table delete
                int id;
                string sql = "DELETE FROM customer WHERE custid=@custid";
                dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapter.DeleteCommand.Parameters.Add("@custid", MySqlDbType.Int32);
                id = (int)dataGridView1.SelectedRows[0].Cells["custid"].Value;
                dataAdapter.DeleteCommand.Parameters["@custid"].Value = id;

                try
                {
                    conn.Open();
                    dataAdapter.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "customer");
                    dataGridView1.DataSource = dataSet.Tables["customer"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
            else
            {
                #region Orders Table delete
                int id;
                string sql = "DELETE FROM orders WHERE orderid=@orderid";
                dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapter.DeleteCommand.Parameters.Add("@orderid", MySqlDbType.Int32);
                id = (int)dataGridView1.SelectedRows[0].Cells["orderid"].Value;
                dataAdapter.DeleteCommand.Parameters["@orderid"].Value = id;

                try
                {
                    conn.Open();
                    dataAdapter.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "customer");
                    dataGridView1.DataSource = dataSet.Tables["customer"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }


        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                tbBookID.Clear();
                tbBookName.Clear();
                tbBookPublisher.Text = "";
                tbPrice.Text = "";
            }
            else if (rbCustomer.Checked)
            {
                tbCustID.Clear();
                tbCustName.Clear();
                tbCustAddress.Text = "";
                tbCustPhone.Text = "";
            }
            else
            {
                tbOrderID.Clear();
                tbBooksID.Clear();
                tbCustomerID.Clear();
                tbSalePrice.Text = "";
                tbOrderDate.Text = "";
            }
            
        }
    }
}
