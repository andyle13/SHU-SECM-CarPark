namespace SECM___Car_Park_Prototype_1
{
    partial class parkLock
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
            this.custList = new System.Windows.Forms.ComboBox();
            this.header = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.lock_btn = new System.Windows.Forms.Button();
            this.park_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // custList
            // 
            this.custList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custList.FormattingEnabled = true;
            this.custList.Location = new System.Drawing.Point(18, 145);
            this.custList.Name = "custList";
            this.custList.Size = new System.Drawing.Size(130, 27);
            this.custList.TabIndex = 1;
            this.custList.SelectedIndexChanged += new System.EventHandler(this.custList_SelectedIndexChanged);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(167, 33);
            this.header.TabIndex = 14;
            this.header.Text = "Park and Lock";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(15, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(283, 19);
            this.instruction.TabIndex = 13;
            this.instruction.Text = "Please park your car at your allocated bay.";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lock_btn
            // 
            this.lock_btn.Enabled = false;
            this.lock_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lock_btn.Location = new System.Drawing.Point(168, 189);
            this.lock_btn.Name = "lock_btn";
            this.lock_btn.Size = new System.Drawing.Size(130, 35);
            this.lock_btn.TabIndex = 15;
            this.lock_btn.Text = "Lock";
            this.lock_btn.UseVisualStyleBackColor = true;
            this.lock_btn.Click += new System.EventHandler(this.lock_btn_Click);
            // 
            // park_btn
            // 
            this.park_btn.Enabled = false;
            this.park_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.park_btn.Location = new System.Drawing.Point(168, 140);
            this.park_btn.Name = "park_btn";
            this.park_btn.Size = new System.Drawing.Size(130, 35);
            this.park_btn.TabIndex = 16;
            this.park_btn.Text = "Park";
            this.park_btn.UseVisualStyleBackColor = true;
            this.park_btn.Click += new System.EventHandler(this.park_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 57);
            this.label1.TabIndex = 17;
            this.label1.Text = "You may as well consider locking your car\r\nto secure it from potential vandalism " +
    "and\r\ntheft.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parkLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.park_btn);
            this.Controls.Add(this.lock_btn);
            this.Controls.Add(this.header);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.custList);
            this.Name = "parkLock";
            this.Text = "parkLock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox custList;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Button lock_btn;
        private System.Windows.Forms.Button park_btn;
        private System.Windows.Forms.Label label1;
    }
}