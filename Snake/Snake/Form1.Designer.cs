namespace Snake
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
            this.points = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.fulscr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.Location = new System.Drawing.Point(12, 9);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(66, 21);
            this.points.TabIndex = 0;
            this.points.Text = "Points:";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 125;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(89, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(18, 21);
            this.score.TabIndex = 1;
            this.score.Text = "0";
            // 
            // fulscr
            // 
            this.fulscr.AutoSize = true;
            this.fulscr.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fulscr.Location = new System.Drawing.Point(132, 9);
            this.fulscr.Name = "fulscr";
            this.fulscr.Size = new System.Drawing.Size(146, 21);
            this.fulscr.TabIndex = 2;
            this.fulscr.Text = "Better Fullscreen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.fulscr);
            this.Controls.Add(this.score);
            this.Controls.Add(this.points);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Snek";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label fulscr;
    }
}

