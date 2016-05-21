namespace Comic_Store
{
    partial class Cart
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
            this.cartContents = new System.Windows.Forms.Label();
            this.backToStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cartContents
            // 
            this.cartContents.AutoSize = true;
            this.cartContents.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartContents.Location = new System.Drawing.Point(54, 43);
            this.cartContents.Name = "cartContents";
            this.cartContents.Size = new System.Drawing.Size(52, 19);
            this.cartContents.TabIndex = 0;
            this.cartContents.Text = "label1";
            // 
            // backToStock
            // 
            this.backToStock.Location = new System.Drawing.Point(436, 12);
            this.backToStock.Name = "backToStock";
            this.backToStock.Size = new System.Drawing.Size(75, 23);
            this.backToStock.TabIndex = 1;
            this.backToStock.Text = "Back";
            this.backToStock.UseVisualStyleBackColor = true;
            this.backToStock.Click += new System.EventHandler(this.backToStock_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(538, 330);
            this.Controls.Add(this.backToStock);
            this.Controls.Add(this.cartContents);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cartContents;
        private System.Windows.Forms.Button backToStock;
    }
}