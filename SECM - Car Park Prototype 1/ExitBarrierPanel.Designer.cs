namespace SECM___Car_Park_Prototype_1
{
    partial class ExitBarrierPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.exitBarrierGroup = new System.Windows.Forms.GroupBox();
            this.exitCP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.loweredTxt = new System.Windows.Forms.Label();
            this.raisedTxt = new System.Windows.Forms.Label();
            this.raised = new System.Windows.Forms.RadioButton();
            this.lowered = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.queue_list = new System.Windows.Forms.ListBox();
            this.chip_btn = new System.Windows.Forms.Button();
            this.FPrintScan = new System.Windows.Forms.Button();
            this.exitBarrierText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exitBarrierGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBarrierGroup
            // 
            this.exitBarrierGroup.Controls.Add(this.exitCP);
            this.exitBarrierGroup.Controls.Add(this.groupBox3);
            this.exitBarrierGroup.Controls.Add(this.groupBox2);
            this.exitBarrierGroup.Controls.Add(this.chip_btn);
            this.exitBarrierGroup.Controls.Add(this.FPrintScan);
            this.exitBarrierGroup.Controls.Add(this.exitBarrierText);
            this.exitBarrierGroup.Enabled = false;
            this.exitBarrierGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBarrierGroup.Location = new System.Drawing.Point(3, 6);
            this.exitBarrierGroup.Name = "exitBarrierGroup";
            this.exitBarrierGroup.Size = new System.Drawing.Size(320, 352);
            this.exitBarrierGroup.TabIndex = 14;
            this.exitBarrierGroup.TabStop = false;
            this.exitBarrierGroup.Text = "Exit Barrier";
            // 
            // exitCP
            // 
            this.exitCP.Enabled = false;
            this.exitCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitCP.Location = new System.Drawing.Point(6, 301);
            this.exitCP.Name = "exitCP";
            this.exitCP.Size = new System.Drawing.Size(308, 45);
            this.exitCP.TabIndex = 18;
            this.exitCP.Text = "Exit the Car Park";
            this.exitCP.UseVisualStyleBackColor = true;
            this.exitCP.Click += new System.EventHandler(this.exitCP_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loweredTxt);
            this.groupBox3.Controls.Add(this.raisedTxt);
            this.groupBox3.Controls.Add(this.raised);
            this.groupBox3.Controls.Add(this.lowered);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(167, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 90);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Barrier Status";
            // 
            // loweredTxt
            // 
            this.loweredTxt.AutoSize = true;
            this.loweredTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loweredTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loweredTxt.Location = new System.Drawing.Point(36, 26);
            this.loweredTxt.Name = "loweredTxt";
            this.loweredTxt.Size = new System.Drawing.Size(64, 19);
            this.loweredTxt.TabIndex = 17;
            this.loweredTxt.Text = "Lowered";
            this.loweredTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // raisedTxt
            // 
            this.raisedTxt.AutoSize = true;
            this.raisedTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raisedTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raisedTxt.Location = new System.Drawing.Point(36, 55);
            this.raisedTxt.Name = "raisedTxt";
            this.raisedTxt.Size = new System.Drawing.Size(53, 19);
            this.raisedTxt.TabIndex = 16;
            this.raisedTxt.Text = "Raised";
            this.raisedTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // raised
            // 
            this.raised.AutoSize = true;
            this.raised.Enabled = false;
            this.raised.Location = new System.Drawing.Point(16, 58);
            this.raised.Name = "raised";
            this.raised.Size = new System.Drawing.Size(14, 13);
            this.raised.TabIndex = 15;
            this.raised.UseVisualStyleBackColor = true;
            // 
            // lowered
            // 
            this.lowered.AutoSize = true;
            this.lowered.Checked = true;
            this.lowered.Enabled = false;
            this.lowered.Location = new System.Drawing.Point(16, 29);
            this.lowered.Name = "lowered";
            this.lowered.Size = new System.Drawing.Size(14, 13);
            this.lowered.TabIndex = 14;
            this.lowered.TabStop = true;
            this.lowered.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.queue_list);
            this.groupBox2.Location = new System.Drawing.Point(167, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 168);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Queue";
            // 
            // queue_list
            // 
            this.queue_list.FormattingEnabled = true;
            this.queue_list.ItemHeight = 19;
            this.queue_list.Location = new System.Drawing.Point(6, 26);
            this.queue_list.Name = "queue_list";
            this.queue_list.Size = new System.Drawing.Size(135, 137);
            this.queue_list.TabIndex = 16;
            // 
            // chip_btn
            // 
            this.chip_btn.Enabled = false;
            this.chip_btn.Location = new System.Drawing.Point(6, 251);
            this.chip_btn.Name = "chip_btn";
            this.chip_btn.Size = new System.Drawing.Size(147, 38);
            this.chip_btn.TabIndex = 13;
            this.chip_btn.Text = "Insert Chip Coin";
            this.chip_btn.UseVisualStyleBackColor = true;
            this.chip_btn.Click += new System.EventHandler(this.chip_btn_Click);
            // 
            // FPrintScan
            // 
            this.FPrintScan.Enabled = false;
            this.FPrintScan.Location = new System.Drawing.Point(6, 207);
            this.FPrintScan.Name = "FPrintScan";
            this.FPrintScan.Size = new System.Drawing.Size(147, 38);
            this.FPrintScan.TabIndex = 13;
            this.FPrintScan.Text = "Fingerprint Scan";
            this.FPrintScan.UseVisualStyleBackColor = true;
            this.FPrintScan.Click += new System.EventHandler(this.FPrintScan_Click);
            // 
            // exitBarrierText
            // 
            this.exitBarrierText.BackColor = System.Drawing.Color.DimGray;
            this.exitBarrierText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exitBarrierText.Font = new System.Drawing.Font("Calibri", 9F);
            this.exitBarrierText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitBarrierText.Location = new System.Drawing.Point(6, 26);
            this.exitBarrierText.Name = "exitBarrierText";
            this.exitBarrierText.Size = new System.Drawing.Size(147, 168);
            this.exitBarrierText.TabIndex = 14;
            this.exitBarrierText.Text = "Verify your identity.";
            this.exitBarrierText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExitBarrierPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exitBarrierGroup);
            this.Name = "ExitBarrierPanel";
            this.Size = new System.Drawing.Size(329, 377);
            this.exitBarrierGroup.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox exitBarrierGroup;
        private System.Windows.Forms.Button FPrintScan;
        private System.Windows.Forms.Label exitBarrierText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label loweredTxt;
        private System.Windows.Forms.Label raisedTxt;
        private System.Windows.Forms.RadioButton raised;
        private System.Windows.Forms.RadioButton lowered;
        private System.Windows.Forms.Button exitCP;
        private System.Windows.Forms.Button chip_btn;
        private System.Windows.Forms.ListBox queue_list;
        private System.Windows.Forms.Timer timer1;
    }
}
