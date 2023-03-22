namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.japan = new System.Windows.Forms.CheckBox();
            this.philippines = new System.Windows.Forms.CheckBox();
            this.thailand = new System.Windows.Forms.CheckBox();
            this.survey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.othersLabel = new System.Windows.Forms.Label();
            this.australlia = new System.Windows.Forms.CheckBox();
            this.othersBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.others = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // japan
            // 
            this.japan.AutoSize = true;
            this.japan.Location = new System.Drawing.Point(39, 120);
            this.japan.Name = "japan";
            this.japan.Size = new System.Drawing.Size(55, 17);
            this.japan.TabIndex = 0;
            this.japan.Text = "Japan";
            this.japan.UseVisualStyleBackColor = true;
            // 
            // philippines
            // 
            this.philippines.AutoSize = true;
            this.philippines.Location = new System.Drawing.Point(39, 158);
            this.philippines.Name = "philippines";
            this.philippines.Size = new System.Drawing.Size(76, 17);
            this.philippines.TabIndex = 1;
            this.philippines.Text = "Philippines";
            this.philippines.UseVisualStyleBackColor = true;
            // 
            // thailand
            // 
            this.thailand.AutoSize = true;
            this.thailand.Location = new System.Drawing.Point(128, 120);
            this.thailand.Name = "thailand";
            this.thailand.Size = new System.Drawing.Size(67, 17);
            this.thailand.TabIndex = 2;
            this.thailand.Text = "Thailand";
            this.thailand.UseVisualStyleBackColor = true;
            // 
            // survey
            // 
            this.survey.AutoSize = true;
            this.survey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survey.Location = new System.Drawing.Point(34, 38);
            this.survey.Name = "survey";
            this.survey.Size = new System.Drawing.Size(85, 25);
            this.survey.TabIndex = 3;
            this.survey.Text = "Survey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "What country would you like to visit?";
            // 
            // othersLabel
            // 
            this.othersLabel.AutoSize = true;
            this.othersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersLabel.Location = new System.Drawing.Point(35, 226);
            this.othersLabel.Name = "othersLabel";
            this.othersLabel.Size = new System.Drawing.Size(187, 20);
            this.othersLabel.TabIndex = 5;
            this.othersLabel.Text = "If Others, Please Specify.";
            this.othersLabel.Visible = false;
            this.othersLabel.Click += new System.EventHandler(this.othersLabel_Click);
            // 
            // australlia
            // 
            this.australlia.AutoSize = true;
            this.australlia.Location = new System.Drawing.Point(128, 158);
            this.australlia.Name = "australlia";
            this.australlia.Size = new System.Drawing.Size(68, 17);
            this.australlia.TabIndex = 9;
            this.australlia.Text = "Australlia";
            this.australlia.UseVisualStyleBackColor = true;
            // 
            // othersBox
            // 
            this.othersBox.Location = new System.Drawing.Point(39, 269);
            this.othersBox.Name = "othersBox";
            this.othersBox.Size = new System.Drawing.Size(212, 20);
            this.othersBox.TabIndex = 10;
            this.othersBox.Visible = false;
            this.othersBox.TextChanged += new System.EventHandler(this.others_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(106, 333);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 11;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // others
            // 
            this.others.AutoSize = true;
            this.others.Location = new System.Drawing.Point(39, 193);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(57, 17);
            this.others.TabIndex = 13;
            this.others.Text = "Others";
            this.others.UseVisualStyleBackColor = true;
            this.others.CheckedChanged += new System.EventHandler(this.others_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 446);
            this.Controls.Add(this.others);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.othersBox);
            this.Controls.Add(this.australlia);
            this.Controls.Add(this.othersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.survey);
            this.Controls.Add(this.thailand);
            this.Controls.Add(this.philippines);
            this.Controls.Add(this.japan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox japan;
        private System.Windows.Forms.CheckBox philippines;
        private System.Windows.Forms.CheckBox thailand;
        private System.Windows.Forms.Label survey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label othersLabel;
        private System.Windows.Forms.CheckBox australlia;
        private System.Windows.Forms.TextBox othersBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox others;
    }
}

