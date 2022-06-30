
namespace Contact_Tracing_Form_02
{
    partial class Contacttracingform
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
            this.temperaturelbl = new System.Windows.Forms.Label();
            this.timebx = new System.Windows.Forms.TextBox();
            this.timelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.formlbl = new System.Windows.Forms.Label();
            this.temperaturebx = new System.Windows.Forms.TextBox();
            this.datebx = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactTracingFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // temperaturelbl
            // 
            this.temperaturelbl.AutoSize = true;
            this.temperaturelbl.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.temperaturelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.temperaturelbl.Location = new System.Drawing.Point(55, 216);
            this.temperaturelbl.Name = "temperaturelbl";
            this.temperaturelbl.Size = new System.Drawing.Size(96, 23);
            this.temperaturelbl.TabIndex = 81;
            this.temperaturelbl.Text = "Temperature:";
            // 
            // timebx
            // 
            this.timebx.Location = new System.Drawing.Point(157, 172);
            this.timebx.Name = "timebx";
            this.timebx.Size = new System.Drawing.Size(225, 20);
            this.timebx.TabIndex = 80;
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.timelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timelbl.Location = new System.Drawing.Point(55, 168);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(47, 23);
            this.timelbl.TabIndex = 79;
            this.timelbl.Text = "Time:";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.datelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datelbl.Location = new System.Drawing.Point(56, 123);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(47, 23);
            this.datelbl.TabIndex = 78;
            this.datelbl.Text = "Date: ";
            // 
            // formlbl
            // 
            this.formlbl.AutoSize = true;
            this.formlbl.Font = new System.Drawing.Font("Palatino Linotype", 21.75F);
            this.formlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.formlbl.Location = new System.Drawing.Point(37, 47);
            this.formlbl.Name = "formlbl";
            this.formlbl.Size = new System.Drawing.Size(439, 38);
            this.formlbl.TabIndex = 77;
            this.formlbl.Text = "COVID 19 Contact Tracing Form";
            // 
            // temperaturebx
            // 
            this.temperaturebx.Location = new System.Drawing.Point(157, 220);
            this.temperaturebx.Name = "temperaturebx";
            this.temperaturebx.Size = new System.Drawing.Size(225, 20);
            this.temperaturebx.TabIndex = 82;
            // 
            // datebx
            // 
            this.datebx.Location = new System.Drawing.Point(157, 126);
            this.datebx.Name = "datebx";
            this.datebx.Size = new System.Drawing.Size(225, 20);
            this.datebx.TabIndex = 123;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.contactTracingFormToolStripMenuItem,
            this.recordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 124;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contactTracingFormToolStripMenuItem
            // 
            this.contactTracingFormToolStripMenuItem.Name = "contactTracingFormToolStripMenuItem";
            this.contactTracingFormToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.contactTracingFormToolStripMenuItem.Text = "Contact tracing form";
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.qRCodeToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.recordsToolStripMenuItem.Text = "Records";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // qRCodeToolStripMenuItem
            // 
            this.qRCodeToolStripMenuItem.Name = "qRCodeToolStripMenuItem";
            this.qRCodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qRCodeToolStripMenuItem.Text = "QR Code";
            // 
            // Contacttracingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 303);
            this.Controls.Add(this.datebx);
            this.Controls.Add(this.temperaturebx);
            this.Controls.Add(this.temperaturelbl);
            this.Controls.Add(this.timebx);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.formlbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Contacttracingform";
            this.Text = "Contact Tracing Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label temperaturelbl;
        private System.Windows.Forms.TextBox timebx;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label formlbl;
        private System.Windows.Forms.TextBox temperaturebx;
        private System.Windows.Forms.TextBox datebx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactTracingFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qRCodeToolStripMenuItem;
    }
}

