﻿namespace Arkanoid_Game
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pbShip = new System.Windows.Forms.PictureBox();
            this.UniqueBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniqueBall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.UseWaitCursor = true;
            // 
            // pbShip
            // 
            this.pbShip.BackColor = System.Drawing.Color.Transparent;
            this.pbShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbShip.Image = global::Arkanoid_Game.Properties.Resources.NaveArkanoid;
            this.pbShip.Location = new System.Drawing.Point(422, 369);
            this.pbShip.Name = "pbShip";
            this.pbShip.Size = new System.Drawing.Size(98, 24);
            this.pbShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShip.TabIndex = 1;
            this.pbShip.TabStop = false;
            this.pbShip.UseWaitCursor = true;
            // 
            // UniqueBall
            // 
            this.UniqueBall.BackColor = System.Drawing.Color.Transparent;
            this.UniqueBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UniqueBall.BackgroundImage")));
            this.UniqueBall.Location = new System.Drawing.Point(316, 234);
            this.UniqueBall.Name = "UniqueBall";
            this.UniqueBall.Size = new System.Drawing.Size(35, 34);
            this.UniqueBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UniqueBall.TabIndex = 0;
            this.UniqueBall.TabStop = false;
            this.UniqueBall.UseWaitCursor = true;
            this.UniqueBall.Click += new System.EventHandler(this.UniqueBall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(821, 465);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniqueBall)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbShip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox UniqueBall;

        #endregion
    }
}