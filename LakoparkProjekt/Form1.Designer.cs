namespace LakoparkProjekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictireBoxNev = new System.Windows.Forms.PictureBox();
            this.panelLakoPark = new System.Windows.Forms.Panel();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonStatisztika = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictireBoxNev)).BeginInit();
            this.SuspendLayout();
            // 
            // pictireBoxNev
            // 
            this.pictireBoxNev.BackColor = System.Drawing.Color.Transparent;
            this.pictireBoxNev.Location = new System.Drawing.Point(12, 12);
            this.pictireBoxNev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictireBoxNev.Name = "pictireBoxNev";
            this.pictireBoxNev.Size = new System.Drawing.Size(120, 160);
            this.pictireBoxNev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictireBoxNev.TabIndex = 0;
            this.pictireBoxNev.TabStop = false;
            // 
            // panelLakoPark
            // 
            this.panelLakoPark.Location = new System.Drawing.Point(151, 12);
            this.panelLakoPark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLakoPark.Name = "panelLakoPark";
            this.panelLakoPark.Size = new System.Drawing.Size(780, 390);
            this.panelLakoPark.TabIndex = 1;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeft.Image")));
            this.buttonLeft.Location = new System.Drawing.Point(433, 411);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(128, 70);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Visible = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonRight.Image")));
            this.buttonRight.Location = new System.Drawing.Point(567, 411);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(129, 70);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Visible = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonStatisztika
            // 
            this.buttonStatisztika.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonStatisztika.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStatisztika.Location = new System.Drawing.Point(12, 426);
            this.buttonStatisztika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStatisztika.Name = "buttonStatisztika";
            this.buttonStatisztika.Size = new System.Drawing.Size(128, 38);
            this.buttonStatisztika.TabIndex = 4;
            this.buttonStatisztika.Text = "Statisztika";
            this.buttonStatisztika.UseVisualStyleBackColor = false;
            this.buttonStatisztika.Click += new System.EventHandler(this.buttonStatisztika_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonMentes.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMentes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonMentes.Location = new System.Drawing.Point(151, 426);
            this.buttonMentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(128, 38);
            this.buttonMentes.TabIndex = 5;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = false;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 486);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonStatisztika);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.panelLakoPark);
            this.Controls.Add(this.pictireBoxNev);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "lakópark";
            this.Load += new System.EventHandler(this.Lakoparkok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictireBoxNev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictireBoxNev;
        private System.Windows.Forms.Panel panelLakoPark;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonStatisztika;
        private System.Windows.Forms.Button buttonMentes;
    }
}

