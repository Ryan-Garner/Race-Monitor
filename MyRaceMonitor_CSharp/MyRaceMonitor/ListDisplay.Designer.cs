namespace MyRaceMonitor
{
    partial class ListDisplay
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
            this.athletesObserved = new System.Windows.Forms.ListView();
            this.ID3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // athletesObserved
            // 
            this.athletesObserved.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID3,
            this.FirstName,
            this.LastName,
            this.Time,
            this.Location,
            this.Status});
            this.athletesObserved.Location = new System.Drawing.Point(4, 4);
            this.athletesObserved.Name = "athletesObserved";
            this.athletesObserved.Size = new System.Drawing.Size(727, 484);
            this.athletesObserved.TabIndex = 0;
            this.athletesObserved.UseCompatibleStateImageBehavior = false;
            this.athletesObserved.View = System.Windows.Forms.View.Details;
            // 
            // ID3
            // 
            this.ID3.Text = "ID";
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            // 
            // Time
            // 
            this.Time.Text = "Time";
            // 
            // Location
            // 
            this.Location.Text = "Location";
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // ListDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 493);
            this.Controls.Add(this.athletesObserved);
            this.Name = "ListDisplay";
            this.Text = "ListDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView athletesObserved;
        private System.Windows.Forms.ColumnHeader ID3;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader Status;
    }
}