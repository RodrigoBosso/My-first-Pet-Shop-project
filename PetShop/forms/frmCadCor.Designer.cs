
namespace PetShop
{
    partial class frmCadCor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCor));
            this.txtNomeCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.grdDadosCor = new System.Windows.Forms.DataGridView();
            this.barMenutencao = new System.Windows.Forms.ToolStrip();
            this.barBtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barBtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barBtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barBtnFechar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosCor)).BeginInit();
            this.barMenutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeCor
            // 
            this.txtNomeCor.Location = new System.Drawing.Point(243, 63);
            this.txtNomeCor.Name = "txtNomeCor";
            this.txtNomeCor.Size = new System.Drawing.Size(178, 20);
            this.txtNomeCor.TabIndex = 17;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(243, 42);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(33, 19);
            this.lblCor.TabIndex = 16;
            this.lblCor.Text = "Cor";
            // 
            // grdDadosCor
            // 
            this.grdDadosCor.AllowUserToAddRows = false;
            this.grdDadosCor.AllowUserToDeleteRows = false;
            this.grdDadosCor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosCor.Location = new System.Drawing.Point(0, 42);
            this.grdDadosCor.Name = "grdDadosCor";
            this.grdDadosCor.ReadOnly = true;
            this.grdDadosCor.RowHeadersWidth = 51;
            this.grdDadosCor.RowTemplate.Height = 24;
            this.grdDadosCor.Size = new System.Drawing.Size(237, 314);
            this.grdDadosCor.TabIndex = 15;
            this.grdDadosCor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosCor_CellClick);
            // 
            // barMenutencao
            // 
            this.barMenutencao.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barMenutencao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barBtnNovo,
            this.barBtnEditar,
            this.barBtnExcluir,
            this.barBtnSalvar,
            this.barbtnCancelar,
            this.barBtnFechar});
            this.barMenutencao.Location = new System.Drawing.Point(0, 0);
            this.barMenutencao.Name = "barMenutencao";
            this.barMenutencao.Size = new System.Drawing.Size(426, 39);
            this.barMenutencao.TabIndex = 14;
            this.barMenutencao.Text = "toolStrip1";
            // 
            // barBtnNovo
            // 
            this.barBtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barBtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.Image")));
            this.barBtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barBtnNovo.Name = "barBtnNovo";
            this.barBtnNovo.Size = new System.Drawing.Size(36, 36);
            this.barBtnNovo.Text = "Novo";
            this.barBtnNovo.ToolTipText = "Nova Cor";
            this.barBtnNovo.Click += new System.EventHandler(this.barBtnNovo_Click);
            // 
            // barBtnEditar
            // 
            this.barBtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barBtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("barBtnEditar.Image")));
            this.barBtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barBtnEditar.Name = "barBtnEditar";
            this.barBtnEditar.Size = new System.Drawing.Size(36, 36);
            this.barBtnEditar.Text = "Edita";
            this.barBtnEditar.ToolTipText = "Edita Cor Selecionada";
            this.barBtnEditar.Click += new System.EventHandler(this.barBtnEditar_Click);
            // 
            // barBtnExcluir
            // 
            this.barBtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barBtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("barBtnExcluir.Image")));
            this.barBtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barBtnExcluir.Name = "barBtnExcluir";
            this.barBtnExcluir.Size = new System.Drawing.Size(36, 36);
            this.barBtnExcluir.Text = "Exclui";
            this.barBtnExcluir.ToolTipText = "Exclui a Cor Selecionada";
            this.barBtnExcluir.Click += new System.EventHandler(this.barBtnExcluir_Click);
            // 
            // barBtnSalvar
            // 
            this.barBtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barBtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.Image")));
            this.barBtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barBtnSalvar.Name = "barBtnSalvar";
            this.barBtnSalvar.Size = new System.Drawing.Size(36, 36);
            this.barBtnSalvar.Text = "Salvar";
            this.barBtnSalvar.ToolTipText = "Salva uma nova Cor";
            this.barBtnSalvar.Click += new System.EventHandler(this.barBtnSalvar_Click);
            // 
            // barbtnCancelar
            // 
            this.barbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("barbtnCancelar.Image")));
            this.barbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barbtnCancelar.Name = "barbtnCancelar";
            this.barbtnCancelar.Size = new System.Drawing.Size(36, 36);
            this.barbtnCancelar.Text = "Cancelar";
            this.barbtnCancelar.ToolTipText = "Cancela a operação de Inclusão ou Edição";
            this.barbtnCancelar.Click += new System.EventHandler(this.barbtnCancelar_Click);
            // 
            // barBtnFechar
            // 
            this.barBtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barBtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("barBtnFechar.Image")));
            this.barBtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barBtnFechar.Name = "barBtnFechar";
            this.barBtnFechar.Size = new System.Drawing.Size(36, 36);
            this.barBtnFechar.Text = "Fechar";
            this.barBtnFechar.ToolTipText = "Fecha o fomulário de Manutenção de Cor";
            this.barBtnFechar.Click += new System.EventHandler(this.barBtnFechar_Click);
            // 
            // frmCadCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 361);
            this.Controls.Add(this.txtNomeCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.grdDadosCor);
            this.Controls.Add(this.barMenutencao);
            this.Name = "frmCadCor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Cor";
            this.Load += new System.EventHandler(this.frmCadCor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosCor)).EndInit();
            this.barMenutencao.ResumeLayout(false);
            this.barMenutencao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCor;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.DataGridView grdDadosCor;
        private System.Windows.Forms.ToolStrip barMenutencao;
        private System.Windows.Forms.ToolStripButton barBtnNovo;
        private System.Windows.Forms.ToolStripButton barBtnEditar;
        private System.Windows.Forms.ToolStripButton barBtnExcluir;
        private System.Windows.Forms.ToolStripButton barBtnSalvar;
        private System.Windows.Forms.ToolStripButton barbtnCancelar;
        private System.Windows.Forms.ToolStripButton barBtnFechar;
    }
}