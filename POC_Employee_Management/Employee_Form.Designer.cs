namespace POC_Employee_Management
{
    partial class Employee_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EmpGrid = new System.Windows.Forms.DataGridView();
            this.btnGetEmp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddTab = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxEmpId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxEmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetTab = new System.Windows.Forms.TabPage();
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.AddTab.SuspendLayout();
            this.GetTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpGrid
            // 
            this.EmpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGrid.Location = new System.Drawing.Point(130, 79);
            this.EmpGrid.Margin = new System.Windows.Forms.Padding(4);
            this.EmpGrid.Name = "EmpGrid";
            this.EmpGrid.RowTemplate.Height = 25;
            this.EmpGrid.Size = new System.Drawing.Size(614, 306);
            this.EmpGrid.TabIndex = 25;
            // 
            // btnGetEmp
            // 
            this.btnGetEmp.FlatAppearance.BorderSize = 3;
            this.btnGetEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGetEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGetEmp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetEmp.Location = new System.Drawing.Point(374, 32);
            this.btnGetEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetEmp.Name = "btnGetEmp";
            this.btnGetEmp.Size = new System.Drawing.Size(132, 29);
            this.btnGetEmp.TabIndex = 24;
            this.btnGetEmp.Text = "Get Employe ";
            this.btnGetEmp.UseVisualStyleBackColor = true;
            this.btnGetEmp.Click += new System.EventHandler(this.btnGetEmp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-76, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Salary";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddTab);
            this.tabControl1.Controls.Add(this.GetTab);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1109, 465);
            this.tabControl1.TabIndex = 26;
            // 
            // AddTab
            // 
            this.AddTab.Controls.Add(this.btnReset);
            this.AddTab.Controls.Add(this.btnAdd);
            this.AddTab.Controls.Add(this.cBoxStatus);
            this.AddTab.Controls.Add(this.label6);
            this.AddTab.Controls.Add(this.cBoxGender);
            this.AddTab.Controls.Add(this.label5);
            this.AddTab.Controls.Add(this.tBoxEmail);
            this.AddTab.Controls.Add(this.label3);
            this.AddTab.Controls.Add(this.tBoxEmpId);
            this.AddTab.Controls.Add(this.label1);
            this.AddTab.Controls.Add(this.tBoxEmpName);
            this.AddTab.Controls.Add(this.label2);
            this.AddTab.Location = new System.Drawing.Point(4, 31);
            this.AddTab.Name = "AddTab";
            this.AddTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddTab.Size = new System.Drawing.Size(1101, 430);
            this.AddTab.TabIndex = 0;
            this.AddTab.Text = "Add Employe";
            this.AddTab.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(546, 258);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 32);
            this.btnReset.TabIndex = 42;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(425, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 32);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cBoxStatus.Location = new System.Drawing.Point(263, 177);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(172, 30);
            this.cBoxStatus.TabIndex = 40;
            this.cBoxStatus.Validating += new System.ComponentModel.CancelEventHandler(this.cBoxStaus_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(165, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Status";
            // 
            // cBoxGender
            // 
            this.cBoxGender.FormattingEnabled = true;
            this.cBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cBoxGender.Location = new System.Drawing.Point(657, 126);
            this.cBoxGender.Name = "cBoxGender";
            this.cBoxGender.Size = new System.Drawing.Size(172, 30);
            this.cBoxGender.TabIndex = 38;
            this.cBoxGender.Validating += new System.ComponentModel.CancelEventHandler(this.cBoxGender_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(538, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Gender";
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(263, 127);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(172, 29);
            this.tBoxEmail.TabIndex = 36;
            this.tBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxEmail_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(156, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Email ID";
            // 
            // tBoxEmpId
            // 
            this.tBoxEmpId.Location = new System.Drawing.Point(657, 76);
            this.tBoxEmpId.Name = "tBoxEmpId";
            this.tBoxEmpId.Size = new System.Drawing.Size(172, 29);
            this.tBoxEmpId.TabIndex = 34;
            this.tBoxEmpId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxEmpId_KeyPress);
            this.tBoxEmpId.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxEmpId_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(514, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Employe  ID";
            // 
            // tBoxEmpName
            // 
            this.tBoxEmpName.Location = new System.Drawing.Point(263, 76);
            this.tBoxEmpName.Name = "tBoxEmpName";
            this.tBoxEmpName.Size = new System.Drawing.Size(172, 29);
            this.tBoxEmpName.TabIndex = 3;
            this.tBoxEmpName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxEmpName_KeyPress);
            this.tBoxEmpName.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxEmpName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Employe  Name";
            // 
            // GetTab
            // 
            this.GetTab.Controls.Add(this.btnGetEmp);
            this.GetTab.Controls.Add(this.EmpGrid);
            this.GetTab.Location = new System.Drawing.Point(4, 31);
            this.GetTab.Name = "GetTab";
            this.GetTab.Padding = new System.Windows.Forms.Padding(3);
            this.GetTab.Size = new System.Drawing.Size(1101, 430);
            this.GetTab.TabIndex = 1;
            this.GetTab.Text = "Get Employee";
            this.GetTab.UseVisualStyleBackColor = true;
            // 
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            // 
            // Employe_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 463);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Name = "Employe_Form";
            this.Text = "Employe_Form";
            ((System.ComponentModel.ISupportInitialize)(this.EmpGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.AddTab.ResumeLayout(false);
            this.AddTab.PerformLayout();
            this.GetTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView EmpGrid;
        private Button btnGetEmp;
        private Label label4;
        private TabControl tabControl1;
        private TabPage AddTab;
        private TabPage GetTab;
        private ErrorProvider errorPro;
        private TextBox tBoxEmpId;
        private Label label1;
        private TextBox tBoxEmpName;
        private Label label2;
        private Button btnReset;
        private Button btnAdd;
        private ComboBox cBoxStatus;
        private Label label6;
        private ComboBox cBoxGender;
        private Label label5;
        private TextBox tBoxEmail;
        private Label label3;
    }
}