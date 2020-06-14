namespace SECM___Car_Park_Prototype_1
{
    partial class ExitPark
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.queue_btn = new System.Windows.Forms.Button();
            this.barrierList = new System.Windows.Forms.ComboBox();
            this.custList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.exit_panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.queue_btn);
            this.groupBox1.Controls.Add(this.barrierList);
            this.groupBox1.Controls.Add(this.custList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 197);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gate Selection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Number of Exits:\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // queue_btn
            // 
            this.queue_btn.Enabled = false;
            this.queue_btn.Location = new System.Drawing.Point(10, 138);
            this.queue_btn.Name = "queue_btn";
            this.queue_btn.Size = new System.Drawing.Size(245, 47);
            this.queue_btn.TabIndex = 13;
            this.queue_btn.Text = "Queue for Exit";
            this.queue_btn.UseVisualStyleBackColor = true;
            this.queue_btn.Click += new System.EventHandler(this.queue_btn_Click);
            // 
            // barrierList
            // 
            this.barrierList.FormattingEnabled = true;
            this.barrierList.Location = new System.Drawing.Point(143, 95);
            this.barrierList.Name = "barrierList";
            this.barrierList.Size = new System.Drawing.Size(112, 27);
            this.barrierList.TabIndex = 0;
            this.barrierList.SelectedIndexChanged += new System.EventHandler(this.barrierList_SelectedIndexChanged);
            // 
            // custList
            // 
            this.custList.FormattingEnabled = true;
            this.custList.Location = new System.Drawing.Point(10, 95);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(112, 27);
            this.custList.TabIndex = 0;
            this.custList.SelectedIndexChanged += new System.EventHandler(this.custList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Determine Gate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(56, 33);
            this.header.TabIndex = 17;
            this.header.Text = "Exit";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(15, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(275, 114);
            this.instruction.TabIndex = 16;
            this.instruction.Text = "Please select an exit point of your choice\r\nto queue up the cars upon leaving the" +
    "\r\nCar Park.\r\n\r\nThank you for your visit. We hope you\r\nenjoyed staying with us on" +
    " your journey.\r\n";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exit_panel
            // 
            this.exit_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_panel.AutoScroll = true;
            this.exit_panel.Location = new System.Drawing.Point(296, 12);
            this.exit_panel.Name = "exit_panel";
            this.exit_panel.Size = new System.Drawing.Size(329, 395);
            this.exit_panel.TabIndex = 19;
            // 
            // ExitPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 433);
            this.Controls.Add(this.exit_panel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.instruction);
            this.Name = "ExitPark";
            this.Text = "Exit Car Park";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExitPark_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Panel exit_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button queue_btn;
        private System.Windows.Forms.ComboBox barrierList;
        private System.Windows.Forms.ComboBox custList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}