namespace snake
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
            this.border4 = new System.Windows.Forms.Label();
            this.border2 = new System.Windows.Forms.Label();
            this.border3 = new System.Windows.Forms.Label();
            this.border1 = new System.Windows.Forms.Label();
            this.snake = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.snake)).BeginInit();
            this.SuspendLayout();
            // 
            // border4
            // 
            this.border4.BackColor = System.Drawing.Color.OrangeRed;
            this.border4.Location = new System.Drawing.Point(-1, -2);
            this.border4.Name = "border4";
            this.border4.Size = new System.Drawing.Size(10, 422);
            this.border4.TabIndex = 1;
            // 
            // border2
            // 
            this.border2.BackColor = System.Drawing.Color.OrangeRed;
            this.border2.Location = new System.Drawing.Point(804, -2);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(10, 422);
            this.border2.TabIndex = 2;
            // 
            // border3
            // 
            this.border3.BackColor = System.Drawing.Color.OrangeRed;
            this.border3.Location = new System.Drawing.Point(2, -2);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(812, 10);
            this.border3.TabIndex = 3;
            // 
            // border1
            // 
            this.border1.BackColor = System.Drawing.Color.OrangeRed;
            this.border1.Location = new System.Drawing.Point(2, 410);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(812, 10);
            this.border1.TabIndex = 4;
            // 
            // snake
            // 
            this.snake.Image = ((System.Drawing.Image)(resources.GetObject("snake.Image")));
            this.snake.Location = new System.Drawing.Point(339, 185);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(28, 30);
            this.snake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.snake.TabIndex = 5;
            this.snake.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 419);
            this.Controls.Add(this.snake);
            this.Controls.Add(this.border1);
            this.Controls.Add(this.border3);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.border4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.snake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label border4;
        private System.Windows.Forms.Label border2;
        private System.Windows.Forms.Label border3;
        private System.Windows.Forms.Label border1;
        private System.Windows.Forms.PictureBox snake;
        private System.Windows.Forms.Timer timer1;
    }
}

