namespace SECM___Car_Park_Prototype_1
{
    partial class setupCarPark
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
            this.instruction = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.nooflevels = new System.Windows.Forms.Label();
            this.floorSpaces = new System.Windows.Forms.Label();
            this.maxCapacity = new System.Windows.Forms.Label();
            this.levels = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.spaces = new System.Windows.Forms.TextBox();
            this.instantiation = new System.Windows.Forms.Button();
            this.capacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.Location = new System.Drawing.Point(17, 60);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(277, 57);
            this.instruction.TabIndex = 0;
            this.instruction.Text = "Please instantiate the Car Park declaring \r\nthe number of levels and parking spac" +
    "es\r\nper level.";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(14, 10);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(225, 33);
            this.header.TabIndex = 1;
            this.header.Text = "Setting up Car Park";
            // 
            // nooflevels
            // 
            this.nooflevels.AutoSize = true;
            this.nooflevels.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nooflevels.Location = new System.Drawing.Point(18, 128);
            this.nooflevels.Name = "nooflevels";
            this.nooflevels.Size = new System.Drawing.Size(126, 19);
            this.nooflevels.TabIndex = 2;
            this.nooflevels.Text = "Number of Levels:";
            // 
            // floorSpaces
            // 
            this.floorSpaces.AutoSize = true;
            this.floorSpaces.Cursor = System.Windows.Forms.Cursors.Default;
            this.floorSpaces.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorSpaces.Location = new System.Drawing.Point(156, 128);
            this.floorSpaces.Name = "floorSpaces";
            this.floorSpaces.Size = new System.Drawing.Size(173, 19);
            this.floorSpaces.TabIndex = 3;
            this.floorSpaces.Text = "Parking Spaces per Level:";
            // 
            // maxCapacity
            // 
            this.maxCapacity.AutoSize = true;
            this.maxCapacity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxCapacity.Location = new System.Drawing.Point(18, 193);
            this.maxCapacity.Name = "maxCapacity";
            this.maxCapacity.Size = new System.Drawing.Size(137, 19);
            this.maxCapacity.TabIndex = 4;
            this.maxCapacity.Text = "Maximum Capacity:";
            // 
            // levels
            // 
            this.levels.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.levels.Location = new System.Drawing.Point(22, 150);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(116, 23);
            this.levels.TabIndex = 5;
            this.levels.Text = "0";
            this.levels.TextChanged += new System.EventHandler(this.levels_TextChanged);
            this.levels.Enter += new System.EventHandler(this.levels_Enter);
            this.levels.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.levels_KeyPress);
            this.levels.Leave += new System.EventHandler(this.levels_Leave);
            // 
            // spaces
            // 
            this.spaces.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.spaces.Location = new System.Drawing.Point(160, 150);
            this.spaces.Name = "spaces";
            this.spaces.Size = new System.Drawing.Size(116, 23);
            this.spaces.TabIndex = 6;
            this.spaces.Text = "0";
            this.spaces.TextChanged += new System.EventHandler(this.spaces_TextChanged);
            this.spaces.Enter += new System.EventHandler(this.spaces_Enter);
            this.spaces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spaces_KeyPress);
            this.spaces.Leave += new System.EventHandler(this.spaces_Leave);
            // 
            // instantiation
            // 
            this.instantiation.Location = new System.Drawing.Point(22, 248);
            this.instantiation.Name = "instantiation";
            this.instantiation.Size = new System.Drawing.Size(307, 44);
            this.instantiation.TabIndex = 7;
            this.instantiation.Text = "Instantiate";
            this.instantiation.UseVisualStyleBackColor = true;
            this.instantiation.Click += new System.EventHandler(this.instantiation_Click);
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.Location = new System.Drawing.Point(20, 212);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(17, 19);
            this.capacity.TabIndex = 8;
            this.capacity.Text = "0";
            // 
            // setupCarPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 313);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.instantiation);
            this.Controls.Add(this.spaces);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.maxCapacity);
            this.Controls.Add(this.floorSpaces);
            this.Controls.Add(this.nooflevels);
            this.Controls.Add(this.header);
            this.Controls.Add(this.instruction);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "setupCarPark";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.setupCarPark_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label nooflevels;
        private System.Windows.Forms.Label floorSpaces;
        private System.Windows.Forms.Label maxCapacity;
        private System.Windows.Forms.TextBox levels;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox spaces;
        private System.Windows.Forms.Button instantiation;
        private System.Windows.Forms.Label capacity;
    }
}

