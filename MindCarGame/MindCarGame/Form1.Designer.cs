namespace MindCarGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picOwl = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picOwl)).BeginInit();
            this.SuspendLayout();
            // 
            // picOwl
            // 
            this.picOwl.Image = ((System.Drawing.Image)(resources.GetObject("picOwl.Image")));
            this.picOwl.Location = new System.Drawing.Point(349, 591);
            this.picOwl.Name = "picOwl";
            this.picOwl.Size = new System.Drawing.Size(100, 118);
            this.picOwl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOwl.TabIndex = 3;
            this.picOwl.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 707);
            this.Controls.Add(this.picOwl);
            this.Name = "Form1";
            this.Text = "Mind Car Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOwl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picOwl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAction;
    }
}

