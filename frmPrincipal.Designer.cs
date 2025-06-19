namespace pryAriza_IEFI
{
    partial class frmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.stsLogueo = new System.Windows.Forms.StatusStrip();
            this.stsUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.stsLogueo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAREAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAuditoria);
            this.groupBox2.Controls.Add(this.btnUsuarios);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADMINISTRACION";
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Location = new System.Drawing.Point(6, 65);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Size = new System.Drawing.Size(218, 28);
            this.btnAuditoria.TabIndex = 1;
            this.btnAuditoria.Text = "auditoria";
            this.btnAuditoria.UseVisualStyleBackColor = true;
            this.btnAuditoria.Click += new System.EventHandler(this.btnAuditoria_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(6, 31);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(218, 28);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // stsLogueo
            // 
            this.stsLogueo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsUsuario,
            this.stsFecha});
            this.stsLogueo.Location = new System.Drawing.Point(0, 361);
            this.stsLogueo.Name = "stsLogueo";
            this.stsLogueo.Size = new System.Drawing.Size(469, 22);
            this.stsLogueo.TabIndex = 2;
            this.stsLogueo.Text = "statusStrip1";
            // 
            // stsUsuario
            // 
            this.stsUsuario.Name = "stsUsuario";
            this.stsUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // stsFecha
            // 
            this.stsFecha.Name = "stsFecha";
            this.stsFecha.Size = new System.Drawing.Size(0, 17);
            this.stsFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(233, 312);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(218, 28);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 383);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.stsLogueo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox2.ResumeLayout(false);
            this.stsLogueo.ResumeLayout(false);
            this.stsLogueo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.StatusStrip stsLogueo;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.ToolStripStatusLabel stsUsuario;
        private System.Windows.Forms.ToolStripStatusLabel stsFecha;
    }
}