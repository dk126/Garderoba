namespace Garderoba
{
    partial class Start
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btnRozpocznij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRozpocznij
            // 
            this.btnRozpocznij.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRozpocznij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRozpocznij.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRozpocznij.Location = new System.Drawing.Point(746, 278);
            this.btnRozpocznij.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRozpocznij.Name = "btnRozpocznij";
            this.btnRozpocznij.Size = new System.Drawing.Size(124, 33);
            this.btnRozpocznij.TabIndex = 0;
            this.btnRozpocznij.Text = "Rozpocznij";
            this.btnRozpocznij.UseVisualStyleBackColor = false;
            this.btnRozpocznij.Click += new System.EventHandler(this.btnRozpocznij_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.btnRozpocznij);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Witaj!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRozpocznij;
    }
}

