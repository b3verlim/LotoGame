namespace LotoGame
{
    partial class PlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersForm));
            this.numPlayers = new System.Windows.Forms.NumericUpDown();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // numPlayers
            // 
            this.numPlayers.BackColor = System.Drawing.Color.PeachPuff;
            this.numPlayers.Location = new System.Drawing.Point(736, 172);
            this.numPlayers.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPlayers.Name = "numPlayers";
            this.numPlayers.Size = new System.Drawing.Size(154, 22);
            this.numPlayers.TabIndex = 0;
            this.numPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Lime;
            this.btnStartGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartGame.Location = new System.Drawing.Point(736, 242);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(154, 57);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "начать";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(733, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество игроков";
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1087, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.numPlayers);
            this.Name = "PlayersForm";
            this.Text = "PlayersForm";
            ((System.ComponentModel.ISupportInitialize)(this.numPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPlayers;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label label1;
    }
}