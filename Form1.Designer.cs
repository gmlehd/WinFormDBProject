namespace WinFormDBProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbOrders = new System.Windows.Forms.RadioButton();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbBookPublisher = new System.Windows.Forms.TextBox();
            this.lbBookPublisher = new System.Windows.Forms.Label();
            this.lbBookPrice = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.lbBookID = new System.Windows.Forms.Label();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.tbCustPhone = new System.Windows.Forms.TextBox();
            this.tbCustAddress = new System.Windows.Forms.TextBox();
            this.lbCustAddress = new System.Windows.Forms.Label();
            this.lbCustPhone = new System.Windows.Forms.Label();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.lbCustName = new System.Windows.Forms.Label();
            this.tbCustID = new System.Windows.Forms.TextBox();
            this.lbCustID = new System.Windows.Forms.Label();
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.tbOrderDate = new System.Windows.Forms.TextBox();
            this.tbSalePrice = new System.Windows.Forms.TextBox();
            this.tbBooksID = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.lbBooksID = new System.Windows.Forms.Label();
            this.lbSalePrice = new System.Windows.Forms.Label();
            this.lbCustomerID = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbBook.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.gbOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 444);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(264, 33);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(494, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(264, 33);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "텍스트박스 지우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(494, 98);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(264, 33);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(494, 138);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(264, 33);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(494, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(264, 33);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // rbBook
            // 
            this.rbBook.AutoSize = true;
            this.rbBook.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbBook.Location = new System.Drawing.Point(494, 55);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(67, 21);
            this.rbBook.TabIndex = 19;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "Book";
            this.rbBook.UseVisualStyleBackColor = true;
            this.rbBook.CheckedChanged += new System.EventHandler(this.RbBook_CheckedChanged);
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbCustomer.Location = new System.Drawing.Point(571, 54);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(100, 21);
            this.rbCustomer.TabIndex = 20;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = true;
            this.rbCustomer.CheckedChanged += new System.EventHandler(this.RbCustomer_CheckedChanged);
            // 
            // rbOrders
            // 
            this.rbOrders.AutoSize = true;
            this.rbOrders.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbOrders.Location = new System.Drawing.Point(680, 55);
            this.rbOrders.Name = "rbOrders";
            this.rbOrders.Size = new System.Drawing.Size(78, 21);
            this.rbOrders.TabIndex = 21;
            this.rbOrders.TabStop = true;
            this.rbOrders.Text = "Orders";
            this.rbOrders.UseVisualStyleBackColor = true;
            this.rbOrders.CheckedChanged += new System.EventHandler(this.RbOrders_CheckedChanged);
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.tbPrice);
            this.gbBook.Controls.Add(this.tbBookPublisher);
            this.gbBook.Controls.Add(this.lbBookPublisher);
            this.gbBook.Controls.Add(this.lbBookPrice);
            this.gbBook.Controls.Add(this.tbBookName);
            this.gbBook.Controls.Add(this.lbBookName);
            this.gbBook.Controls.Add(this.tbBookID);
            this.gbBook.Controls.Add(this.lbBookID);
            this.gbBook.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbBook.Location = new System.Drawing.Point(39, 32);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(443, 266);
            this.gbBook.TabIndex = 23;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Book";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(146, 212);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(270, 39);
            this.tbPrice.TabIndex = 16;
            // 
            // tbBookPublisher
            // 
            this.tbBookPublisher.Location = new System.Drawing.Point(146, 153);
            this.tbBookPublisher.Name = "tbBookPublisher";
            this.tbBookPublisher.Size = new System.Drawing.Size(270, 39);
            this.tbBookPublisher.TabIndex = 15;
            // 
            // lbBookPublisher
            // 
            this.lbBookPublisher.AutoSize = true;
            this.lbBookPublisher.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBookPublisher.Location = new System.Drawing.Point(49, 162);
            this.lbBookPublisher.Name = "lbBookPublisher";
            this.lbBookPublisher.Size = new System.Drawing.Size(92, 20);
            this.lbBookPublisher.TabIndex = 14;
            this.lbBookPublisher.Text = "Publisher";
            this.lbBookPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBookPrice
            // 
            this.lbBookPrice.AutoSize = true;
            this.lbBookPrice.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBookPrice.Location = new System.Drawing.Point(81, 221);
            this.lbBookPrice.Name = "lbBookPrice";
            this.lbBookPrice.Size = new System.Drawing.Size(56, 20);
            this.lbBookPrice.TabIndex = 13;
            this.lbBookPrice.Text = "Price";
            this.lbBookPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(146, 93);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(270, 39);
            this.tbBookName.TabIndex = 12;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBookName.Location = new System.Drawing.Point(76, 102);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(61, 20);
            this.lbBookName.TabIndex = 11;
            this.lbBookName.Text = "Name";
            this.lbBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(146, 31);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(270, 39);
            this.tbBookID.TabIndex = 10;
            // 
            // lbBookID
            // 
            this.lbBookID.AutoSize = true;
            this.lbBookID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBookID.Location = new System.Drawing.Point(63, 40);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(74, 20);
            this.lbBookID.TabIndex = 9;
            this.lbBookID.Text = "BookID";
            this.lbBookID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.tbCustPhone);
            this.gbCustomer.Controls.Add(this.tbCustAddress);
            this.gbCustomer.Controls.Add(this.lbCustAddress);
            this.gbCustomer.Controls.Add(this.lbCustPhone);
            this.gbCustomer.Controls.Add(this.tbCustName);
            this.gbCustomer.Controls.Add(this.lbCustName);
            this.gbCustomer.Controls.Add(this.tbCustID);
            this.gbCustomer.Controls.Add(this.lbCustID);
            this.gbCustomer.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbCustomer.Location = new System.Drawing.Point(39, 23);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(443, 275);
            this.gbCustomer.TabIndex = 24;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // tbCustPhone
            // 
            this.tbCustPhone.Location = new System.Drawing.Point(146, 212);
            this.tbCustPhone.Name = "tbCustPhone";
            this.tbCustPhone.Size = new System.Drawing.Size(270, 39);
            this.tbCustPhone.TabIndex = 16;
            // 
            // tbCustAddress
            // 
            this.tbCustAddress.Location = new System.Drawing.Point(146, 153);
            this.tbCustAddress.Name = "tbCustAddress";
            this.tbCustAddress.Size = new System.Drawing.Size(270, 39);
            this.tbCustAddress.TabIndex = 15;
            // 
            // lbCustAddress
            // 
            this.lbCustAddress.AutoSize = true;
            this.lbCustAddress.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCustAddress.Location = new System.Drawing.Point(49, 162);
            this.lbCustAddress.Name = "lbCustAddress";
            this.lbCustAddress.Size = new System.Drawing.Size(84, 20);
            this.lbCustAddress.TabIndex = 14;
            this.lbCustAddress.Text = "Address";
            this.lbCustAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCustPhone
            // 
            this.lbCustPhone.AutoSize = true;
            this.lbCustPhone.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCustPhone.Location = new System.Drawing.Point(66, 223);
            this.lbCustPhone.Name = "lbCustPhone";
            this.lbCustPhone.Size = new System.Drawing.Size(68, 20);
            this.lbCustPhone.TabIndex = 13;
            this.lbCustPhone.Text = "Phone";
            this.lbCustPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCustName
            // 
            this.tbCustName.Location = new System.Drawing.Point(146, 93);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(270, 39);
            this.tbCustName.TabIndex = 12;
            // 
            // lbCustName
            // 
            this.lbCustName.AutoSize = true;
            this.lbCustName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCustName.Location = new System.Drawing.Point(73, 102);
            this.lbCustName.Name = "lbCustName";
            this.lbCustName.Size = new System.Drawing.Size(61, 20);
            this.lbCustName.TabIndex = 11;
            this.lbCustName.Text = "Name";
            this.lbCustName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCustID
            // 
            this.tbCustID.Location = new System.Drawing.Point(146, 31);
            this.tbCustID.Name = "tbCustID";
            this.tbCustID.Size = new System.Drawing.Size(270, 39);
            this.tbCustID.TabIndex = 10;
            // 
            // lbCustID
            // 
            this.lbCustID.AutoSize = true;
            this.lbCustID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCustID.Location = new System.Drawing.Point(64, 40);
            this.lbCustID.Name = "lbCustID";
            this.lbCustID.Size = new System.Drawing.Size(70, 20);
            this.lbCustID.TabIndex = 9;
            this.lbCustID.Text = "CustID";
            this.lbCustID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.lbOrderDate);
            this.gbOrders.Controls.Add(this.tbOrderDate);
            this.gbOrders.Controls.Add(this.tbSalePrice);
            this.gbOrders.Controls.Add(this.tbBooksID);
            this.gbOrders.Controls.Add(this.tbCustomerID);
            this.gbOrders.Controls.Add(this.lbBooksID);
            this.gbOrders.Controls.Add(this.lbSalePrice);
            this.gbOrders.Controls.Add(this.lbCustomerID);
            this.gbOrders.Controls.Add(this.tbOrderID);
            this.gbOrders.Controls.Add(this.lbOrderID);
            this.gbOrders.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbOrders.Location = new System.Drawing.Point(33, 26);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Size = new System.Drawing.Size(443, 266);
            this.gbOrders.TabIndex = 25;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "Orders";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOrderDate.Location = new System.Drawing.Point(33, 205);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(104, 20);
            this.lbOrderDate.TabIndex = 19;
            this.lbOrderDate.Text = "OrderDate";
            this.lbOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbOrderDate
            // 
            this.tbOrderDate.Location = new System.Drawing.Point(146, 203);
            this.tbOrderDate.Multiline = true;
            this.tbOrderDate.Name = "tbOrderDate";
            this.tbOrderDate.Size = new System.Drawing.Size(271, 29);
            this.tbOrderDate.TabIndex = 18;
            // 
            // tbSalePrice
            // 
            this.tbSalePrice.Location = new System.Drawing.Point(147, 162);
            this.tbSalePrice.Multiline = true;
            this.tbSalePrice.Name = "tbSalePrice";
            this.tbSalePrice.Size = new System.Drawing.Size(270, 29);
            this.tbSalePrice.TabIndex = 17;
            // 
            // tbBooksID
            // 
            this.tbBooksID.Location = new System.Drawing.Point(146, 118);
            this.tbBooksID.Multiline = true;
            this.tbBooksID.Name = "tbBooksID";
            this.tbBooksID.Size = new System.Drawing.Size(271, 29);
            this.tbBooksID.TabIndex = 16;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(146, 74);
            this.tbCustomerID.Multiline = true;
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(271, 29);
            this.tbCustomerID.TabIndex = 15;
            // 
            // lbBooksID
            // 
            this.lbBooksID.AutoSize = true;
            this.lbBooksID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBooksID.Location = new System.Drawing.Point(63, 122);
            this.lbBooksID.Name = "lbBooksID";
            this.lbBooksID.Size = new System.Drawing.Size(74, 20);
            this.lbBooksID.TabIndex = 14;
            this.lbBooksID.Text = "BookID";
            this.lbBooksID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSalePrice
            // 
            this.lbSalePrice.AutoSize = true;
            this.lbSalePrice.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSalePrice.Location = new System.Drawing.Point(37, 166);
            this.lbSalePrice.Name = "lbSalePrice";
            this.lbSalePrice.Size = new System.Drawing.Size(97, 20);
            this.lbSalePrice.TabIndex = 13;
            this.lbSalePrice.Text = "SalePrice";
            this.lbSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCustomerID
            // 
            this.lbCustomerID.AutoSize = true;
            this.lbCustomerID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCustomerID.Location = new System.Drawing.Point(67, 79);
            this.lbCustomerID.Name = "lbCustomerID";
            this.lbCustomerID.Size = new System.Drawing.Size(70, 20);
            this.lbCustomerID.TabIndex = 11;
            this.lbCustomerID.Text = "CustID";
            this.lbCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(146, 31);
            this.tbOrderID.Multiline = true;
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(271, 29);
            this.tbOrderID.TabIndex = 10;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOrderID.Location = new System.Drawing.Point(55, 40);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(78, 20);
            this.lbOrderID.TabIndex = 9;
            this.lbOrderID.Text = "OrderID";
            this.lbOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 792);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.rbOrders);
            this.Controls.Add(this.rbCustomer);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.rbBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbBook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbOrders.ResumeLayout(false);
            this.gbOrders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbOrders;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbBookPublisher;
        private System.Windows.Forms.Label lbBookPublisher;
        private System.Windows.Forms.Label lbBookPrice;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label lbBookID;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.TextBox tbCustPhone;
        private System.Windows.Forms.TextBox tbCustAddress;
        private System.Windows.Forms.Label lbCustAddress;
        private System.Windows.Forms.Label lbCustPhone;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Label lbCustName;
        private System.Windows.Forms.TextBox tbCustID;
        private System.Windows.Forms.Label lbCustID;
        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.TextBox tbOrderDate;
        private System.Windows.Forms.TextBox tbSalePrice;
        private System.Windows.Forms.TextBox tbBooksID;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label lbBooksID;
        private System.Windows.Forms.Label lbSalePrice;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label lbOrderID;
    }
}

