namespace MyRaceMonitor
{
    partial class StartUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.eventBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.startRaceMonitor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Race Montitor System";
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(12, 112);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(167, 20);
            this.courseBox.TabIndex = 1;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(312, 112);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(171, 20);
            this.lengthBox.TabIndex = 2;
            // 
            // eventBox
            // 
            this.eventBox.Location = new System.Drawing.Point(12, 166);
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(167, 20);
            this.eventBox.TabIndex = 3;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(312, 166);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(171, 20);
            this.dateBox.TabIndex = 4;
            // 
            // startRaceMonitor
            // 
            this.startRaceMonitor.Location = new System.Drawing.Point(31, 214);
            this.startRaceMonitor.Name = "startRaceMonitor";
            this.startRaceMonitor.Size = new System.Drawing.Size(129, 23);
            this.startRaceMonitor.TabIndex = 5;
            this.startRaceMonitor.Text = "Begin Race Monitor";
            this.startRaceMonitor.UseVisualStyleBackColor = true;
            this.startRaceMonitor.Click += new System.EventHandler(this.startRaceMonitor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Course Name";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(312, 215);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(170, 20);
            this.timeBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Event Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Event Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Event Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter Course Length";
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 247);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startRaceMonitor);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.label1);
            this.Name = "StartUp";
            this.Text = "StartUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox eventBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Button startRaceMonitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}