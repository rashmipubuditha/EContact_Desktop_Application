namespace proj1
{
    partial class Econtact
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            lblContactId = new Label();
            txtContactId = new TextBox();
            txtFirstname = new TextBox();
            lblFirstname = new Label();
            txtLastname = new TextBox();
            lblLastname = new Label();
            txtContactno = new TextBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            picEcontact = new PictureBox();
            picClose = new PictureBox();
            lblContact = new Label();
            lblContactno = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEcontact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            SuspendLayout();
            // 
            // lblContactId
            // 
            lblContactId.AutoSize = true;
            lblContactId.BackColor = Color.Transparent;
            lblContactId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactId.Location = new Point(95, 206);
            lblContactId.Margin = new Padding(4, 0, 4, 0);
            lblContactId.Name = "lblContactId";
            lblContactId.Size = new Size(104, 28);
            lblContactId.TabIndex = 1;
            lblContactId.Text = "Contact ID";
            // 
            // txtContactId
            // 
            txtContactId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactId.Location = new Point(252, 199);
            txtContactId.Margin = new Padding(4, 4, 4, 4);
            txtContactId.Name = "txtContactId";
            txtContactId.Size = new Size(280, 34);
            txtContactId.TabIndex = 2;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(252, 249);
            txtFirstname.Margin = new Padding(4, 4, 4, 4);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(280, 34);
            txtFirstname.TabIndex = 4;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = Color.Transparent;
            lblFirstname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.Location = new Point(95, 256);
            lblFirstname.Margin = new Padding(4, 0, 4, 0);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(106, 28);
            lblFirstname.TabIndex = 3;
            lblFirstname.Text = "First Name";
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(252, 299);
            txtLastname.Margin = new Padding(4, 4, 4, 4);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(280, 34);
            txtLastname.TabIndex = 6;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.BackColor = Color.Transparent;
            lblLastname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastname.Location = new Point(95, 306);
            lblLastname.Margin = new Padding(4, 0, 4, 0);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(103, 28);
            lblLastname.TabIndex = 5;
            lblLastname.Text = "Last Name";
            // 
            // txtContactno
            // 
            txtContactno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactno.Location = new Point(252, 349);
            txtContactno.Margin = new Padding(4, 4, 4, 4);
            txtContactno.Name = "txtContactno";
            txtContactno.Size = new Size(280, 34);
            txtContactno.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(252, 399);
            txtAddress.Margin = new Padding(4, 4, 4, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(280, 119);
            txtAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(95, 402);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(82, 28);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(95, 521);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(76, 28);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(252, 526);
            cmbGender.Margin = new Padding(4, 4, 4, 4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(188, 36);
            cmbGender.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MistyRose;
            btnAdd.ForeColor = Color.DarkRed;
            btnAdd.Location = new Point(229, 618);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 51);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MistyRose;
            btnUpdate.ForeColor = Color.DarkRed;
            btnUpdate.Location = new Point(420, 618);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 51);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MistyRose;
            btnClear.ForeColor = Color.DarkRed;
            btnClear.Location = new Point(796, 618);
            btnClear.Margin = new Padding(4, 4, 4, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 51);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MistyRose;
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(605, 618);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 51);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(569, 249);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(541, 322);
            dataGridView1.TabIndex = 17;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(569, 199);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 25);
            lblSearch.TabIndex = 18;
            lblSearch.Text = "Search";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(662, 199);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(448, 31);
            txtSearch.TabIndex = 19;
            // 
            // picEcontact
            // 
            picEcontact.BackColor = Color.Transparent;
            picEcontact.Image = (Image)resources.GetObject("picEcontact.Image");
            picEcontact.Location = new Point(311, 47);
            picEcontact.Name = "picEcontact";
            picEcontact.Size = new Size(77, 74);
            picEcontact.SizeMode = PictureBoxSizeMode.StretchImage;
            picEcontact.TabIndex = 20;
            picEcontact.TabStop = false;
            // 
            // picClose
            // 
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(1107, 12);
            picClose.Name = "picClose";
            picClose.Size = new Size(47, 46);
            picClose.SizeMode = PictureBoxSizeMode.StretchImage;
            picClose.TabIndex = 21;
            picClose.TabStop = false;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContact.ForeColor = Color.Firebrick;
            lblContact.Location = new Point(419, 47);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(347, 74);
            lblContact.TabIndex = 22;
            lblContact.Text = "E contact";
            // 
            // lblContactno
            // 
            lblContactno.AutoSize = true;
            lblContactno.BackColor = Color.Transparent;
            lblContactno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactno.Location = new Point(98, 355);
            lblContactno.Margin = new Padding(4, 0, 4, 0);
            lblContactno.Name = "lblContactno";
            lblContactno.Size = new Size(116, 28);
            lblContactno.TabIndex = 23;
            lblContactno.Text = "Contact No.";
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 705);
            Controls.Add(lblContactno);
            Controls.Add(lblContact);
            Controls.Add(picClose);
            Controls.Add(picEcontact);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtContactno);
            Controls.Add(txtLastname);
            Controls.Add(lblLastname);
            Controls.Add(txtFirstname);
            Controls.Add(lblFirstname);
            Controls.Add(txtContactId);
            Controls.Add(lblContactId);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Econtact";
            Text = "Econtact";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEcontact).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblContactId;
        private TextBox txtContactId;
        private TextBox txtFirstname;
        private Label lblFirstname;
        private TextBox txtLastname;
        private Label lblLastname;
        private TextBox txtContactno;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblGender;
        private ComboBox cmbGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox txtSearch;
        private PictureBox picEcontact;
        private PictureBox picClose;
        private Label lblContact;
        private Label lblContactno;
    }
}
