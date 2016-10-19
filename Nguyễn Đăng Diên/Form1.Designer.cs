namespace phototool
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
            this.btnload = new System.Windows.Forms.Button();
            this.pbxphoto = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnufile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuload = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuexit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxphoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(13, 32);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 23);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // pbxphoto
            // 
            this.pbxphoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxphoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxphoto.Location = new System.Drawing.Point(12, 65);
            this.pbxphoto.Name = "pbxphoto";
            this.pbxphoto.Size = new System.Drawing.Size(338, 248);
            this.pbxphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxphoto.TabIndex = 1;
            this.pbxphoto.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnufile
            // 
            this.mnufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuload,
            this.mnuexit});
            this.mnufile.Name = "mnufile";
            this.mnufile.Size = new System.Drawing.Size(37, 20);
            this.mnufile.Text = "&File";
            // 
            // mnuload
            // 
            this.mnuload.Name = "mnuload";
            this.mnuload.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuload.Size = new System.Drawing.Size(140, 22);
            this.mnuload.Text = "&Load";
            this.mnuload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // mnuexit
            // 
            this.mnuexit.Name = "mnuexit";
            this.mnuexit.Size = new System.Drawing.Size(140, 22);
            this.mnuexit.Text = "&Exit";
            this.mnuexit.Click += new System.EventHandler(this.mnuexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 325);
            this.Controls.Add(this.pbxphoto);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "phototool";
            ((System.ComponentModel.ISupportInitialize)(this.pbxphoto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.PictureBox pbxphoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnufile;
        private System.Windows.Forms.ToolStripMenuItem mnuload;
        private System.Windows.Forms.ToolStripMenuItem mnuexit;
    }
}

