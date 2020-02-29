namespace SistemaOdontologico
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuAgenda,
            this.menuAjuda,
            this.MSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadDentista,
            this.menuCadPaciente,
            this.menuCadConsulta});
            this.menuCadastro.Image = ((System.Drawing.Image)(resources.GetObject("menuCadastro.Image")));
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(82, 20);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuCadDentista
            // 
            this.menuCadDentista.Name = "menuCadDentista";
            this.menuCadDentista.Size = new System.Drawing.Size(180, 22);
            this.menuCadDentista.Text = "Dentista";
            this.menuCadDentista.Click += new System.EventHandler(this.menuCadDentista_Click);
            // 
            // menuCadPaciente
            // 
            this.menuCadPaciente.Name = "menuCadPaciente";
            this.menuCadPaciente.Size = new System.Drawing.Size(180, 22);
            this.menuCadPaciente.Text = "Paciente";
            this.menuCadPaciente.Click += new System.EventHandler(this.menuCadPaciente_Click);
            // 
            // menuCadConsulta
            // 
            this.menuCadConsulta.Name = "menuCadConsulta";
            this.menuCadConsulta.Size = new System.Drawing.Size(180, 22);
            this.menuCadConsulta.Text = "Consulta";
            this.menuCadConsulta.Click += new System.EventHandler(this.menuCadConsulta_Click);
            // 
            // menuAgenda
            // 
            this.menuAgenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgDentista,
            this.menuAgPaciente,
            this.menuAgConsulta});
            this.menuAgenda.Image = ((System.Drawing.Image)(resources.GetObject("menuAgenda.Image")));
            this.menuAgenda.Name = "menuAgenda";
            this.menuAgenda.Size = new System.Drawing.Size(81, 20);
            this.menuAgenda.Text = "Agendas";
            // 
            // menuAgDentista
            // 
            this.menuAgDentista.Name = "menuAgDentista";
            this.menuAgDentista.Size = new System.Drawing.Size(180, 22);
            this.menuAgDentista.Text = "Dentistas";
            this.menuAgDentista.Click += new System.EventHandler(this.menuAgDentista_Click);
            // 
            // menuAgPaciente
            // 
            this.menuAgPaciente.Name = "menuAgPaciente";
            this.menuAgPaciente.Size = new System.Drawing.Size(180, 22);
            this.menuAgPaciente.Text = "Paciente";
            // 
            // menuAgConsulta
            // 
            this.menuAgConsulta.Name = "menuAgConsulta";
            this.menuAgConsulta.Size = new System.Drawing.Size(180, 22);
            this.menuAgConsulta.Text = "Consulta";
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSuporte});
            this.menuAjuda.Image = ((System.Drawing.Image)(resources.GetObject("menuAjuda.Image")));
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(66, 20);
            this.menuAjuda.Text = "Ajuda";
            // 
            // menuSuporte
            // 
            this.menuSuporte.Name = "menuSuporte";
            this.menuSuporte.Size = new System.Drawing.Size(115, 22);
            this.menuSuporte.Text = "Suporte";
            // 
            // MSair
            // 
            this.MSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSair});
            this.MSair.Image = ((System.Drawing.Image)(resources.GetObject("MSair.Image")));
            this.MSair.Name = "MSair";
            this.MSair.Size = new System.Drawing.Size(54, 20);
            this.MSair.Text = "Sair";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(93, 22);
            this.menuSair.Text = "Sair";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema Odonto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuAgenda;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem MSair;
        private System.Windows.Forms.ToolStripMenuItem menuCadDentista;
        private System.Windows.Forms.ToolStripMenuItem menuCadPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuCadConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuAgDentista;
        private System.Windows.Forms.ToolStripMenuItem menuAgPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuAgConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuSuporte;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
    }
}

