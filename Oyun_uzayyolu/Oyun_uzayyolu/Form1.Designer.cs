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
            this.fire = new System.Windows.Forms.PictureBox();
            this.fire1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceShip
            // 
            this.SpaceShip.Image = ((System.Drawing.Image)(resources.GetObject("SpaceShip.Image")));
            this.SpaceShip.Location = new System.Drawing.Point(40, 109);
            this.SpaceShip.Name = "SpaceShip";
            this.SpaceShip.Size = new System.Drawing.Size(100, 75);
            this.SpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpaceShip.TabIndex = 0;
            this.SpaceShip.TabStop = false;
            // 
            // Bomb
            // 
            this.Bomb.Image = ((System.Drawing.Image)(resources.GetObject("Bomb.Image")));
            this.Bomb.Location = new System.Drawing.Point(12, 202);
            this.Bomb.Name = "Bomb";
            this.Bomb.Size = new System.Drawing.Size(30, 30);
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
            this.Bomb1.Size = new System.Drawing.Size(30, 30);
            this.Bomb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bomb1.TabIndex = 2;
            this.Bomb1.TabStop = false;
            // 
            // Bomb2
            // 
            this.Bomb2.Image = ((System.Drawing.Image)(resources.GetObject("Bomb2.Image")));
            this.Bomb2.Location = new System.Drawing.Point(12, 288);
            this.Bomb2.Name = "Bomb2";
            this.Bomb2.Size = new System.Drawing.Size(30, 30);
            this.Bomb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bomb2.TabIndex = 3;
            this.Bomb2.TabStop = false;
            // 
            // fire
            // 
            this.fire.Image = ((System.Drawing.Image)(resources.GetObject("fire.Image")));
            this.fire.Location = new System.Drawing.Point(12, 331);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(30, 29);
            this.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire.TabIndex = 4;
            this.fire.TabStop = false;
            // 
            // fire1
            // 
            this.fire1.Image = ((System.Drawing.Image)(resources.GetObject("fire1.Image")));
            this.fire1.Location = new System.Drawing.Point(12, 366);
            this.fire1.Name = "fire1";
            this.fire1.Size = new System.Drawing.Size(38, 39);
            this.fire1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire1.TabIndex = 5;
            this.fire1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 464);
            this.Controls.Add(this.fire1);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.Bomb2);
            this.Controls.Add(this.Bomb1);
            this.Controls.Add(this.Bomb);
            this.Controls.Add(this.SpaceShip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceShip;
        private System.Windows.Forms.PictureBox Bomb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Bomb1;
        private System.Windows.Forms.PictureBox Bomb2;
        private System.Windows.Forms.PictureBox fire;
        private System.Windows.Forms.PictureBox fire1;
        private System.Windows.Forms.Timer timer2;
    }
}

