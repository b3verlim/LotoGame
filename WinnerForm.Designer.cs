namespace LotoGame
{
    partial class WinnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinnerForm));
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinner.ForeColor = System.Drawing.Color.Red;
            this.lblWinner.Location = new System.Drawing.Point(76, 201);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(380, 53);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "label1";
            this.lblWinner.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Lime;
            this.btnRestart.Location = new System.Drawing.Point(303, 322);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(128, 49);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "заново";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(303, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1049, 597);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Name = "WinnerForm";
            this.Text = "WinnerForm";
            this.Load += new System.EventHandler(this.WinnerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnExit;
    }
}