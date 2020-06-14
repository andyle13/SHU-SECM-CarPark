namespace SECM___Car_Park_Prototype_1
{
    partial class PaymentMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentMachine));
            this.InsertCoin_btn = new System.Windows.Forms.Button();
            this.custList = new System.Windows.Forms.ComboBox();
            this.pay_btn = new System.Windows.Forms.Button();
            this.voucher_btn = new System.Windows.Forms.Button();
            this.ChipCoinLost_btn = new System.Windows.Forms.Button();
            this.custRecPanel = new System.Windows.Forms.GroupBox();
            this.paymentScreen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.crypto_btn = new System.Windows.Forms.RadioButton();
            this.card_btn = new System.Windows.Forms.RadioButton();
            this.cash_btn = new System.Windows.Forms.RadioButton();
            this.header = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.paymentPanel = new System.Windows.Forms.GroupBox();
            this.balance_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custRecPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.paymentPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertCoin_btn
            // 
            this.InsertCoin_btn.Enabled = false;
            this.InsertCoin_btn.Location = new System.Drawing.Point(290, 56);
            this.InsertCoin_btn.Name = "InsertCoin_btn";
            this.InsertCoin_btn.Size = new System.Drawing.Size(141, 29);
            this.InsertCoin_btn.TabIndex = 15;
            this.InsertCoin_btn.Text = "Insert Coin";
            this.InsertCoin_btn.UseVisualStyleBackColor = true;
            this.InsertCoin_btn.Click += new System.EventHandler(this.FPrintScan_Click);
            // 
            // custList
            // 
            this.custList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custList.FormattingEnabled = true;
            this.custList.Location = new System.Drawing.Point(290, 23);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(141, 27);
            this.custList.TabIndex = 16;
            this.custList.SelectedIndexChanged += new System.EventHandler(this.custList_SelectedIndexChanged);
            // 
            // pay_btn
            // 
            this.pay_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.Location = new System.Drawing.Point(15, 99);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(202, 36);
            this.pay_btn.TabIndex = 17;
            this.pay_btn.Text = "Pay for Exit";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // voucher_btn
            // 
            this.voucher_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucher_btn.Location = new System.Drawing.Point(15, 57);
            this.voucher_btn.Name = "voucher_btn";
            this.voucher_btn.Size = new System.Drawing.Size(202, 36);
            this.voucher_btn.TabIndex = 19;
            this.voucher_btn.Text = "Voucher Redemption";
            this.voucher_btn.UseVisualStyleBackColor = true;
            this.voucher_btn.Click += new System.EventHandler(this.voucher_btn_Click);
            // 
            // ChipCoinLost_btn
            // 
            this.ChipCoinLost_btn.Enabled = false;
            this.ChipCoinLost_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipCoinLost_btn.Location = new System.Drawing.Point(290, 91);
            this.ChipCoinLost_btn.Name = "ChipCoinLost_btn";
            this.ChipCoinLost_btn.Size = new System.Drawing.Size(141, 29);
            this.ChipCoinLost_btn.TabIndex = 20;
            this.ChipCoinLost_btn.Text = "Chip Coin Lost?";
            this.ChipCoinLost_btn.UseVisualStyleBackColor = true;
            this.ChipCoinLost_btn.Click += new System.EventHandler(this.ChipCoinLost_btn_Click);
            // 
            // custRecPanel
            // 
            this.custRecPanel.Controls.Add(this.paymentScreen);
            this.custRecPanel.Controls.Add(this.InsertCoin_btn);
            this.custRecPanel.Controls.Add(this.custList);
            this.custRecPanel.Controls.Add(this.ChipCoinLost_btn);
            this.custRecPanel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custRecPanel.Location = new System.Drawing.Point(19, 94);
            this.custRecPanel.Name = "custRecPanel";
            this.custRecPanel.Size = new System.Drawing.Size(446, 128);
            this.custRecPanel.TabIndex = 21;
            this.custRecPanel.TabStop = false;
            this.custRecPanel.Text = "Customer Recognition Panel";
            // 
            // paymentScreen
            // 
            this.paymentScreen.BackColor = System.Drawing.Color.DimGray;
            this.paymentScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentScreen.Font = new System.Drawing.Font("Calibri", 10F);
            this.paymentScreen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.paymentScreen.Location = new System.Drawing.Point(15, 35);
            this.paymentScreen.Name = "paymentScreen";
            this.paymentScreen.Size = new System.Drawing.Size(251, 67);
            this.paymentScreen.TabIndex = 23;
            this.paymentScreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.crypto_btn);
            this.groupBox2.Controls.Add(this.card_btn);
            this.groupBox2.Controls.Add(this.cash_btn);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(235, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 107);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Type";
            // 
            // crypto_btn
            // 
            this.crypto_btn.AutoSize = true;
            this.crypto_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.crypto_btn.Font = new System.Drawing.Font("Calibri", 12F);
            this.crypto_btn.Location = new System.Drawing.Point(17, 78);
            this.crypto_btn.Name = "crypto_btn";
            this.crypto_btn.Size = new System.Drawing.Size(158, 23);
            this.crypto_btn.TabIndex = 18;
            this.crypto_btn.Text = "Cryptocurrency Scan";
            this.crypto_btn.UseVisualStyleBackColor = true;
            this.crypto_btn.CheckedChanged += new System.EventHandler(this.crypto_btn_CheckedChanged);
            // 
            // card_btn
            // 
            this.card_btn.AutoSize = true;
            this.card_btn.Checked = true;
            this.card_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.card_btn.Font = new System.Drawing.Font("Calibri", 12F);
            this.card_btn.Location = new System.Drawing.Point(17, 23);
            this.card_btn.Name = "card_btn";
            this.card_btn.Size = new System.Drawing.Size(57, 23);
            this.card_btn.TabIndex = 17;
            this.card_btn.TabStop = true;
            this.card_btn.Text = "Card";
            this.card_btn.UseVisualStyleBackColor = true;
            this.card_btn.CheckedChanged += new System.EventHandler(this.card_btn_CheckedChanged);
            // 
            // cash_btn
            // 
            this.cash_btn.AutoSize = true;
            this.cash_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cash_btn.Font = new System.Drawing.Font("Calibri", 12F);
            this.cash_btn.Location = new System.Drawing.Point(17, 52);
            this.cash_btn.Name = "cash_btn";
            this.cash_btn.Size = new System.Drawing.Size(176, 23);
            this.cash_btn.TabIndex = 16;
            this.cash_btn.Text = "Cash (15% Tax Charge)";
            this.cash_btn.UseVisualStyleBackColor = true;
            this.cash_btn.CheckedChanged += new System.EventHandler(this.cash_btn_CheckedChanged);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(216, 33);
            this.header.TabIndex = 25;
            this.header.Text = "Payment Machine";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(15, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(270, 38);
            this.instruction.TabIndex = 24;
            this.instruction.Text = "Please insert your chip coin or scan your\r\nfingerprint to operate this machine.";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paymentPanel
            // 
            this.paymentPanel.Controls.Add(this.balance_lbl);
            this.paymentPanel.Controls.Add(this.label1);
            this.paymentPanel.Controls.Add(this.groupBox2);
            this.paymentPanel.Controls.Add(this.voucher_btn);
            this.paymentPanel.Controls.Add(this.pay_btn);
            this.paymentPanel.Enabled = false;
            this.paymentPanel.Font = new System.Drawing.Font("Calibri", 12F);
            this.paymentPanel.Location = new System.Drawing.Point(19, 239);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(446, 150);
            this.paymentPanel.TabIndex = 26;
            this.paymentPanel.TabStop = false;
            this.paymentPanel.Text = "Payment Panel";
            // 
            // balance_lbl
            // 
            this.balance_lbl.Location = new System.Drawing.Point(134, 28);
            this.balance_lbl.Name = "balance_lbl";
            this.balance_lbl.Size = new System.Drawing.Size(83, 19);
            this.balance_lbl.TabIndex = 24;
            this.balance_lbl.Text = "0 GBP";
            this.balance_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Current Balance:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(484, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 202);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charging Structure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 171);
            this.label2.TabIndex = 17;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 401);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.paymentPanel);
            this.Controls.Add(this.header);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.custRecPanel);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PaymentMachine";
            this.Text = "Payment Machine";
            this.custRecPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InsertCoin_btn;
        private System.Windows.Forms.ComboBox custList;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Button voucher_btn;
        private System.Windows.Forms.Button ChipCoinLost_btn;
        private System.Windows.Forms.GroupBox custRecPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton card_btn;
        private System.Windows.Forms.RadioButton cash_btn;
        private System.Windows.Forms.RadioButton crypto_btn;
        private System.Windows.Forms.Label paymentScreen;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.GroupBox paymentPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label balance_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
    }
}