namespace flappybirdwinform
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
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::flappybirdwinform.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(12, 212);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(65, 55);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::flappybirdwinform.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(506, -1);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(98, 199);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 1;
            this.pipetop.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::flappybirdwinform.Properties.Resources.pipe;
            this.pipebottom.Location = new System.Drawing.Point(296, 357);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(101, 191);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 2;
            this.pipebottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::flappybirdwinform.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(1, 544);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(658, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(-6, -1);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(126, 37);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(632, 592);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.FlappyBird);
            this.Name = "Form1";
            this.Text = "flappyBirdGame";
            this.Load += new System.EventHandler(this.gameTimerEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer gameTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

