namespace dz_7
{
    partial class StartMenu
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
            this.TextStart = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextStart
            // 
            this.TextStart.AutoSize = true;
            this.TextStart.Location = new System.Drawing.Point(12, 9);
            this.TextStart.Name = "TextStart";
            this.TextStart.Size = new System.Drawing.Size(465, 20);
            this.TextStart.TabIndex = 0;
            this.TextStart.Text = "Правила:  Набери число за минимальное количество ходов";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(52, 52);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(370, 62);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "ИГРАТЬ!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.OnStartClick);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 144);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.TextStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.Load += new System.EventHandler(this.OnStartLoad);
            this.Click += new System.EventHandler(this.OnStartMenuClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextStart;
        private System.Windows.Forms.Button buttonStart;
    }
}