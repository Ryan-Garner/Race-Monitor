namespace MyRaceMonitor
{
    partial class CreateObserver
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.graphicalRadio = new System.Windows.Forms.RadioButton();
            this.emailRadio = new System.Windows.Forms.RadioButton();
            this.listRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.graphicalRadio);
            this.groupBox1.Controls.Add(this.emailRadio);
            this.groupBox1.Controls.Add(this.listRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observer Type";
            // 
            // graphicalRadio
            // 
            this.graphicalRadio.AutoSize = true;
            this.graphicalRadio.Location = new System.Drawing.Point(6, 51);
            this.graphicalRadio.Name = "graphicalRadio";
            this.graphicalRadio.Size = new System.Drawing.Size(107, 17);
            this.graphicalRadio.TabIndex = 2;
            this.graphicalRadio.TabStop = true;
            this.graphicalRadio.Text = "Graphical Display";
            this.graphicalRadio.UseVisualStyleBackColor = true;
            // 
            // emailRadio
            // 
            this.emailRadio.AutoSize = true;
            this.emailRadio.Location = new System.Drawing.Point(110, 19);
            this.emailRadio.Name = "emailRadio";
            this.emailRadio.Size = new System.Drawing.Size(50, 17);
            this.emailRadio.TabIndex = 1;
            this.emailRadio.TabStop = true;
            this.emailRadio.Text = "Email";
            this.emailRadio.UseVisualStyleBackColor = true;
            // 
            // listRadio
            // 
            this.listRadio.AutoSize = true;
            this.listRadio.Location = new System.Drawing.Point(6, 19);
            this.listRadio.Name = "listRadio";
            this.listRadio.Size = new System.Drawing.Size(78, 17);
            this.listRadio.TabIndex = 0;
            this.listRadio.TabStop = true;
            this.listRadio.Text = "List Display";
            this.listRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Observer Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create Observer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(18, 164);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateObserver
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(481, 199);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "CreateObserver";
            this.Text = "CreateObserver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton graphicalRadio;
        private System.Windows.Forms.RadioButton emailRadio;
        private System.Windows.Forms.RadioButton listRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelButton;
    }
}