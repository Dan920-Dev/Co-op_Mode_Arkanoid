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
            this.UniqueBall = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pbShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.UniqueBall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 692);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bloques rotos: 0";
            this.label1.UseWaitCursor = true;
            // 
            // pbShip
            // 
            this.pbShip.BackColor = System.Drawing.Color.Transparent;
            this.pbShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbShip.Image = global::Arkanoid_Game.Properties.Resources.NaveArkanoid;
            this.pbShip.Location = new System.Drawing.Point(492, 426);
            this.pbShip.Name = "pbShip";
            this.pbShip.Size = new System.Drawing.Size(114, 28);
            this.pbShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShip.TabIndex = 1;
            this.pbShip.TabStop = false;
            this.pbShip.UseWaitCursor = true;
            // 
            // UniqueBall
            // 
            this.UniqueBall.BackColor = System.Drawing.Color.Transparent;
            this.UniqueBall.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("UniqueBall.BackgroundImage")));
            this.UniqueBall.Location = new System.Drawing.Point(369, 270);
            this.UniqueBall.Name = "UniqueBall";
            this.UniqueBall.Size = new System.Drawing.Size(41, 39);
            this.UniqueBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UniqueBall.TabIndex = 0;
            this.UniqueBall.TabStop = false;
            this.UniqueBall.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(846, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puntaje: 0";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(386, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 67);
            this.label3.TabIndex = 4;
            this.label3.Text = "Press Enter twice";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(958, 537);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbShip);
            this.Controls.Add(this.UniqueBall);
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
            ((System.ComponentModel.ISupportInitialize) (this.UniqueBall)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbShip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox UniqueBall;

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}