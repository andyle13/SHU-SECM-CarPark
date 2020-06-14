namespace SECM___Car_Park_Prototype_1
{
    partial class UpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomer));
            this.regForm = new System.Windows.Forms.GroupBox();
            this.PayStyle = new System.Windows.Forms.GroupBox();
            this.DirectDebit = new System.Windows.Forms.RadioButton();
            this.Payp = new System.Windows.Forms.RadioButton();
            this.Incentives = new System.Windows.Forms.GroupBox();
            this.CoopEmp = new System.Windows.Forms.RadioButton();
            this.CpEmp = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Standard = new System.Windows.Forms.RadioButton();
            this.CName = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.NoID = new System.Windows.Forms.RadioButton();
            this.FPrintDesc_lbl = new System.Windows.Forms.Label();
            this.YesID = new System.Windows.Forms.RadioButton();
            this.Update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.floorSpaces = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.custList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AccBalance_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FPrintBalance_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Debt_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.regForm.SuspendLayout();
            this.PayStyle.SuspendLayout();
            this.Incentives.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // regForm
            // 
            this.regForm.Controls.Add(this.PayStyle);
            this.regForm.Controls.Add(this.Incentives);
            this.regForm.Controls.Add(this.CName);
            this.regForm.Controls.Add(this.Name_lbl);
            this.regForm.Controls.Add(this.NoID);
            this.regForm.Controls.Add(this.FPrintDesc_lbl);
            this.regForm.Controls.Add(this.YesID);
            this.regForm.Enabled = false;
            this.regForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regForm.Location = new System.Drawing.Point(311, 53);
            this.regForm.Name = "regForm";
            this.regForm.Size = new System.Drawing.Size(293, 351);
            this.regForm.TabIndex = 43;
            this.regForm.TabStop = false;
            this.regForm.Text = "Manage FPrint Account";
            // 
            // PayStyle
            // 
            this.PayStyle.Controls.Add(this.DirectDebit);
            this.PayStyle.Controls.Add(this.Payp);
            this.PayStyle.Enabled = false;
            this.PayStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayStyle.Location = new System.Drawing.Point(18, 181);
            this.PayStyle.Name = "PayStyle";
            this.PayStyle.Size = new System.Drawing.Size(257, 62);
            this.PayStyle.TabIndex = 30;
            this.PayStyle.TabStop = false;
            this.PayStyle.Text = "Payment Style";
            // 
            // DirectDebit
            // 
            this.DirectDebit.AutoSize = true;
            this.DirectDebit.Font = new System.Drawing.Font("Calibri", 10F);
            this.DirectDebit.Location = new System.Drawing.Point(116, 28);
            this.DirectDebit.Name = "DirectDebit";
            this.DirectDebit.Size = new System.Drawing.Size(95, 21);
            this.DirectDebit.TabIndex = 27;
            this.DirectDebit.TabStop = true;
            this.DirectDebit.Text = "Direct Debit";
            this.DirectDebit.UseVisualStyleBackColor = true;
            this.DirectDebit.CheckedChanged += new System.EventHandler(this.DirectDebit_CheckedChanged);
            // 
            // Payp
            // 
            this.Payp.AutoSize = true;
            this.Payp.Font = new System.Drawing.Font("Calibri", 10F);
            this.Payp.Location = new System.Drawing.Point(7, 28);
            this.Payp.Name = "Payp";
            this.Payp.Size = new System.Drawing.Size(53, 21);
            this.Payp.TabIndex = 25;
            this.Payp.TabStop = true;
            this.Payp.Text = "PAYP";
            this.Payp.UseVisualStyleBackColor = true;
            this.Payp.CheckedChanged += new System.EventHandler(this.Payp_CheckedChanged);
            // 
            // Incentives
            // 
            this.Incentives.Controls.Add(this.CoopEmp);
            this.Incentives.Controls.Add(this.CpEmp);
            this.Incentives.Controls.Add(this.Student);
            this.Incentives.Controls.Add(this.Standard);
            this.Incentives.Enabled = false;
            this.Incentives.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incentives.Location = new System.Drawing.Point(18, 249);
            this.Incentives.Name = "Incentives";
            this.Incentives.Size = new System.Drawing.Size(257, 85);
            this.Incentives.TabIndex = 29;
            this.Incentives.TabStop = false;
            this.Incentives.Text = "Incentive Programme";
            // 
            // CoopEmp
            // 
            this.CoopEmp.AutoSize = true;
            this.CoopEmp.Font = new System.Drawing.Font("Calibri", 10F);
            this.CoopEmp.Location = new System.Drawing.Point(116, 51);
            this.CoopEmp.Name = "CoopEmp";
            this.CoopEmp.Size = new System.Drawing.Size(127, 21);
            this.CoopEmp.TabIndex = 28;
            this.CoopEmp.TabStop = true;
            this.CoopEmp.Text = "Partner Employee";
            this.CoopEmp.UseVisualStyleBackColor = true;
            this.CoopEmp.CheckedChanged += new System.EventHandler(this.CoopEmp_CheckedChanged);
            // 
            // CpEmp
            // 
            this.CpEmp.AutoSize = true;
            this.CpEmp.Font = new System.Drawing.Font("Calibri", 10F);
            this.CpEmp.Location = new System.Drawing.Point(116, 28);
            this.CpEmp.Name = "CpEmp";
            this.CpEmp.Size = new System.Drawing.Size(131, 21);
            this.CpEmp.TabIndex = 27;
            this.CpEmp.TabStop = true;
            this.CpEmp.Text = "Car Park Employee";
            this.CpEmp.UseVisualStyleBackColor = true;
            this.CpEmp.CheckedChanged += new System.EventHandler(this.CpEmp_CheckedChanged);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Font = new System.Drawing.Font("Calibri", 10F);
            this.Student.Location = new System.Drawing.Point(7, 51);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(70, 21);
            this.Student.TabIndex = 26;
            this.Student.TabStop = true;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.CheckedChanged += new System.EventHandler(this.Student_CheckedChanged);
            // 
            // Standard
            // 
            this.Standard.AutoSize = true;
            this.Standard.Font = new System.Drawing.Font("Calibri", 10F);
            this.Standard.Location = new System.Drawing.Point(7, 28);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(77, 21);
            this.Standard.TabIndex = 25;
            this.Standard.TabStop = true;
            this.Standard.Text = "Standard";
            this.Standard.UseVisualStyleBackColor = true;
            this.Standard.CheckedChanged += new System.EventHandler(this.Standard_CheckedChanged);
            // 
            // CName
            // 
            this.CName.Enabled = false;
            this.CName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CName.Location = new System.Drawing.Point(78, 151);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(197, 23);
            this.CName.TabIndex = 14;
            this.CName.TextChanged += new System.EventHandler(this.CName_TextChanged);
            this.CName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CName_KeyPress);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Enabled = false;
            this.Name_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(21, 152);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(51, 19);
            this.Name_lbl.TabIndex = 11;
            this.Name_lbl.Text = "Name:";
            // 
            // NoID
            // 
            this.NoID.AutoSize = true;
            this.NoID.Checked = true;
            this.NoID.Enabled = false;
            this.NoID.Font = new System.Drawing.Font("Calibri", 10F);
            this.NoID.Location = new System.Drawing.Point(133, 115);
            this.NoID.Name = "NoID";
            this.NoID.Size = new System.Drawing.Size(42, 21);
            this.NoID.TabIndex = 41;
            this.NoID.TabStop = true;
            this.NoID.Text = "No";
            this.NoID.UseVisualStyleBackColor = true;
            this.NoID.CheckedChanged += new System.EventHandler(this.NoID_CheckedChanged);
            // 
            // FPrintDesc_lbl
            // 
            this.FPrintDesc_lbl.AutoSize = true;
            this.FPrintDesc_lbl.Enabled = false;
            this.FPrintDesc_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FPrintDesc_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPrintDesc_lbl.Location = new System.Drawing.Point(8, 31);
            this.FPrintDesc_lbl.Name = "FPrintDesc_lbl";
            this.FPrintDesc_lbl.Size = new System.Drawing.Size(276, 76);
            this.FPrintDesc_lbl.TabIndex = 38;
            this.FPrintDesc_lbl.Text = "Are they interested in participating in our\r\nFingerprintID system allowing custom" +
    "ers\r\nto enter and leave our car park with one\r\nfingerprint only?";
            this.FPrintDesc_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YesID
            // 
            this.YesID.AutoSize = true;
            this.YesID.Enabled = false;
            this.YesID.Font = new System.Drawing.Font("Calibri", 10F);
            this.YesID.Location = new System.Drawing.Point(24, 115);
            this.YesID.Name = "YesID";
            this.YesID.Size = new System.Drawing.Size(44, 21);
            this.YesID.TabIndex = 40;
            this.YesID.TabStop = true;
            this.YesID.Text = "Yes";
            this.YesID.UseVisualStyleBackColor = true;
            this.YesID.CheckedChanged += new System.EventHandler(this.YesID_CheckedChanged);
            // 
            // Update
            // 
            this.Update.Enabled = false;
            this.Update.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(625, 62);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(353, 42);
            this.Update.TabIndex = 42;
            this.Update.Text = "Apply Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(625, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 283);
            this.groupBox1.TabIndex = 39;
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
            // Balance
            // 
            this.Balance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Balance.Location = new System.Drawing.Point(11, 204);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(110, 23);
            this.Balance.TabIndex = 37;
            this.Balance.Text = "0";
            this.Balance.TextChanged += new System.EventHandler(this.Balance_TextChanged);
            this.Balance.Enter += new System.EventHandler(this.Balance_Enter);
            this.Balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Balance_KeyPress);
            this.Balance.Leave += new System.EventHandler(this.Balance_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "GBP";
            // 
            // floorSpaces
            // 
            this.floorSpaces.AutoSize = true;
            this.floorSpaces.Cursor = System.Windows.Forms.Cursors.Default;
            this.floorSpaces.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorSpaces.Location = new System.Drawing.Point(7, 182);
            this.floorSpaces.Name = "floorSpaces";
            this.floorSpaces.Size = new System.Drawing.Size(172, 19);
            this.floorSpaces.TabIndex = 36;
            this.floorSpaces.Text = "Update Account Balance:";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(202, 33);
            this.header.TabIndex = 34;
            this.header.Text = "Manage Account";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(15, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(238, 57);
            this.instruction.TabIndex = 33;
            this.instruction.Text = "Please use this terminal to manage\r\na customer\'s account in regards to\r\ntheir fin" +
    "ances and account details.\r\n";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custList
            // 
            this.custList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custList.FormattingEnabled = true;
            this.custList.Location = new System.Drawing.Point(19, 119);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(130, 27);
            this.custList.TabIndex = 44;
            this.custList.SelectedIndexChanged += new System.EventHandler(this.CustList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.floorSpaces);
            this.groupBox2.Controls.Add(this.AccBalance_lbl);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.FPrintBalance_lbl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Debt_lbl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Balance);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 238);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Finances";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Debts:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Current FPrint Balance:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Current Account Balance:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccBalance_lbl
            // 
            this.AccBalance_lbl.AutoSize = true;
            this.AccBalance_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.AccBalance_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccBalance_lbl.Location = new System.Drawing.Point(7, 46);
            this.AccBalance_lbl.Name = "AccBalance_lbl";
            this.AccBalance_lbl.Size = new System.Drawing.Size(17, 19);
            this.AccBalance_lbl.TabIndex = 35;
            this.AccBalance_lbl.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(124, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "GBP";
            // 
            // FPrintBalance_lbl
            // 
            this.FPrintBalance_lbl.AutoSize = true;
            this.FPrintBalance_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.FPrintBalance_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPrintBalance_lbl.Location = new System.Drawing.Point(7, 99);
            this.FPrintBalance_lbl.Name = "FPrintBalance_lbl";
            this.FPrintBalance_lbl.Size = new System.Drawing.Size(17, 19);
            this.FPrintBalance_lbl.TabIndex = 35;
            this.FPrintBalance_lbl.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "GBP";
            // 
            // Debt_lbl
            // 
            this.Debt_lbl.AutoSize = true;
            this.Debt_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Debt_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debt_lbl.Location = new System.Drawing.Point(7, 152);
            this.Debt_lbl.Name = "Debt_lbl";
            this.Debt_lbl.Size = new System.Drawing.Size(17, 19);
            this.Debt_lbl.TabIndex = 35;
            this.Debt_lbl.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(124, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "GBP";
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.custList);
            this.Controls.Add(this.regForm);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.instruction);
            this.Name = "UpdateCustomer";
            this.Text = "Manage Customer";
            this.regForm.ResumeLayout(false);
            this.regForm.PerformLayout();
            this.PayStyle.ResumeLayout(false);
            this.PayStyle.PerformLayout();
            this.Incentives.ResumeLayout(false);
            this.Incentives.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox regForm;
        private System.Windows.Forms.GroupBox PayStyle;
        private System.Windows.Forms.RadioButton DirectDebit;
        private System.Windows.Forms.RadioButton Payp;
        private System.Windows.Forms.GroupBox Incentives;
        private System.Windows.Forms.RadioButton CoopEmp;
        private System.Windows.Forms.RadioButton CpEmp;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.RadioButton Standard;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.RadioButton NoID;
        private System.Windows.Forms.RadioButton YesID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FPrintDesc_lbl;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label floorSpaces;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.ComboBox custList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AccBalance_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label FPrintBalance_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Debt_lbl;
        private System.Windows.Forms.Label label7;
    }
}