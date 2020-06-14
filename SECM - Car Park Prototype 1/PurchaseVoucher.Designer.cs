namespace SECM___Car_Park_Prototype_1
{
    partial class PurchaseVoucher
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
            this.buyVoucher = new System.Windows.Forms.Button();
            this.custList = new System.Windows.Forms.ComboBox();
            this.header = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VoucherList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buyVoucher
            // 
            this.buyVoucher.Enabled = false;
            this.buyVoucher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyVoucher.Location = new System.Drawing.Point(19, 144);
            this.buyVoucher.Name = "buyVoucher";
            this.buyVoucher.Size = new System.Drawing.Size(311, 45);
            this.buyVoucher.TabIndex = 19;
            this.buyVoucher.Text = "Purchase Voucher";
            this.buyVoucher.UseVisualStyleBackColor = true;
            this.buyVoucher.Click += new System.EventHandler(this.buyVoucher_Click);
            // 
            // custList
            // 
            this.custList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custList.FormattingEnabled = true;
            this.custList.Location = new System.Drawing.Point(19, 105);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(130, 27);
            this.custList.TabIndex = 0;
            this.custList.SelectedIndexChanged += new System.EventHandler(this.custList_SelectedIndexChanged);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(215, 33);
            this.header.TabIndex = 17;
            this.header.Text = "Purchase Voucher";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(15, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(299, 19);
            this.instruction.TabIndex = 16;
            this.instruction.Text = "Buy a Voucher before you enter the Car Park.";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Customer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Voucher Value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VoucherList
            // 
            this.VoucherList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoucherList.FormattingEnabled = true;
            this.VoucherList.Location = new System.Drawing.Point(200, 105);
            this.VoucherList.Name = "VoucherList";
            this.VoucherList.Size = new System.Drawing.Size(130, 27);
            this.VoucherList.TabIndex = 0;
            this.VoucherList.SelectedIndexChanged += new System.EventHandler(this.VoucherList_SelectedIndexChanged);
            // 
            // PurchaseVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 211);
            this.Controls.Add(this.VoucherList);
            this.Controls.Add(this.custList);
            this.Controls.Add(this.buyVoucher);
            this.Controls.Add(this.header);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instruction);
            this.Name = "PurchaseVoucher";
            this.Text = "PurchaseVoucher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buyVoucher;
        private System.Windows.Forms.ComboBox custList;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VoucherList;
    }
}