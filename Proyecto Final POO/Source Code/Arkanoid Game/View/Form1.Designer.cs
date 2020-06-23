namespace Arkanoid_Game
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pbShip = new System.Windows.Forms.PictureBox();
            this.pbUniqueBall = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbHeart1 = new System.Windows.Forms.PictureBox();
            this.pbHeart2 = new System.Windows.Forms.PictureBox();
            this.pbHeart3 = new System.Windows.Forms.PictureBox();
            this.pbHeart4 = new System.Windows.Forms.PictureBox();
            this.pbHeart5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pbShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbUniqueBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbHeart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbHeart5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(5, 692);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bloques rotos: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseWaitCursor = true;
            // 
            // pbShip
            // 
            this.pbShip.BackColor = System.Drawing.Color.Transparent;
            this.pbShip.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pbShip.BackgroundImage")));
            this.pbShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbShip.Location = new System.Drawing.Point(492, 426);
            this.pbShip.Name = "pbShip";
            this.pbShip.Size = new System.Drawing.Size(114, 28);
            this.pbShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShip.TabIndex = 1;
            this.pbShip.TabStop = false;
            this.pbShip.UseWaitCursor = true;
            // 
            // pbUniqueBall
            // 
            this.pbUniqueBall.BackColor = System.Drawing.Color.Transparent;
            this.pbUniqueBall.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pbUniqueBall.BackgroundImage")));
            this.pbUniqueBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUniqueBall.Location = new System.Drawing.Point(369, 270);
            this.pbUniqueBall.Name = "pbUniqueBall";
            this.pbUniqueBall.Size = new System.Drawing.Size(41, 39);
            this.pbUniqueBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUniqueBall.TabIndex = 0;
            this.pbUniqueBall.TabStop = false;
            this.pbUniqueBall.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(386, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 67);
            this.label3.TabIndex = 4;
            this.label3.Text = "Press Enter twice";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseWaitCursor = true;
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(5, 692);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puntaje:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseWaitCursor = true;
            // 
            // pbHeart1
            // 
            this.pbHeart1.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pbUniqueBall.BackgroundImage")));
            this.pbHeart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHeart1.Location = new System.Drawing.Point(646, 426);
            this.pbHeart1.Name = "pbHeart1";
            this.pbHeart1.Size = new System.Drawing.Size(54, 47);
            this.pbHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeart1.TabIndex = 6;
            this.pbHeart1.TabStop = false;
            this.pbHeart1.UseWaitCursor = true;
            // 
            // pbHeart2
            // 
            this.pbHeart2.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart2.Image = ((System.Drawing.Image) (resources.GetObject("pbUniqueBall.BackgroundImage")));
            this.pbHeart2.Location = new System.Drawing.Point(723, 426);
            this.pbHeart2.Name = "pbHeart2";
            this.pbHeart2.Size = new System.Drawing.Size(54, 47);
            this.pbHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeart2.TabIndex = 6;
            this.pbHeart2.TabStop = false;
            this.pbHeart2.UseWaitCursor = true;
            // 
            // pbHeart3
            // 
            this.pbHeart3.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart3.Image = ((System.Drawing.Image) (resources.GetObject("pbUniqueBall.BackgroundImage")));
            this.pbHeart3.Location = new System.Drawing.Point(812, 426);
            this.pbHeart3.Name = "pbHeart3";
            this.pbHeart3.Size = new System.Drawing.Size(54, 47);
            this.pbHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeart3.TabIndex = 6;
            this.pbHeart3.TabStop = false;
            this.pbHeart3.UseWaitCursor = true;
            // 
            // pbHeart4
            // 
            this.pbHeart4.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart4.Image = ((System.Drawing.Image) (resources.GetObject("pbUniqueBall.BackgroundImage")));
            this.pbHeart4.Location = new System.Drawing.Point(873, 426);
            this.pbHeart4.Name = "pbHeart4";
            this.pbHeart4.Size = new System.Drawing.Size(54, 47);
            this.pbHeart4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeart4.TabIndex = 6;
            this.pbHeart4.TabStop = false;
            this.pbHeart4.UseWaitCursor = true;
            // 
            // pbHeart5
            // 
            this.pbHeart5.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart5.Image = ((System.Drawing.Image) (resources.GetObject("pbUniqueBall.BackgroundImage")));
            this.pbHeart5.Location = new System.Drawing.Point(400, 426);
            this.pbHeart5.Name = "pbHeart5";
            this.pbHeart5.Size = new System.Drawing.Size(54, 47);
            this.pbHeart5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeart5.TabIndex = 6;
            this.pbHeart5.TabStop = false;
            this.pbHeart5.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 537);
            this.Controls.Add(this.pbHeart5);
            this.Controls.Add(this.pbHeart4);
            this.Controls.Add(this.pbHeart3);
            this.Controls.Add(this.pbHeart2);
            this.Controls.Add(this.pbHeart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbShip);
            this.Controls.Add(this.pbUniqueBall);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize) (this.pbShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbUniqueBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbHeart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbHeart5)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbHeart1;
        private System.Windows.Forms.PictureBox pbHeart2;
        private System.Windows.Forms.PictureBox pbHeart3;
        private System.Windows.Forms.PictureBox pbHeart4;
        private System.Windows.Forms.PictureBox pbHeart5;
        private System.Windows.Forms.PictureBox pbShip;
        private System.Windows.Forms.Timer timer1;

        #endregion

        private System.Windows.Forms.PictureBox pbUniqueBall;
    }
}