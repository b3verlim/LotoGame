namespace LotoGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnNext = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.flowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.Lime;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(157, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(221, 67);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Следующее число";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Red;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(42, 29);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(98, 59);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "жми кнопку";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.PeachPuff;
            this.txtStatus.Location = new System.Drawing.Point(34, 130);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(313, 375);
            this.txtStatus.TabIndex = 2;
            // 
            // flowCards
            // 
            this.flowCards.AutoScroll = true;
            this.flowCards.BackColor = System.Drawing.Color.PeachPuff;
            this.flowCards.Location = new System.Drawing.Point(447, 54);
            this.flowCards.Name = "flowCards";
            this.flowCards.Size = new System.Drawing.Size(813, 625);
            this.flowCards.TabIndex = 3;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1662, 726);
            this.Controls.Add(this.flowCards);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtStatus);
            this.Name = "GameForm";
            this.Text = "Игра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.FlowLayoutPanel flowCards;
    }
}