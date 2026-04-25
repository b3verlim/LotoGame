namespace LotoGame
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Yellow;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(833, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 116);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ЛОТО";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Location = new System.Drawing.Point(831, 177);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 57);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(831, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1186, 668);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
    }
}