namespace SECM___Car_Park_Prototype_1
{
    partial class RelieveDebt
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
            this.debit_btn.Location = new System.Drawing.Point(168, 99);
            this.debit_btn.Name = "debit_btn";
            this.debit_btn.Size = new System.Drawing.Size(130, 35);
            this.debit_btn.TabIndex = 26;
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
            this.header.Size = new System.Drawing.Size(274, 33);
            this.header.TabIndex = 25;
            this.header.Text = "Relieve Customer Debt";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(15, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(248, 38);
            this.instruction.TabIndex = 24;
            this.instruction.Text = "Select an indebted customer for debt\r\nrelieval.";
            // 
            // custList
            // 
            this.custList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custList.FormattingEnabled = true;
            this.custList.Location = new System.Drawing.Point(18, 104);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(130, 27);
            this.custList.TabIndex = 23;
            this.custList.SelectedIndexChanged += new System.EventHandler(this.custList_SelectedIndexChanged);
            // 
            // RelieveDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 155);
            this.Controls.Add(this.debit_btn);
            this.Controls.Add(this.header);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.custList);
            this.Name = "RelieveDebt";
            this.Text = "Relieve Debt";
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