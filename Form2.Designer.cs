﻿
namespace Contact_Tracing_Form_02
{
    partial class Listofrecordsform
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
            this.Backbttn = new System.Windows.Forms.Button();
            this.Nextbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Backbttn
            // 
            this.Backbttn.Location = new System.Drawing.Point(12, 411);
            this.Backbttn.Name = "Backbttn";
            this.Backbttn.Size = new System.Drawing.Size(84, 27);
            this.Backbttn.TabIndex = 1;
            this.Backbttn.Text = "Back";
            this.Backbttn.UseVisualStyleBackColor = true;
            this.Backbttn.Click += new System.EventHandler(this.Backbttn_Click);
            // 
            // Nextbttn
            // 
            this.Nextbttn.Location = new System.Drawing.Point(377, 411);
            this.Nextbttn.Name = "Nextbttn";
            this.Nextbttn.Size = new System.Drawing.Size(84, 27);
            this.Nextbttn.TabIndex = 2;
            this.Nextbttn.Text = "Next";
            this.Nextbttn.UseVisualStyleBackColor = true;
            this.Nextbttn.Click += new System.EventHandler(this.Nextbttn_Click);
            // 
            // Listofrecordsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.Nextbttn);
            this.Controls.Add(this.Backbttn);
            this.Name = "Listofrecordsform";
            this.Text = "List of all records";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Backbttn;
        private System.Windows.Forms.Button Nextbttn;
    }
}