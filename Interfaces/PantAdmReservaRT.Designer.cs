﻿
namespace PPAICU23.Interfaces
{
    partial class PantAdmReservaRT
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
            this.LblTiposRT = new System.Windows.Forms.Label();
            this.CBtiposRT = new System.Windows.Forms.ComboBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTiposRT
            // 
            this.LblTiposRT.AutoSize = true;
            this.LblTiposRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiposRT.Location = new System.Drawing.Point(127, 34);
            this.LblTiposRT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTiposRT.Name = "LblTiposRT";
            this.LblTiposRT.Size = new System.Drawing.Size(200, 18);
            this.LblTiposRT.TabIndex = 0;
            this.LblTiposRT.Text = "Tipos de recursos tenlogicos";
            // 
            // CBtiposRT
            // 
            this.CBtiposRT.FormattingEnabled = true;
            this.CBtiposRT.Location = new System.Drawing.Point(115, 69);
            this.CBtiposRT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBtiposRT.Name = "CBtiposRT";
            this.CBtiposRT.Size = new System.Drawing.Size(216, 21);
            this.CBtiposRT.TabIndex = 1;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(251, 109);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // PantAdmReservaRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.CBtiposRT);
            this.Controls.Add(this.LblTiposRT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantAdmReservaRT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantAdmReservaRT";
            this.Load += new System.EventHandler(this.pant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTiposRT;
        private System.Windows.Forms.ComboBox CBtiposRT;
        private System.Windows.Forms.Button btnContinuar;
    }
}