
namespace PetShop
{
    partial class frmCadAnimal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAnimal));
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.mskDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblFotoAnimal = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.txtTemperamento = new System.Windows.Forms.TextBox();
            this.lblTemperamento = new System.Windows.Forms.Label();
            this.cmbAdotado = new System.Windows.Forms.ComboBox();
            this.lblAdotado = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.picbxFotoAnimal = new System.Windows.Forms.PictureBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grdDadosAnimal = new System.Windows.Forms.DataGridView();
            this.barMenutencao = new System.Windows.Forms.ToolStrip();
            this.barBtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barBtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barBtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barBtnFechar = new System.Windows.Forms.ToolStripButton();
            this.cmbCor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRaca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTamanho = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCadCor = new System.Windows.Forms.Button();
            this.btnCadRaca = new System.Windows.Forms.Button();
            this.btnCadEspecie = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFotoAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosAnimal)).BeginInit();
            this.barMenutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.cmbSexo.Location = new System.Drawing.Point(587, 155);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(141, 24);
            this.cmbSexo.TabIndex = 72;
            // 
            // mskDataCadastro
            // 
            this.mskDataCadastro.Location = new System.Drawing.Point(243, 298);
            this.mskDataCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.mskDataCadastro.Mask = "00/00/0000";
            this.mskDataCadastro.Name = "mskDataCadastro";
            this.mskDataCadastro.Size = new System.Drawing.Size(141, 22);
            this.mskDataCadastro.TabIndex = 71;
            this.mskDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.Location = new System.Drawing.Point(240, 273);
            this.lblDataCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(98, 19);
            this.lblDataCadastro.TabIndex = 70;
            this.lblDataCadastro.Text = "Data Cadastro";
            // 
            // lblFotoAnimal
            // 
            this.lblFotoAnimal.AutoSize = true;
            this.lblFotoAnimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoAnimal.Location = new System.Drawing.Point(791, 54);
            this.lblFotoAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFotoAnimal.Name = "lblFotoAnimal";
            this.lblFotoAnimal.Size = new System.Drawing.Size(83, 19);
            this.lblFotoAnimal.TabIndex = 69;
            this.lblFotoAnimal.Text = "Foto Animal";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(407, 364);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(532, 57);
            this.txtObservacao.TabIndex = 68;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(401, 337);
            this.lblObservacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(83, 19);
            this.lblObservacao.TabIndex = 67;
            this.lblObservacao.Text = "Observação";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(645, 298);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(83, 22);
            this.txtPeso.TabIndex = 66;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(645, 273);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 19);
            this.lblPeso.TabIndex = 65;
            this.lblPeso.Text = "Peso";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(240, 337);
            this.lblTamanho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(64, 19);
            this.lblTamanho.TabIndex = 64;
            this.lblTamanho.Text = "Tamanho";
            // 
            // txtTemperamento
            // 
            this.txtTemperamento.Location = new System.Drawing.Point(501, 298);
            this.txtTemperamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTemperamento.Name = "txtTemperamento";
            this.txtTemperamento.Size = new System.Drawing.Size(125, 22);
            this.txtTemperamento.TabIndex = 62;
            // 
            // lblTemperamento
            // 
            this.lblTemperamento.AutoSize = true;
            this.lblTemperamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperamento.Location = new System.Drawing.Point(496, 273);
            this.lblTemperamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperamento.Name = "lblTemperamento";
            this.lblTemperamento.Size = new System.Drawing.Size(99, 19);
            this.lblTemperamento.TabIndex = 61;
            this.lblTemperamento.Text = "Temperamento";
            // 
            // cmbAdotado
            // 
            this.cmbAdotado.FormattingEnabled = true;
            this.cmbAdotado.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmbAdotado.Location = new System.Drawing.Point(407, 297);
            this.cmbAdotado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAdotado.Name = "cmbAdotado";
            this.cmbAdotado.Size = new System.Drawing.Size(80, 24);
            this.cmbAdotado.TabIndex = 60;
            // 
            // lblAdotado
            // 
            this.lblAdotado.AutoSize = true;
            this.lblAdotado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdotado.Location = new System.Drawing.Point(404, 273);
            this.lblAdotado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdotado.Name = "lblAdotado";
            this.lblAdotado.Size = new System.Drawing.Size(63, 19);
            this.lblAdotado.TabIndex = 59;
            this.lblAdotado.Text = "Adotado";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(755, 298);
            this.btnCarregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(185, 37);
            this.btnCarregar.TabIndex = 58;
            this.btnCarregar.Text = "Carregar Imagem";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(584, 128);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 19);
            this.lblSexo.TabIndex = 57;
            this.lblSexo.Text = "Sexo";
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(583, 229);
            this.mskDataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(143, 22);
            this.mskDataNascimento.TabIndex = 56;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(577, 202);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(114, 19);
            this.lblDataNascimento.TabIndex = 55;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // picbxFotoAnimal
            // 
            this.picbxFotoAnimal.Location = new System.Drawing.Point(755, 81);
            this.picbxFotoAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.picbxFotoAnimal.Name = "picbxFotoAnimal";
            this.picbxFotoAnimal.Size = new System.Drawing.Size(185, 209);
            this.picbxFotoAnimal.TabIndex = 54;
            this.picbxFotoAnimal.TabStop = false;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(243, 81);
            this.txtNomeAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(485, 22);
            this.txtNomeAnimal.TabIndex = 53;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(237, 54);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 19);
            this.lblNome.TabIndex = 52;
            this.lblNome.Text = "Nome";
            // 
            // grdDadosAnimal
            // 
            this.grdDadosAnimal.AllowUserToAddRows = false;
            this.grdDadosAnimal.AllowUserToDeleteRows = false;
            this.grdDadosAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDadosAnimal.Location = new System.Drawing.Point(5, 52);
            this.grdDadosAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.grdDadosAnimal.Name = "grdDadosAnimal";
            this.grdDadosAnimal.ReadOnly = true;
            this.grdDadosAnimal.RowHeadersWidth = 51;
            this.grdDadosAnimal.RowTemplate.Height = 24;
            this.grdDadosAnimal.Size = new System.Drawing.Size(229, 370);
            this.grdDadosAnimal.TabIndex = 51;
            this.grdDadosAnimal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDadosAnimal_CellClick);
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
            this.barMenutencao.Size = new System.Drawing.Size(952, 39);
            this.barMenutencao.TabIndex = 50;
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
            this.barBtnNovo.ToolTipText = "Novo animal";
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
            this.barBtnEditar.ToolTipText = "Edita Animal Selecionado";
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
            this.barBtnExcluir.ToolTipText = "Exclui Animal Selecionada";
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
            this.barBtnSalvar.ToolTipText = "Salva um novo animal";
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
            this.barBtnFechar.ToolTipText = "Fecha o fomulário de Manutenção de Animal";
            this.barBtnFechar.Click += new System.EventHandler(this.barBtnFechar_Click);
            // 
            // cmbCor
            // 
            this.cmbCor.FormattingEnabled = true;
            this.cmbCor.Location = new System.Drawing.Point(243, 155);
            this.cmbCor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCor.Name = "cmbCor";
            this.cmbCor.Size = new System.Drawing.Size(115, 24);
            this.cmbCor.TabIndex = 74;
            this.cmbCor.DropDown += new System.EventHandler(this.cmbCor_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 73;
            this.label1.Text = "Cor";
            // 
            // cmbRaca
            // 
            this.cmbRaca.FormattingEnabled = true;
            this.cmbRaca.Location = new System.Drawing.Point(409, 155);
            this.cmbRaca.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRaca.Name = "cmbRaca";
            this.cmbRaca.Size = new System.Drawing.Size(115, 24);
            this.cmbRaca.TabIndex = 76;
            this.cmbRaca.DropDown += new System.EventHandler(this.cmbRaca_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "Raça";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(243, 229);
            this.cmbEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(115, 24);
            this.cmbEspecie.TabIndex = 78;
            this.cmbEspecie.DropDown += new System.EventHandler(this.cmbEspecie_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 77;
            this.label3.Text = "Espécie";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(409, 229);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(115, 24);
            this.cmbCliente.TabIndex = 80;
            this.cmbCliente.DropDown += new System.EventHandler(this.cmbCliente_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 79;
            this.label4.Text = "Cliente";
            // 
            // cmbTamanho
            // 
            this.cmbTamanho.FormattingEnabled = true;
            this.cmbTamanho.Items.AddRange(new object[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.cmbTamanho.Location = new System.Drawing.Point(243, 364);
            this.cmbTamanho.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTamanho.Name = "cmbTamanho";
            this.cmbTamanho.Size = new System.Drawing.Size(141, 24);
            this.cmbTamanho.TabIndex = 81;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnCadCor
            // 
            this.btnCadCor.Location = new System.Drawing.Point(360, 155);
            this.btnCadCor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadCor.Name = "btnCadCor";
            this.btnCadCor.Size = new System.Drawing.Size(41, 28);
            this.btnCadCor.TabIndex = 82;
            this.btnCadCor.Text = "...";
            this.btnCadCor.UseVisualStyleBackColor = true;
            this.btnCadCor.Click += new System.EventHandler(this.btnCadCor_Click);
            // 
            // btnCadRaca
            // 
            this.btnCadRaca.Location = new System.Drawing.Point(528, 155);
            this.btnCadRaca.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadRaca.Name = "btnCadRaca";
            this.btnCadRaca.Size = new System.Drawing.Size(40, 28);
            this.btnCadRaca.TabIndex = 83;
            this.btnCadRaca.Text = "...";
            this.btnCadRaca.UseVisualStyleBackColor = true;
            // 
            // btnCadEspecie
            // 
            this.btnCadEspecie.Location = new System.Drawing.Point(360, 229);
            this.btnCadEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadEspecie.Name = "btnCadEspecie";
            this.btnCadEspecie.Size = new System.Drawing.Size(41, 28);
            this.btnCadEspecie.TabIndex = 84;
            this.btnCadEspecie.Text = "...";
            this.btnCadEspecie.UseVisualStyleBackColor = true;
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(528, 225);
            this.btnCadCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(40, 28);
            this.btnCadCliente.TabIndex = 85;
            this.btnCadCliente.Text = "...";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            // 
            // frmCadAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 431);
            this.Controls.Add(this.btnCadCliente);
            this.Controls.Add(this.btnCadEspecie);
            this.Controls.Add(this.btnCadRaca);
            this.Controls.Add(this.btnCadCor);
            this.Controls.Add(this.cmbTamanho);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.mskDataCadastro);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.lblFotoAnimal);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.txtTemperamento);
            this.Controls.Add(this.lblTemperamento);
            this.Controls.Add(this.cmbAdotado);
            this.Controls.Add(this.lblAdotado);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.mskDataNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.picbxFotoAnimal);
            this.Controls.Add(this.txtNomeAnimal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.grdDadosAnimal);
            this.Controls.Add(this.barMenutencao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Animal";
            this.Load += new System.EventHandler(this.frmCadAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxFotoAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDadosAnimal)).EndInit();
            this.barMenutencao.ResumeLayout(false);
            this.barMenutencao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.MaskedTextBox mskDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblFotoAnimal;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.TextBox txtTemperamento;
        private System.Windows.Forms.Label lblTemperamento;
        private System.Windows.Forms.ComboBox cmbAdotado;
        private System.Windows.Forms.Label lblAdotado;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.PictureBox picbxFotoAnimal;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView grdDadosAnimal;
        private System.Windows.Forms.ToolStrip barMenutencao;
        private System.Windows.Forms.ToolStripButton barBtnNovo;
        private System.Windows.Forms.ToolStripButton barBtnEditar;
        private System.Windows.Forms.ToolStripButton barBtnExcluir;
        private System.Windows.Forms.ToolStripButton barBtnSalvar;
        private System.Windows.Forms.ToolStripButton barbtnCancelar;
        private System.Windows.Forms.ToolStripButton barBtnFechar;
        private System.Windows.Forms.ComboBox cmbCor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTamanho;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCadCor;
        private System.Windows.Forms.Button btnCadRaca;
        private System.Windows.Forms.Button btnCadEspecie;
        private System.Windows.Forms.Button btnCadCliente;
    }
}