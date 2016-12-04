namespace Oyun_uzayyolu
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
            this.SpaceShip = new System.Windows.Forms.PictureBox();
            this.Bomb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Bomb1 = new System.Windows.Forms.PictureBox();
            this.Bomb2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb2)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceShip
            // 
            this.SpaceShip.Image = ((System.Drawing.Image)(resources.GetObject("SpaceShip.Image")));
            this.SpaceShip.Location = new System.Drawing.Point(40, 109);
            this.SpaceShip.Name = "SpaceShip";
            this.SpaceShip.Size = new System.Drawing.Size(99, 73);
            this.SpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpaceShip.TabIndex = 0;
            this.SpaceShip.TabStop = false;
            // 
            // Bomb
            // 
            this.Bomb.Image = ((System.Drawing.Image)(resources.GetObject("Bomb.Image")));
            this.Bomb.Location = new System.Drawing.Point(12, 202);
            this.Bomb.Name = "Bomb";
            this.Bomb.Size = new System.Drawing.Size(37, 37);
            this.Bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bomb.TabIndex = 1;
            this.Bomb.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Bomb1
            // 
            this.Bomb1.Image = ((System.Drawing.Image)(resources.GetObject("Bomb1.Image")));
            this.Bomb1.Location = new System.Drawing.Point(12, 245);
            this.Bomb1.Name = "Bomb1";
            this.Bomb1.Size = new System.Drawing.Size(37, 37);
            this.Bomb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bomb1.TabIndex = 2;
            this.Bomb1.TabStop = false;
            // 
            // Bomb2
            // 
            this.Bomb2.Image = ((System.Drawing.Image)(resources.GetObject("Bomb2.Image")));
            this.Bomb2.Location = new System.Drawing.Point(12, 288);
            this.Bomb2.Name = "Bomb2";
            this.Bomb2.Size = new System.Drawing.Size(37, 37);
            this.Bomb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bomb2.TabIndex = 3;
            this.Bomb2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 342);
            this.Controls.Add(this.Bomb2);
            this.Controls.Add(this.Bomb1);
            this.Controls.Add(this.Bomb);
            this.Controls.Add(this.SpaceShip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceShip;
        private System.Windows.Forms.PictureBox Bomb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Bomb1;
        private System.Windows.Forms.PictureBox Bomb2;
    }
}

