using System;

namespace Garderoba
{
    partial class Krok1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Krok1));
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSpecialDay = new System.Windows.Forms.RadioButton();
            this.radioButtonCasual = new System.Windows.Forms.RadioButton();
            this.radioButtonCold = new System.Windows.Forms.RadioButton();
            this.radioButtonWarm = new System.Windows.Forms.RadioButton();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.groupBoxKreacja = new System.Windows.Forms.GroupBox();
            this.groupBoxPogoda = new System.Windows.Forms.GroupBox();
            this.groupBoxKreacja.SuspendLayout();
            this.groupBoxPogoda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(354, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pytania rozpoznawcze...";
            // 
            // radioButtonSpecialDay
            // 
            this.radioButtonSpecialDay.AutoSize = true;
            this.radioButtonSpecialDay.Location = new System.Drawing.Point(30, 40);
            this.radioButtonSpecialDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSpecialDay.Name = "radioButtonSpecialDay";
            this.radioButtonSpecialDay.Size = new System.Drawing.Size(217, 26);
            this.radioButtonSpecialDay.TabIndex = 1;
            this.radioButtonSpecialDay.Text = "Na specjalną okazję";
            this.radioButtonSpecialDay.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasual
            // 
            this.radioButtonCasual.AutoSize = true;
            this.radioButtonCasual.Location = new System.Drawing.Point(30, 74);
            this.radioButtonCasual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCasual.Name = "radioButtonCasual";
            this.radioButtonCasual.Size = new System.Drawing.Size(136, 26);
            this.radioButtonCasual.TabIndex = 2;
            this.radioButtonCasual.Text = "Na codzień";
            this.radioButtonCasual.UseVisualStyleBackColor = true;
            // 
            // radioButtonCold
            // 
            this.radioButtonCold.AutoSize = true;
            this.radioButtonCold.Location = new System.Drawing.Point(39, 70);
            this.radioButtonCold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCold.Name = "radioButtonCold";
            this.radioButtonCold.Size = new System.Drawing.Size(159, 26);
            this.radioButtonCold.TabIndex = 1;
            this.radioButtonCold.Text = "Zimno (<15°C)";
            this.radioButtonCold.UseVisualStyleBackColor = true;
            // 
            // radioButtonWarm
            // 
            this.radioButtonWarm.AutoSize = true;
            this.radioButtonWarm.Location = new System.Drawing.Point(39, 36);
            this.radioButtonWarm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonWarm.Name = "radioButtonWarm";
            this.radioButtonWarm.Size = new System.Drawing.Size(166, 26);
            this.radioButtonWarm.TabIndex = 0;
            this.radioButtonWarm.Text = "Ciepło (>15°C)";
            this.radioButtonWarm.UseVisualStyleBackColor = true;
            // 
            // buttonContinue
            // 
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContinue.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonContinue.Location = new System.Drawing.Point(406, 327);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(171, 37);
            this.buttonContinue.TabIndex = 4;
            this.buttonContinue.Text = "Przejdź dalej";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // groupBoxKreacja
            // 
            this.groupBoxKreacja.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxKreacja.Controls.Add(this.radioButtonCasual);
            this.groupBoxKreacja.Controls.Add(this.radioButtonSpecialDay);
            this.groupBoxKreacja.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxKreacja.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxKreacja.Location = new System.Drawing.Point(187, 143);
            this.groupBoxKreacja.Name = "groupBoxKreacja";
            this.groupBoxKreacja.Size = new System.Drawing.Size(329, 130);
            this.groupBoxKreacja.TabIndex = 3;
            this.groupBoxKreacja.TabStop = false;
            this.groupBoxKreacja.Text = "Jakiej kreacji potrzebujesz?";
            // 
            // groupBoxPogoda
            // 
            this.groupBoxPogoda.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPogoda.Controls.Add(this.radioButtonWarm);
            this.groupBoxPogoda.Controls.Add(this.radioButtonCold);
            this.groupBoxPogoda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxPogoda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxPogoda.Location = new System.Drawing.Point(544, 143);
            this.groupBoxPogoda.Name = "groupBoxPogoda";
            this.groupBoxPogoda.Size = new System.Drawing.Size(270, 130);
            this.groupBoxPogoda.TabIndex = 5;
            this.groupBoxPogoda.TabStop = false;
            this.groupBoxPogoda.Text = "Jaka jest dziś pogoda?";
            // 
            // Krok1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.groupBoxPogoda);
            this.Controls.Add(this.groupBoxKreacja);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Krok1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krok pierwszy...";
            this.groupBoxKreacja.ResumeLayout(false);
            this.groupBoxKreacja.PerformLayout();
            this.groupBoxPogoda.ResumeLayout(false);
            this.groupBoxPogoda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSpecialDay;
        private System.Windows.Forms.RadioButton radioButtonCasual;
        private System.Windows.Forms.RadioButton radioButtonCold;
        private System.Windows.Forms.RadioButton radioButtonWarm;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.GroupBox groupBoxKreacja;
        private System.Windows.Forms.GroupBox groupBoxPogoda;
    }

}