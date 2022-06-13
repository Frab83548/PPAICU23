
namespace PPAICU23.Interfaces
{
    partial class ListadoTurnosRT
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgbDiaSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbFechaHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbFechaHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TurnosRTSelecionado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgbDiaSemana,
            this.dgbFechaHoraInicio,
            this.dgbFechaHoraFin});
            this.dataGridView1.Location = new System.Drawing.Point(117, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 173);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione un turno";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 336);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // dgbDiaSemana
            // 
            this.dgbDiaSemana.HeaderText = "DiaSemana";
            this.dgbDiaSemana.MinimumWidth = 6;
            this.dgbDiaSemana.Name = "dgbDiaSemana";
            this.dgbDiaSemana.Width = 125;
            // 
            // dgbFechaHoraInicio
            // 
            this.dgbFechaHoraInicio.HeaderText = "FechaHoraInicio";
            this.dgbFechaHoraInicio.MinimumWidth = 6;
            this.dgbFechaHoraInicio.Name = "dgbFechaHoraInicio";
            this.dgbFechaHoraInicio.Width = 125;
            // 
            // dgbFechaHoraFin
            // 
            this.dgbFechaHoraFin.HeaderText = "FechaHoraFin";
            this.dgbFechaHoraFin.MinimumWidth = 6;
            this.dgbFechaHoraFin.Name = "dgbFechaHoraFin";
            this.dgbFechaHoraFin.Width = 125;
            // 
            // ListadoTurnosRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ListadoTurnosRT";
            this.Text = "ListadoTurnosRT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbDiaSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbFechaHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbFechaHoraFin;
    }
}