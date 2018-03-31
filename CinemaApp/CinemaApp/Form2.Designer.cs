namespace CinemaApp
{
    partial class Form2
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
            this.ChooseSeat = new System.Windows.Forms.Button();
            this.Secilenler = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseSeat
            // 
            this.ChooseSeat.Location = new System.Drawing.Point(57, 524);
            this.ChooseSeat.Name = "ChooseSeat";
            this.ChooseSeat.Size = new System.Drawing.Size(220, 31);
            this.ChooseSeat.TabIndex = 0;
            this.ChooseSeat.Text = "ChooseSeat";
            this.ChooseSeat.UseVisualStyleBackColor = true;
            this.ChooseSeat.Click += new System.EventHandler(this.ChooseSeat_Click);
            // 
            // Secilenler
            // 
            this.Secilenler.Location = new System.Drawing.Point(806, 524);
            this.Secilenler.Name = "Secilenler";
            this.Secilenler.Size = new System.Drawing.Size(339, 22);
            this.Secilenler.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 589);
            this.Controls.Add(this.Secilenler);
            this.Controls.Add(this.ChooseSeat);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseSeat;
        private System.Windows.Forms.TextBox Secilenler;
    }
}