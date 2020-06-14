namespace SECM___Car_Park_Prototype_1
{
    partial class EnterPark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterPark));
            this.custList = new System.Windows.Forms.ComboBox();
            this.header = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bayAllocator = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loweredTxt = new System.Windows.Forms.Label();
            this.raisedTxt = new System.Windows.Forms.Label();
            this.raised = new System.Windows.Forms.RadioButton();
            this.lowered = new System.Windows.Forms.RadioButton();
            this.FPrintScan = new System.Windows.Forms.Button();
            this.entryBarrierText = new System.Windows.Forms.Label();
            this.enterCP = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // custList
            // 
            this.custList.FormattingEnabled = true;
            this.custList.Location = new System.Drawing.Point(170, 22);
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
            this.header.Size = new System.Drawing.Size(74, 33);
            this.header.TabIndex = 12;
            this.header.Text = "Entry";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(15, 53);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(328, 19);
            this.instruction.TabIndex = 11;
            this.instruction.Text = "Please place your finger on the fingerprint reader.";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bayAllocator);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.FPrintScan);
            this.groupBox1.Controls.Add(this.entryBarrierText);
            this.groupBox1.Controls.Add(this.custList);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 140);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry Barrier";
            // 
            // bayAllocator
            // 
            this.bayAllocator.BackColor = System.Drawing.Color.DimGray;
            this.bayAllocator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bayAllocator.Font = new System.Drawing.Font("Calibri", 9F);
            this.bayAllocator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bayAllocator.Location = new System.Drawing.Point(9, 98);
            this.bayAllocator.Name = "bayAllocator";
            this.bayAllocator.Size = new System.Drawing.Size(148, 32);
            this.bayAllocator.TabIndex = 15;
            this.bayAllocator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loweredTxt);
            this.groupBox2.Controls.Add(this.raisedTxt);
            this.groupBox2.Controls.Add(this.raised);
            this.groupBox2.Controls.Add(this.lowered);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(317, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 90);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barrier Status";
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
            // FPrintScan
            // 
            this.FPrintScan.Enabled = false;
            this.FPrintScan.Location = new System.Drawing.Point(170, 62);
            this.FPrintScan.Name = "FPrintScan";
            this.FPrintScan.Size = new System.Drawing.Size(130, 67);
            this.FPrintScan.TabIndex = 13;
            this.FPrintScan.Text = "Fingerprint Scan";
            this.FPrintScan.UseVisualStyleBackColor = true;
            this.FPrintScan.Click += new System.EventHandler(this.FPrintScan_Click);
            // 
            // entryBarrierText
            // 
            this.entryBarrierText.BackColor = System.Drawing.Color.DimGray;
            this.entryBarrierText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryBarrierText.Font = new System.Drawing.Font("Calibri", 9F);
            this.entryBarrierText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.entryBarrierText.Location = new System.Drawing.Point(9, 23);
            this.entryBarrierText.Name = "entryBarrierText";
            this.entryBarrierText.Size = new System.Drawing.Size(148, 75);
            this.entryBarrierText.TabIndex = 14;
            this.entryBarrierText.Text = "Verify your identity.";
            this.entryBarrierText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterCP
            // 
            this.enterCP.Enabled = false;
            this.enterCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCP.Location = new System.Drawing.Point(18, 243);
            this.enterCP.Name = "enterCP";
            this.enterCP.Size = new System.Drawing.Size(311, 45);
            this.enterCP.TabIndex = 15;
            this.enterCP.Text = "Enter the Car Park";
            this.enterCP.UseVisualStyleBackColor = true;
            this.enterCP.Click += new System.EventHandler(this.enterCP_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(487, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 202);
            this.groupBox3.TabIndex = 28;
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
            // EnterPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 300);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.enterCP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.instruction);
            this.Name = "EnterPark";
            this.Text = "Enter Car Park";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox custList;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FPrintScan;
        private System.Windows.Forms.Label entryBarrierText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton raised;
        private System.Windows.Forms.RadioButton lowered;
        private System.Windows.Forms.Button enterCP;
        private System.Windows.Forms.Label loweredTxt;
        private System.Windows.Forms.Label raisedTxt;
        private System.Windows.Forms.Label bayAllocator;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
    }
}