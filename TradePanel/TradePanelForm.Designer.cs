using System;

namespace TradePanel
{
    partial class TradePanelForm
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [STAThread]
        private void InitializeComponent()
        {
            this.AskLabel = new System.Windows.Forms.Label();
            this.ButtonSell = new System.Windows.Forms.Button();
            this.ButtonBuy = new System.Windows.Forms.Button();
            this.BidLabel = new System.Windows.Forms.Label();
            this.CurrentVolume = new System.Windows.Forms.TextBox();
            this.IncrementVol = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // AskLabel
            // 
            this.AskLabel.AutoSize = true;
            this.AskLabel.BackColor = System.Drawing.Color.IndianRed;
            this.AskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AskLabel.Location = new System.Drawing.Point(12, 44);
            this.AskLabel.Name = "AskLabel";
            this.AskLabel.Size = new System.Drawing.Size(112, 31);
            this.AskLabel.TabIndex = 0;
            this.AskLabel.Text = "1.14068";
            // 
            // ButtonSell
            // 
            this.ButtonSell.Location = new System.Drawing.Point(172, 12);
            this.ButtonSell.Name = "ButtonSell";
            this.ButtonSell.Size = new System.Drawing.Size(68, 29);
            this.ButtonSell.TabIndex = 3;
            this.ButtonSell.Text = "Sell";
            this.ButtonSell.UseVisualStyleBackColor = true;
            // 
            // ButtonBuy
            // 
            this.ButtonBuy.Location = new System.Drawing.Point(12, 12);
            this.ButtonBuy.Name = "ButtonBuy";
            this.ButtonBuy.Size = new System.Drawing.Size(68, 29);
            this.ButtonBuy.TabIndex = 4;
            this.ButtonBuy.Text = "Buy";
            this.ButtonBuy.UseVisualStyleBackColor = true;
            // 
            // BidLabel
            // 
            this.BidLabel.AutoSize = true;
            this.BidLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BidLabel.Location = new System.Drawing.Point(129, 44);
            this.BidLabel.Name = "BidLabel";
            this.BidLabel.Size = new System.Drawing.Size(112, 31);
            this.BidLabel.TabIndex = 5;
            this.BidLabel.Text = "1.14068";
            // 
            // CurrentVolume
            // 
            this.CurrentVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentVolume.Location = new System.Drawing.Point(82, 12);
            this.CurrentVolume.Name = "CurrentVolume";
            this.CurrentVolume.Size = new System.Drawing.Size(70, 29);
            this.CurrentVolume.TabIndex = 7;
            this.CurrentVolume.Text = "-.--";
            this.CurrentVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IncrementVol
            // 
            this.IncrementVol.AllowDrop = true;
            this.IncrementVol.Location = new System.Drawing.Point(151, 11);
            this.IncrementVol.Name = "IncrementVol";
            this.IncrementVol.Size = new System.Drawing.Size(18, 29);
            this.IncrementVol.TabIndex = 9;
            // 
            // TradePanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(256, 91);
            this.Controls.Add(this.IncrementVol);
            this.Controls.Add(this.CurrentVolume);
            this.Controls.Add(this.BidLabel);
            this.Controls.Add(this.ButtonBuy);
            this.Controls.Add(this.ButtonSell);
            this.Controls.Add(this.AskLabel);
            this.MaximizeBox = false;
            this.Name = "TradePanelForm";
            this.Text = "Trade Panel";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.Label AskLabel;
        private System.Windows.Forms.Button ButtonSell;
        private System.Windows.Forms.Button ButtonBuy;
        private System.Windows.Forms.Label BidLabel;
        private System.Windows.Forms.TextBox CurrentVolume;
        private System.Windows.Forms.VScrollBar IncrementVol;
    }
}