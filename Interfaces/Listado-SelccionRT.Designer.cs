
namespace PPAICU23
{
    partial class Listado_SelccionRT
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
            this.dbgListadoRT = new System.Windows.Forms.DataGridView();
            this.dgbCI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbnumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbmarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbmodelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmarRT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgListadoRT)).BeginInit();
            this.SuspendLayout();
            // 
            // dbgListadoRT
            // 
            this.dbgListadoRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgListadoRT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgbCI,
            this.dgbnombre,
            this.dgbnumero,
            this.dgbmarca,
            this.dgbmodelo,
            this.dgbEstado});
            this.dbgListadoRT.Location = new System.Drawing.Point(12, 87);
            this.dbgListadoRT.Name = "dbgListadoRT";
            this.dbgListadoRT.RowHeadersWidth = 51;
            this.dbgListadoRT.RowTemplate.Height = 24;
            this.dbgListadoRT.Size = new System.Drawing.Size(803, 239);
            this.dbgListadoRT.TabIndex = 0;
            this.dbgListadoRT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dbgListadoRT.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgListadoRT_RowEnter);
            // 
            // dgbCI
            // 
            this.dgbCI.HeaderText = "Centro de investigacion";
            this.dgbCI.MinimumWidth = 6;
            this.dgbCI.Name = "dgbCI";
            this.dgbCI.Width = 125;
            // 
            // dgbnombre
            // 
            this.dgbnombre.HeaderText = "Nombre RT";
            this.dgbnombre.MinimumWidth = 6;
            this.dgbnombre.Name = "dgbnombre";
            this.dgbnombre.Width = 125;
            // 
            // dgbnumero
            // 
            this.dgbnumero.HeaderText = "N de inventario";
            this.dgbnumero.MinimumWidth = 6;
            this.dgbnumero.Name = "dgbnumero";
            this.dgbnumero.Width = 125;
            // 
            // dgbmarca
            // 
            this.dgbmarca.HeaderText = "Marca";
            this.dgbmarca.MinimumWidth = 6;
            this.dgbmarca.Name = "dgbmarca";
            this.dgbmarca.Width = 125;
            // 
            // dgbmodelo
            // 
            this.dgbmodelo.HeaderText = "Modelo";
            this.dgbmodelo.MinimumWidth = 6;
            this.dgbmodelo.Name = "dgbmodelo";
            this.dgbmodelo.Width = 125;
            // 
            // dgbEstado
            // 
            this.dgbEstado.HeaderText = "Estado";
            this.dgbEstado.MinimumWidth = 6;
            this.dgbEstado.Name = "dgbEstado";
            this.dgbEstado.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de RT correspondientes al tipoRT seleccionado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 453);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione un RT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnConfirmarRT
            // 
            this.btnConfirmarRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarRT.Location = new System.Drawing.Point(718, 501);
            this.btnConfirmarRT.Name = "btnConfirmarRT";
            this.btnConfirmarRT.Size = new System.Drawing.Size(127, 35);
            this.btnConfirmarRT.TabIndex = 4;
            this.btnConfirmarRT.Text = "confirmar";
            this.btnConfirmarRT.UseVisualStyleBackColor = true;
            // 
            // Listado_SelccionRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 559);
            this.Controls.Add(this.btnConfirmarRT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbgListadoRT);
            this.Name = "Listado_SelccionRT";
            this.Text = "Listado_SelccionRT";
            ((System.ComponentModel.ISupportInitialize)(this.dbgListadoRT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgListadoRT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbCI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbnumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbmarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbmodelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbEstado;
        private System.Windows.Forms.Button btnConfirmarRT;
    }
}