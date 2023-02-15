
namespace PetShop
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.staPrincipal = new System.Windows.Forms.StatusStrip();
            this.barPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsbtnCadAnimal = new System.Windows.Forms.ToolStripButton();
            this.mnuPrincipal.SuspendLayout();
            this.barPrincipal.SuspendLayout();
            this.SuspendLayout();
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
            this.mnuPrincipal.TabIndex = 4;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPet,
            this.toolStripMenuItem1,
            this.mnuFechar});
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.mnuCadastro.Text = "Cadastro";
            // 
            // mnuPet
            // 
            this.mnuPet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnimal,
            this.mnuCor});
            this.mnuPet.Name = "mnuPet";
            this.mnuPet.Size = new System.Drawing.Size(109, 22);
            this.mnuPet.Text = "Pet";
            // 
            // mnuAnimal
            // 
            this.mnuAnimal.Name = "mnuAnimal";
            this.mnuAnimal.Size = new System.Drawing.Size(112, 22);
            this.mnuAnimal.Text = "Animal";
            this.mnuAnimal.Click += new System.EventHandler(this.mnuAnimal_Click);
            // 
            // mnuCor
            // 
            this.mnuCor.Name = "mnuCor";
            this.mnuCor.Size = new System.Drawing.Size(112, 22);
            this.mnuCor.Text = "Cor";
            this.mnuCor.Click += new System.EventHandler(this.mnuCor_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
            // 
            // mnuFechar
            // 
            this.mnuFechar.Name = "mnuFechar";
            this.mnuFechar.Size = new System.Drawing.Size(109, 22);
            this.mnuFechar.Text = "Fechar";
            this.mnuFechar.Click += new System.EventHandler(this.mnuFechar_Click);
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
            // barPrincipal
            // 
            this.barPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCadAnimal});
            this.barPrincipal.Location = new System.Drawing.Point(0, 24);
            this.barPrincipal.Name = "barPrincipal";
            this.barPrincipal.Size = new System.Drawing.Size(800, 39);
            this.barPrincipal.TabIndex = 7;
            this.barPrincipal.Text = "toolStrip1";
            // 
            // tsbtnCadAnimal
            // 
            this.tsbtnCadAnimal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCadAnimal.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCadAnimal.Image")));
            this.tsbtnCadAnimal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCadAnimal.Name = "tsbtnCadAnimal";
            this.tsbtnCadAnimal.Size = new System.Drawing.Size(36, 36);
            this.tsbtnCadAnimal.Text = "Cadastro Animal";
            this.tsbtnCadAnimal.Click += new System.EventHandler(this.tsbtnCadAnimal_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barPrincipal);
            this.Controls.Add(this.staPrincipal);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "PetShop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.barPrincipal.ResumeLayout(false);
            this.barPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuPet;
        private System.Windows.Forms.ToolStripMenuItem mnuAnimal;
        private System.Windows.Forms.ToolStripMenuItem mnuCor;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFechar;
        private System.Windows.Forms.StatusStrip staPrincipal;
        private System.Windows.Forms.ToolStrip barPrincipal;
        private System.Windows.Forms.ToolStripButton tsbtnCadAnimal;
    }
}

