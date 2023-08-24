namespace CRUDOperations
{
    partial class Form1
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
            labelName = new Label();
            labelSurname = new Label();
            labelAddress = new Label();
            labelSalary = new Label();
            tbxName = new TextBox();
            tbxSurname = new TextBox();
            tbxAddress = new TextBox();
            tbxSalary = new TextBox();
            labelTeacherId = new Label();
            tbxTeacherId = new TextBox();
            textBox1 = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnShowAll = new Button();
            btnExit = new Button();
            dgwDatabase = new DataGridView();
            btnFind = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwDatabase).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(67, 70);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(49, 110);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(70, 20);
            labelSurname.TabIndex = 0;
            labelSurname.Text = "Surname:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(59, 157);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(65, 20);
            labelAddress.TabIndex = 0;
            labelAddress.Text = "Address:";
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(67, 198);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(52, 20);
            labelSalary.TabIndex = 0;
            labelSalary.Text = "Salary:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(135, 67);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(169, 27);
            tbxName.TabIndex = 1;
            // 
            // tbxSurname
            // 
            tbxSurname.Location = new Point(135, 110);
            tbxSurname.Name = "tbxSurname";
            tbxSurname.Size = new Size(169, 27);
            tbxSurname.TabIndex = 1;
            // 
            // tbxAddress
            // 
            tbxAddress.Location = new Point(135, 154);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(169, 27);
            tbxAddress.TabIndex = 1;
            // 
            // tbxSalary
            // 
            tbxSalary.Location = new Point(135, 198);
            tbxSalary.Name = "tbxSalary";
            tbxSalary.Size = new Size(169, 27);
            tbxSalary.TabIndex = 1;
            // 
            // labelTeacherId
            // 
            labelTeacherId.AutoSize = true;
            labelTeacherId.Location = new Point(43, 37);
            labelTeacherId.Name = "labelTeacherId";
            labelTeacherId.Size = new Size(76, 20);
            labelTeacherId.TabIndex = 0;
            labelTeacherId.Text = "TeacherId:";
            // 
            // tbxTeacherId
            // 
            tbxTeacherId.Location = new Point(135, 34);
            tbxTeacherId.Name = "tbxTeacherId";
            tbxTeacherId.Size = new Size(169, 27);
            tbxTeacherId.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 27);
            textBox1.TabIndex = 1;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(34, 255);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(86, 33);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(126, 255);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 33);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(218, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 33);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(34, 308);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(86, 33);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Location = new Point(218, 308);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 33);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dgwDatabase
            // 
            dgwDatabase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDatabase.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwDatabase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDatabase.Location = new Point(345, 76);
            dgwDatabase.Name = "dgwDatabase";
            dgwDatabase.ReadOnly = true;
            dgwDatabase.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgwDatabase.RowTemplate.Height = 29;
            dgwDatabase.Size = new Size(585, 274);
            dgwDatabase.TabIndex = 3;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Lime;
            btnFind.ForeColor = SystemColors.ActiveCaptionText;
            btnFind.Location = new Point(844, 34);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(86, 33);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 364);
            Controls.Add(dgwDatabase);
            Controls.Add(btnDelete);
            Controls.Add(btnFind);
            Controls.Add(btnExit);
            Controls.Add(btnShowAll);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(tbxSalary);
            Controls.Add(tbxAddress);
            Controls.Add(tbxSurname);
            Controls.Add(textBox1);
            Controls.Add(tbxTeacherId);
            Controls.Add(tbxName);
            Controls.Add(labelSalary);
            Controls.Add(labelAddress);
            Controls.Add(labelTeacherId);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwDatabase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelSurname;
        private Label labelAddress;
        private Label labelSalary;
        private TextBox tbxName;
        private TextBox tbxSurname;
        private TextBox tbxAddress;
        private TextBox tbxSalary;
        private Label labelTeacherId;
        private TextBox tbxTeacherId;
        private TextBox textBox1;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnShowAll;
        private Button btnExit;
        private DataGridView dgwDatabase;
        private Button btnFind;
    }
}