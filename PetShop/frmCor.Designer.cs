
namespace PetShop
{
    partial class frmCor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCor));
            this.staPrincipal = new System.Windows.Forms.StatusStrip();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBásico = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnidadeFederativa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroCIdade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadFuncao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadSetor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.barPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mnuPrincipal.SuspendLayout();
            this.barPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // staPrincipal
            // 
            this.staPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staPrincipal.Location = new System.Drawing.Point(0, 428);
            this.staPrincipal.Name = "staPrincipal";
            this.staPrincipal.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.staPrincipal.Size = new System.Drawing.Size(800, 22);
            this.staPrincipal.TabIndex = 6;
            this.staPrincipal.Text = "statusStrip1";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastro});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 7;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBásico,
            this.toolStripMenuItem1,
            this.mnuFechar});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastro.Text = "Cadastro";
            // 
            // mnuBásico
            // 
            this.mnuBásico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUnidadeFederativa,
            this.mnuCadastroCIdade,
            this.mnuCadUsuario,
            this.mnuCadFuncao,
            this.mnuCadSetor});
            this.mnuBásico.Name = "mnuBásico";
            this.mnuBásico.Size = new System.Drawing.Size(180, 22);
            this.mnuBásico.Text = "Básico";
            this.mnuBásico.Click += new System.EventHandler(this.mnuBásico_Click);
            // 
            // mnuUnidadeFederativa
            // 
            this.mnuUnidadeFederativa.Name = "mnuUnidadeFederativa";
            this.mnuUnidadeFederativa.Size = new System.Drawing.Size(180, 22);
            this.mnuUnidadeFederativa.Text = "Unidade Federativa";
            // 
            // mnuCadastroCIdade
            // 
            this.mnuCadastroCIdade.Name = "mnuCadastroCIdade";
            this.mnuCadastroCIdade.Size = new System.Drawing.Size(180, 22);
            this.mnuCadastroCIdade.Text = "Cidade";
            // 
            // mnuCadUsuario
            // 
            this.mnuCadUsuario.Name = "mnuCadUsuario";
            this.mnuCadUsuario.Size = new System.Drawing.Size(180, 22);
            this.mnuCadUsuario.Text = "Usuários";
            // 
            // mnuCadFuncao
            // 
            this.mnuCadFuncao.Name = "mnuCadFuncao";
            this.mnuCadFuncao.Size = new System.Drawing.Size(180, 22);
            this.mnuCadFuncao.Text = "Função";
            // 
            // mnuCadSetor
            // 
            this.mnuCadSetor.Name = "mnuCadSetor";
            this.mnuCadSetor.Size = new System.Drawing.Size(180, 22);
            this.mnuCadSetor.Text = "Setor";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFechar
            // 
            this.mnuFechar.Name = "mnuFechar";
            this.mnuFechar.Size = new System.Drawing.Size(180, 22);
            this.mnuFechar.Text = "Fechar";
            // 
            // barPrincipal
            // 
            this.barPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.barPrincipal.Location = new System.Drawing.Point(0, 24);
            this.barPrincipal.Name = "barPrincipal";
            this.barPrincipal.Size = new System.Drawing.Size(800, 39);
            this.barPrincipal.TabIndex = 8;
            this.barPrincipal.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // frmCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barPrincipal);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.staPrincipal);
            this.Name = "frmCor";
            this.Text = "frmCor";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.barPrincipal.ResumeLayout(false);
            this.barPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip staPrincipal;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuBásico;
        private System.Windows.Forms.ToolStripMenuItem mnuUnidadeFederativa;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroCIdade;
        private System.Windows.Forms.ToolStripMenuItem mnuCadUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuCadFuncao;
        private System.Windows.Forms.ToolStripMenuItem mnuCadSetor;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFechar;
        private System.Windows.Forms.ToolStrip barPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}