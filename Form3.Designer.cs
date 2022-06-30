
namespace Contact_Tracing_Form_02
{
    partial class Findspecificrecord
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
            this.Exitbttn = new System.Windows.Forms.Button();
            this.Back2bttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exitbttn
            // 
            this.Exitbttn.Location = new System.Drawing.Point(689, 411);
            this.Exitbttn.Name = "Exitbttn";
            this.Exitbttn.Size = new System.Drawing.Size(84, 27);
            this.Exitbttn.TabIndex = 4;
            this.Exitbttn.Text = "Exit";
            this.Exitbttn.UseVisualStyleBackColor = true;
            this.Exitbttn.Click += new System.EventHandler(this.Exitbttn_Click);
            // 
            // Back2bttn
            // 
            this.Back2bttn.Location = new System.Drawing.Point(12, 411);
            this.Back2bttn.Name = "Back2bttn";
            this.Back2bttn.Size = new System.Drawing.Size(84, 27);
            this.Back2bttn.TabIndex = 3;
            this.Back2bttn.Text = "Back";
            this.Back2bttn.UseVisualStyleBackColor = true;
            this.Back2bttn.Click += new System.EventHandler(this.Back2bttn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 309);
            this.dataGridView1.TabIndex = 5;
            // 
            // Findspecificrecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exitbttn);
            this.Controls.Add(this.Back2bttn);
            this.Name = "Findspecificrecord";
            this.Text = "Select specific record";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exitbttn;
        private System.Windows.Forms.Button Back2bttn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}