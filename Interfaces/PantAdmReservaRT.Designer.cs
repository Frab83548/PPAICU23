
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
            this.SuspendLayout();
            // 
            // LblTiposRT
            // 
            this.LblTiposRT.AutoSize = true;
            this.LblTiposRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiposRT.Location = new System.Drawing.Point(169, 42);
            this.LblTiposRT.Name = "LblTiposRT";
            this.LblTiposRT.Size = new System.Drawing.Size(253, 24);
            this.LblTiposRT.TabIndex = 0;
            this.LblTiposRT.Text = "Tipos de recursos tenlogicos";
            this.LblTiposRT.Click += new System.EventHandler(this.label1_Click);
            // 
            // CBtiposRT
            // 
            this.CBtiposRT.FormattingEnabled = true;
            this.CBtiposRT.Items.AddRange(new object[] {
            "Balanza de precision",
            "Microoscopio de medicion",
            "Lupa de calor para circuitos"});
            this.CBtiposRT.Location = new System.Drawing.Point(153, 85);
            this.CBtiposRT.Name = "CBtiposRT";
            this.CBtiposRT.Size = new System.Drawing.Size(286, 24);
            this.CBtiposRT.TabIndex = 1;
            this.CBtiposRT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PantAdmReservaRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBtiposRT);
            this.Controls.Add(this.LblTiposRT);
            this.Name = "PantAdmReservaRT";
            this.Text = "PantAdmReservaRT";
            this.Load += new System.EventHandler(this.pant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTiposRT;
        private System.Windows.Forms.ComboBox CBtiposRT;
    }
}