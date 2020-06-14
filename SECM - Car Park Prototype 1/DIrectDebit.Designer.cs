namespace SECM___Car_Park_Prototype_1
{
    partial class DirectDebit
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
            this.debit_btn = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.custList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // debit_btn
            // 
            this.debit_btn.Enabled = false;
            this.debit_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debit_btn.Location = new System.Drawing.Point(168, 117);
            this.debit_btn.Name = "debit_btn";
            this.debit_btn.Size = new System.Drawing.Size(130, 35);
            this.debit_btn.TabIndex = 22;
            this.debit_btn.Text = "Debit Account";
            this.debit_btn.UseVisualStyleBackColor = true;
            this.debit_btn.Click += new System.EventHandler(this.debit_btn_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(242, 33);
            this.header.TabIndex = 20;
            this.header.Text = "Enforce Direct Debit";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(15, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(267, 57);
            this.instruction.TabIndex = 19;
            this.instruction.Text = "Select a customer whose FPrint Account\r\nhas a monthly Direct Debit subscription\r\n" +
    "to charge their account.";
            // 
            // custList
            // 
            this.custList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custList.FormattingEnabled = true;
            this.custList.Location = new System.Drawing.Point(18, 122);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(130, 27);
            this.custList.TabIndex = 18;
            this.custList.SelectedIndexChanged += new System.EventHandler(this.custList_SelectedIndexChanged);
            // 
            // DirectDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 167);
            this.Controls.Add(this.debit_btn);
            this.Controls.Add(this.header);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.custList);
            this.Name = "DirectDebit";
            this.Text = "Enforce Direct Debit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button debit_btn;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.ComboBox custList;
    }
}