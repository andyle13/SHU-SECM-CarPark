namespace SECM___Car_Park_Prototype_1
{
    partial class newCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newCustomer));
            this.fBalance = new System.Windows.Forms.TextBox();
            this.cName = new System.Windows.Forms.TextBox();
            this.floorSpaces = new System.Windows.Forms.Label();
            this.nooflevels = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yesID = new System.Windows.Forms.RadioButton();
            this.noID = new System.Windows.Forms.RadioButton();
            this.standard = new System.Windows.Forms.RadioButton();
            this.student = new System.Windows.Forms.RadioButton();
            this.cpEmp = new System.Windows.Forms.RadioButton();
            this.coopEmp = new System.Windows.Forms.RadioButton();
            this.incentives = new System.Windows.Forms.GroupBox();
            this.payStyle = new System.Windows.Forms.GroupBox();
            this.dDebit = new System.Windows.Forms.RadioButton();
            this.payp = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.regForm = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.incentives.SuspendLayout();
            this.payStyle.SuspendLayout();
            this.regForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // fBalance
            // 
            this.fBalance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fBalance.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.fBalance.Location = new System.Drawing.Point(146, 81);
            this.fBalance.Name = "fBalance";
            this.fBalance.Size = new System.Drawing.Size(141, 23);
            this.fBalance.TabIndex = 15;
            this.fBalance.Text = "0";
            this.fBalance.TextChanged += new System.EventHandler(this.fBalance_TextChanged);
            this.fBalance.Enter += new System.EventHandler(this.fBalance_Enter);
            this.fBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fBalance_KeyPress);
            this.fBalance.Leave += new System.EventHandler(this.fBalance_Leave);
            // 
            // cName
            // 
            this.cName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cName.Location = new System.Drawing.Point(67, 26);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(197, 23);
            this.cName.TabIndex = 14;
            this.cName.TextChanged += new System.EventHandler(this.cName_TextChanged);
            this.cName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cName_KeyPress);
            // 
            // floorSpaces
            // 
            this.floorSpaces.AutoSize = true;
            this.floorSpaces.Cursor = System.Windows.Forms.Cursors.Default;
            this.floorSpaces.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorSpaces.Location = new System.Drawing.Point(15, 82);
            this.floorSpaces.Name = "floorSpaces";
            this.floorSpaces.Size = new System.Drawing.Size(127, 19);
            this.floorSpaces.TabIndex = 12;
            this.floorSpaces.Text = "Financial Balance:";
            // 
            // nooflevels
            // 
            this.nooflevels.AutoSize = true;
            this.nooflevels.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nooflevels.Location = new System.Drawing.Point(10, 27);
            this.nooflevels.Name = "nooflevels";
            this.nooflevels.Size = new System.Drawing.Size(51, 19);
            this.nooflevels.TabIndex = 11;
            this.nooflevels.Text = "Name:";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(236, 33);
            this.header.TabIndex = 10;
            this.header.Text = "Welcome Customer";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(15, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(174, 19);
            this.instruction.TabIndex = 9;
            this.instruction.Text = "Please enter your details.";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 76);
            this.label1.TabIndex = 18;
            this.label1.Text = "Are you interested in participating in our\r\nFingerprintID system allowing custome" +
    "rs\r\nto enter and leave our car park with one\r\nfingerprint only?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(314, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 283);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benefits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 234);
            this.label4.TabIndex = 18;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yesID
            // 
            this.yesID.AutoSize = true;
            this.yesID.Font = new System.Drawing.Font("Calibri", 10F);
            this.yesID.Location = new System.Drawing.Point(26, 192);
            this.yesID.Name = "yesID";
            this.yesID.Size = new System.Drawing.Size(44, 21);
            this.yesID.TabIndex = 23;
            this.yesID.TabStop = true;
            this.yesID.Text = "Yes";
            this.yesID.UseVisualStyleBackColor = true;
            this.yesID.CheckedChanged += new System.EventHandler(this.yesID_CheckedChanged);
            // 
            // noID
            // 
            this.noID.AutoSize = true;
            this.noID.Checked = true;
            this.noID.Font = new System.Drawing.Font("Calibri", 10F);
            this.noID.Location = new System.Drawing.Point(135, 192);
            this.noID.Name = "noID";
            this.noID.Size = new System.Drawing.Size(42, 21);
            this.noID.TabIndex = 24;
            this.noID.TabStop = true;
            this.noID.Text = "No";
            this.noID.UseVisualStyleBackColor = true;
            this.noID.CheckedChanged += new System.EventHandler(this.noID_CheckedChanged);
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Font = new System.Drawing.Font("Calibri", 10F);
            this.standard.Location = new System.Drawing.Point(7, 28);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(77, 21);
            this.standard.TabIndex = 25;
            this.standard.TabStop = true;
            this.standard.Text = "Standard";
            this.standard.UseVisualStyleBackColor = true;
            this.standard.CheckedChanged += new System.EventHandler(this.standard_CheckedChanged);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Font = new System.Drawing.Font("Calibri", 10F);
            this.student.Location = new System.Drawing.Point(7, 51);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(70, 21);
            this.student.TabIndex = 26;
            this.student.TabStop = true;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = true;
            this.student.CheckedChanged += new System.EventHandler(this.student_CheckedChanged);
            // 
            // cpEmp
            // 
            this.cpEmp.AutoSize = true;
            this.cpEmp.Font = new System.Drawing.Font("Calibri", 10F);
            this.cpEmp.Location = new System.Drawing.Point(116, 28);
            this.cpEmp.Name = "cpEmp";
            this.cpEmp.Size = new System.Drawing.Size(131, 21);
            this.cpEmp.TabIndex = 27;
            this.cpEmp.TabStop = true;
            this.cpEmp.Text = "Car Park Employee";
            this.cpEmp.UseVisualStyleBackColor = true;
            this.cpEmp.CheckedChanged += new System.EventHandler(this.cpEmp_CheckedChanged);
            // 
            // coopEmp
            // 
            this.coopEmp.AutoSize = true;
            this.coopEmp.Font = new System.Drawing.Font("Calibri", 10F);
            this.coopEmp.Location = new System.Drawing.Point(116, 51);
            this.coopEmp.Name = "coopEmp";
            this.coopEmp.Size = new System.Drawing.Size(127, 21);
            this.coopEmp.TabIndex = 28;
            this.coopEmp.TabStop = true;
            this.coopEmp.Text = "Partner Employee";
            this.coopEmp.UseVisualStyleBackColor = true;
            this.coopEmp.CheckedChanged += new System.EventHandler(this.coopEmp_CheckedChanged);
            // 
            // incentives
            // 
            this.incentives.Controls.Add(this.coopEmp);
            this.incentives.Controls.Add(this.cpEmp);
            this.incentives.Controls.Add(this.student);
            this.incentives.Controls.Add(this.standard);
            this.incentives.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incentives.Location = new System.Drawing.Point(7, 124);
            this.incentives.Name = "incentives";
            this.incentives.Size = new System.Drawing.Size(257, 85);
            this.incentives.TabIndex = 29;
            this.incentives.TabStop = false;
            this.incentives.Text = "Incentive Programme";
            // 
            // payStyle
            // 
            this.payStyle.Controls.Add(this.dDebit);
            this.payStyle.Controls.Add(this.payp);
            this.payStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payStyle.Location = new System.Drawing.Point(7, 56);
            this.payStyle.Name = "payStyle";
            this.payStyle.Size = new System.Drawing.Size(257, 62);
            this.payStyle.TabIndex = 30;
            this.payStyle.TabStop = false;
            this.payStyle.Text = "Payment Style";
            // 
            // dDebit
            // 
            this.dDebit.AutoSize = true;
            this.dDebit.Font = new System.Drawing.Font("Calibri", 10F);
            this.dDebit.Location = new System.Drawing.Point(116, 28);
            this.dDebit.Name = "dDebit";
            this.dDebit.Size = new System.Drawing.Size(95, 21);
            this.dDebit.TabIndex = 27;
            this.dDebit.TabStop = true;
            this.dDebit.Text = "Direct Debit";
            this.dDebit.UseVisualStyleBackColor = true;
            this.dDebit.CheckedChanged += new System.EventHandler(this.dDebit_CheckedChanged);
            // 
            // payp
            // 
            this.payp.AutoSize = true;
            this.payp.Font = new System.Drawing.Font("Calibri", 10F);
            this.payp.Location = new System.Drawing.Point(7, 28);
            this.payp.Name = "payp";
            this.payp.Size = new System.Drawing.Size(53, 21);
            this.payp.TabIndex = 25;
            this.payp.TabStop = true;
            this.payp.Text = "PAYP";
            this.payp.UseVisualStyleBackColor = true;
            this.payp.CheckedChanged += new System.EventHandler(this.payp_CheckedChanged);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(315, 59);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(353, 42);
            this.submit.TabIndex = 31;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // regForm
            // 
            this.regForm.Controls.Add(this.payStyle);
            this.regForm.Controls.Add(this.incentives);
            this.regForm.Controls.Add(this.cName);
            this.regForm.Controls.Add(this.nooflevels);
            this.regForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regForm.Location = new System.Drawing.Point(12, 219);
            this.regForm.Name = "regForm";
            this.regForm.Size = new System.Drawing.Size(275, 218);
            this.regForm.TabIndex = 32;
            this.regForm.TabStop = false;
            this.regForm.Text = "Online Registration Form";
            // 
            // newCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 448);
            this.Controls.Add(this.regForm);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.noID);
            this.Controls.Add(this.yesID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fBalance);
            this.Controls.Add(this.floorSpaces);
            this.Controls.Add(this.header);
            this.Controls.Add(this.instruction);
            this.Name = "newCustomer";
            this.Text = "newCustomer";
            this.Load += new System.EventHandler(this.newCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.incentives.ResumeLayout(false);
            this.incentives.PerformLayout();
            this.payStyle.ResumeLayout(false);
            this.payStyle.PerformLayout();
            this.regForm.ResumeLayout(false);
            this.regForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fBalance;
        private System.Windows.Forms.TextBox cName;
        private System.Windows.Forms.Label floorSpaces;
        private System.Windows.Forms.Label nooflevels;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton yesID;
        private System.Windows.Forms.RadioButton noID;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.RadioButton student;
        private System.Windows.Forms.RadioButton cpEmp;
        private System.Windows.Forms.RadioButton coopEmp;
        private System.Windows.Forms.GroupBox incentives;
        private System.Windows.Forms.GroupBox payStyle;
        private System.Windows.Forms.RadioButton dDebit;
        private System.Windows.Forms.RadioButton payp;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.GroupBox regForm;
    }
}