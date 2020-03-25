namespace LakoparkProjekt
{
    partial class StatForm
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
            this.lbStatisztika = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbStatisztika
            // 
            this.lbStatisztika.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbStatisztika.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbStatisztika.FormattingEnabled = true;
            this.lbStatisztika.ItemHeight = 23;
            this.lbStatisztika.Location = new System.Drawing.Point(44, 30);
            this.lbStatisztika.Margin = new System.Windows.Forms.Padding(0);
            this.lbStatisztika.Name = "lbStatisztika";
            this.lbStatisztika.Size = new System.Drawing.Size(549, 372);
            this.lbStatisztika.TabIndex = 0;
            // 
            // StatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 449);
            this.Controls.Add(this.lbStatisztika);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StatForm";
            this.Text = "Statisztika";
            this.Load += new System.EventHandler(this.StatForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStatisztika;
    }
}