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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasBtnReportes = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(3, 3);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1062, 111);
            this.navegador1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.navegador1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConsultasBtnReportes, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 527);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.ConsultasBtnReportes.Location = new System.Drawing.Point(494, 442);
            this.ConsultasBtnReportes.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnReportes.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnReportes.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnReportes.Name = "ConsultasBtnReportes";
            this.ConsultasBtnReportes.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnReportes.TabIndex = 4;
            this.ConsultasBtnReportes.UseVisualStyleBackColor = false;
            this.ConsultasBtnReportes.Click += new System.EventHandler(this.ConsultasBtnReportes_Click_1);
            // 
            // FrmMantenimientoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 527);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMantenimientoPacientes";
            this.Text = "FrmMantenimientoPacientes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CapaVista_Consultas.Componentes.ClsBotonConsultas ConsultasBtnReportes;
    }
}