
namespace CSharpTest2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Background = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.PictureBox();
            this.GameBall = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBall)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.GameBall);
            this.Background.Controls.Add(this.GamePanel);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(694, 418);
            this.Background.TabIndex = 0;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Red;
            this.GamePanel.Location = new System.Drawing.Point(258, 363);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(200, 15);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.TabStop = false;
            // 
            // GameBall
            // 
            this.GameBall.BackColor = System.Drawing.Color.Black;
            this.GameBall.Location = new System.Drawing.Point(492, 221);
            this.GameBall.Name = "GameBall";
            this.GameBall.Size = new System.Drawing.Size(25, 25);
            this.GameBall.TabIndex = 1;
            this.GameBall.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 418);
            this.Controls.Add(this.Background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.PictureBox GameBall;
        private System.Windows.Forms.PictureBox GamePanel;
        private System.Windows.Forms.Timer Timer;
    }
}

