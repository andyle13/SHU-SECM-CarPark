namespace SECM___Car_Park_Prototype_1
{
    partial class CryptoPayment
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
            this.header = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.qrcodeBox = new System.Windows.Forms.PictureBox();
            this.status_lbl = new System.Windows.Forms.Label();
            this.due_lbl = new System.Windows.Forms.Label();
            this.amountdue_lbl = new System.Windows.Forms.Label();
            this.paymentstatus_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qrcodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(291, 33);
            this.header.TabIndex = 27;
            this.header.Text = "Cryptocurrency Payment";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(15, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(306, 19);
            this.instruction.TabIndex = 26;
            this.instruction.Text = "Please scan this QR Code to make a payment.";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qrcodeBox
            // 
            this.qrcodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrcodeBox.Location = new System.Drawing.Point(19, 75);
            this.qrcodeBox.Name = "qrcodeBox";
            this.qrcodeBox.Size = new System.Drawing.Size(330, 330);
            this.qrcodeBox.TabIndex = 28;
            this.qrcodeBox.TabStop = false;
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lbl.Location = new System.Drawing.Point(367, 126);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(113, 19);
            this.status_lbl.TabIndex = 29;
            this.status_lbl.Text = "Payment status:";
            // 
            // due_lbl
            // 
            this.due_lbl.AutoSize = true;
            this.due_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due_lbl.Location = new System.Drawing.Point(367, 75);
            this.due_lbl.Name = "due_lbl";
            this.due_lbl.Size = new System.Drawing.Size(97, 19);
            this.due_lbl.TabIndex = 30;
            this.due_lbl.Text = "Payment due:";
            // 
            // amountdue_lbl
            // 
            this.amountdue_lbl.AutoSize = true;
            this.amountdue_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountdue_lbl.Location = new System.Drawing.Point(367, 94);
            this.amountdue_lbl.Name = "amountdue_lbl";
            this.amountdue_lbl.Size = new System.Drawing.Size(48, 19);
            this.amountdue_lbl.TabIndex = 30;
            this.amountdue_lbl.Text = "0 GBP";
            // 
            // paymentstatus_lbl
            // 
            this.paymentstatus_lbl.AutoSize = true;
            this.paymentstatus_lbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentstatus_lbl.Location = new System.Drawing.Point(367, 145);
            this.paymentstatus_lbl.Name = "paymentstatus_lbl";
            this.paymentstatus_lbl.Size = new System.Drawing.Size(61, 19);
            this.paymentstatus_lbl.TabIndex = 30;
            this.paymentstatus_lbl.Text = "Pending";
            this.paymentstatus_lbl.TextChanged += new System.EventHandler(this.paymentstatus_lbl_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(371, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_TickAsync);
            // 
            // CryptoPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paymentstatus_lbl);
            this.Controls.Add(this.amountdue_lbl);
            this.Controls.Add(this.due_lbl);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.qrcodeBox);
            this.Controls.Add(this.header);
            this.Controls.Add(this.instruction);
            this.Name = "CryptoPayment";
            this.Text = "Cryptocurrency Payment";
            ((System.ComponentModel.ISupportInitialize)(this.qrcodeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.PictureBox qrcodeBox;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Label due_lbl;
        private System.Windows.Forms.Label amountdue_lbl;
        private System.Windows.Forms.Label paymentstatus_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}