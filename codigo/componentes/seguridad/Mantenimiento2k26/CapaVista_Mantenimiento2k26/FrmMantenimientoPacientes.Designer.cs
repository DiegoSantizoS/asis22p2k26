namespace CapaVista_Mantenimiento2k26
{
    partial class FrmMantenimientoPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoPacientes));
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.ConsultasBtnReportes = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.clsEtiquetaConsultas1 = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(-11, 23);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1438, 111);
            this.navegador1.TabIndex = 0;
            // 
            // ConsultasBtnReportes
            // 
            this.ConsultasBtnReportes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnReportes.BackgroundImage")));
            this.ConsultasBtnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnReportes.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnReportes.Location = new System.Drawing.Point(450, 219);
            this.ConsultasBtnReportes.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnReportes.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnReportes.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnReportes.Name = "ConsultasBtnReportes";
            this.ConsultasBtnReportes.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnReportes.TabIndex = 2;
            this.ConsultasBtnReportes.UseVisualStyleBackColor = false;
            this.ConsultasBtnReportes.Click += new System.EventHandler(this.ConsultasBtnReportes_Click);
            // 
            // clsEtiquetaConsultas1
            // 
            this.clsEtiquetaConsultas1.AutoSize = true;
            this.clsEtiquetaConsultas1.BackColor = System.Drawing.Color.Transparent;
            this.clsEtiquetaConsultas1.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.clsEtiquetaConsultas1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.clsEtiquetaConsultas1.Location = new System.Drawing.Point(330, 248);
            this.clsEtiquetaConsultas1.Margin = new System.Windows.Forms.Padding(3);
            this.clsEtiquetaConsultas1.Name = "clsEtiquetaConsultas1";
            this.clsEtiquetaConsultas1.Size = new System.Drawing.Size(108, 19);
            this.clsEtiquetaConsultas1.TabIndex = 3;
            this.clsEtiquetaConsultas1.Text = "REPORTES →";
            this.clsEtiquetaConsultas1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMantenimientoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.clsEtiquetaConsultas1);
            this.Controls.Add(this.ConsultasBtnReportes);
            this.Controls.Add(this.navegador1);
            this.Name = "FrmMantenimientoPacientes";
            this.Text = "FrmMantenimientoPacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private CapaVista_Consultas.Componentes.ClsBotonConsultas ConsultasBtnReportes;
        private CapaVista_Consultas.Componentes.ClsEtiquetaConsultas clsEtiquetaConsultas1;
    }
}