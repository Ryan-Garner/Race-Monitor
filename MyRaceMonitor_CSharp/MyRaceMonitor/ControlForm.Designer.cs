namespace MyRaceMonitor
{
    partial class ControlForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.observerName = new System.Windows.Forms.Label();
            this.addSubject = new System.Windows.Forms.Button();
            this.removeSubject = new System.Windows.Forms.Button();
            this.eventLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.beginEvent = new System.Windows.Forms.Button();
            this.observerView = new System.Windows.Forms.ListView();
            this.observedAthletes = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availableAthletes = new System.Windows.Forms.ListView();
            this.ID2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Observers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create Observer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Athletes";
            // 
            // observerName
            // 
            this.observerName.AutoSize = true;
            this.observerName.Location = new System.Drawing.Point(44, 243);
            this.observerName.Name = "observerName";
            this.observerName.Size = new System.Drawing.Size(123, 13);
            this.observerName.TabIndex = 6;
            this.observerName.Text = "Athletes being Observed";
            // 
            // addSubject
            // 
            this.addSubject.Location = new System.Drawing.Point(273, 289);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(40, 28);
            this.addSubject.TabIndex = 7;
            this.addSubject.Text = "<<";
            this.addSubject.UseVisualStyleBackColor = true;
            this.addSubject.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeSubject
            // 
            this.removeSubject.Location = new System.Drawing.Point(274, 323);
            this.removeSubject.Name = "removeSubject";
            this.removeSubject.Size = new System.Drawing.Size(39, 28);
            this.removeSubject.TabIndex = 8;
            this.removeSubject.Text = ">>";
            this.removeSubject.UseVisualStyleBackColor = true;
            this.removeSubject.Click += new System.EventHandler(this.removeSubject_Click);
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLabel.Location = new System.Drawing.Point(381, 46);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(106, 20);
            this.eventLabel.TabIndex = 9;
            this.eventLabel.Text = "Event Name";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(382, 66);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(82, 13);
            this.courseLabel.TabIndex = 10;
            this.courseLabel.Text = "Course Name";
            this.courseLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(382, 106);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(61, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Start Date: ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(382, 133);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(58, 13);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "Start Time:";
            // 
            // beginEvent
            // 
            this.beginEvent.Location = new System.Drawing.Point(387, 168);
            this.beginEvent.Name = "beginEvent";
            this.beginEvent.Size = new System.Drawing.Size(99, 25);
            this.beginEvent.TabIndex = 13;
            this.beginEvent.Text = "BeginEvent";
            this.beginEvent.UseVisualStyleBackColor = true;
            this.beginEvent.Click += new System.EventHandler(this.beginEvent_Click);
            // 
            // observerView
            // 
            this.observerView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.observerView.Location = new System.Drawing.Point(47, 37);
            this.observerView.MultiSelect = false;
            this.observerView.Name = "observerView";
            this.observerView.Size = new System.Drawing.Size(164, 157);
            this.observerView.TabIndex = 14;
            this.observerView.UseCompatibleStateImageBehavior = false;
            this.observerView.SelectedIndexChanged += new System.EventHandler(this.observerView_SelectedIndexChanged);
            // 
            // observedAthletes
            // 
            this.observedAthletes.AllowColumnReorder = true;
            this.observedAthletes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Time,
            this.Location});
            this.observedAthletes.FullRowSelect = true;
            this.observedAthletes.Location = new System.Drawing.Point(12, 259);
            this.observedAthletes.MultiSelect = false;
            this.observedAthletes.Name = "observedAthletes";
            this.observedAthletes.Size = new System.Drawing.Size(184, 179);
            this.observedAthletes.TabIndex = 15;
            this.observedAthletes.UseCompatibleStateImageBehavior = false;
            this.observedAthletes.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // Time
            // 
            this.Time.Text = "Time";
            // 
            // Location
            // 
            this.Location.Text = "Location";
            // 
            // availableAthletes
            // 
            this.availableAthletes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID2,
            this.Time2,
            this.Location2});
            this.availableAthletes.FullRowSelect = true;
            this.availableAthletes.HideSelection = false;
            this.availableAthletes.Location = new System.Drawing.Point(381, 259);
            this.availableAthletes.MultiSelect = false;
            this.availableAthletes.Name = "availableAthletes";
            this.availableAthletes.Size = new System.Drawing.Size(185, 173);
            this.availableAthletes.TabIndex = 16;
            this.availableAthletes.UseCompatibleStateImageBehavior = false;
            this.availableAthletes.View = System.Windows.Forms.View.Details;
            // 
            // ID2
            // 
            this.ID2.Text = "ID";
            // 
            // Time2
            // 
            this.Time2.Text = "Time";
            // 
            // Location2
            // 
            this.Location2.Text = "Location";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Observer Name";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.availableAthletes);
            this.Controls.Add(this.observedAthletes);
            this.Controls.Add(this.observerView);
            this.Controls.Add(this.beginEvent);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.removeSubject);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.observerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label observerName;
        private System.Windows.Forms.Button addSubject;
        private System.Windows.Forms.Button removeSubject;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button beginEvent;
        private System.Windows.Forms.ListView observerView;
        private System.Windows.Forms.ListView observedAthletes;
        private System.Windows.Forms.ListView availableAthletes;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader ID2;
        private System.Windows.Forms.ColumnHeader Time2;
        private System.Windows.Forms.ColumnHeader Location2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}