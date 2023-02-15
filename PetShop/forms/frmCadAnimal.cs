using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PetShop
{
    public partial class frmCadAnimal : Form
    {

        private Int16 codAnimal, sexo,tamanho,adotado;
        private bool novosDados;
        dbAnimal sqlAnimal = new dbAnimal();
        utility utility = new utility();

        public frmCadAnimal()
        {
            InitializeComponent();
        }

        private void preencheComboCor()
        {
            dbCor sqlCor = new dbCor();

            cmbCor.DataSource = sqlCor.selectCorDBaseGrid();
            cmbCor.ValueMember = "corid";
            cmbCor.DisplayMember = "cornome";
        }

        private void preencherComboCliente() 
        {
            dbInfoAdicionais info = new dbInfoAdicionais();
            cmbCliente.DataSource = info.selectClienteDBaseGrid();
            cmbCliente.ValueMember = "clienteid";
            cmbCliente.DisplayMember = "clientenome";
        }

        private void preencherComboEspecie()
        {
            dbInfoAdicionais info = new dbInfoAdicionais();
            cmbEspecie.DataSource = info.selectEspecieDBaseGrid();
            cmbEspecie.ValueMember = "especieid";
            cmbEspecie.DisplayMember = "especienome";
        }

        private void preencerComboRaca() 
        
        {
            dbInfoAdicionais info = new dbInfoAdicionais();
            cmbRaca.DataSource = info.selectRacaDBaseGrid();
            cmbRaca.ValueMember = "racaid";
            cmbRaca.DisplayMember = "racanome";
        }

        private void iniciaCombos() {
            preencheComboCor();
            preencherComboCliente();
            preencerComboRaca();
            preencherComboEspecie();
        }

        private void habilitaBotoesMenu(bool habilitar)
        {
            barBtnNovo.Enabled = habilitar;
            barBtnEditar.Enabled = habilitar;
            barBtnExcluir.Enabled = habilitar;
            barBtnSalvar.Enabled = !habilitar;
            barbtnCancelar.Enabled = !habilitar; 
            barBtnFechar.Enabled = habilitar;
        }

        private void habilitaCamposDados(bool habilitar) {
            txtNomeAnimal.Enabled = habilitar;
            mskDataCadastro.Enabled = habilitar;
            mskDataNascimento.Enabled = habilitar;
            txtTemperamento.Enabled = habilitar;
            txtPeso.Enabled = habilitar;
            txtObservacao.Enabled = habilitar;
            cmbCor.Enabled = habilitar;
            cmbRaca.Enabled = habilitar;
            cmbSexo.Enabled = habilitar;
            cmbEspecie.Enabled = habilitar;
            cmbCliente.Enabled = habilitar;
            cmbAdotado.Enabled = habilitar;
            cmbTamanho.Enabled = habilitar;
            btnCadCliente.Enabled = habilitar;
            btnCadCor.Enabled = habilitar;
            btnCadEspecie.Enabled = habilitar;
            btnCadRaca.Enabled = habilitar;
            btnCarregar.Enabled = habilitar;


        }

        private void formataGrid()
        {
            grdDadosAnimal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosAnimal.Columns[0].HeaderText = "Código";
            grdDadosAnimal.Columns[1].HeaderText = "Nome";

            grdDadosAnimal.Columns[0].Width = 0;
            grdDadosAnimal.Columns[1].Width = 190;
        }

        private void limpaCamposDados()
        {
            txtNomeAnimal.Text = "";
            mskDataCadastro.Text = "";
            mskDataNascimento.Text = "";
            txtTemperamento.Text = "";
            txtPeso.Text = "";
            txtObservacao.Text = "";
            cmbCor.SelectedValue = -1;
            cmbRaca.SelectedValue = -1;
            cmbSexo.SelectedValue = -1;
            cmbEspecie.SelectedValue = -1;
            cmbCliente.SelectedValue = -1;
            cmbAdotado.SelectedValue = -1;
            cmbTamanho.SelectedValue = -1;
            picbxFotoAnimal.Image = null;

        }

        private bool verificaDadosVeridicos()
        {
            bool resultado = true;

         
            if (utility.validarData(mskDataNascimento.Text.ToString()) == false || utility.validarData(mskDataCadastro.Text.ToString())==false)
            {
                MessageBox.Show("Data de Nascimento inválida!!!");
                resultado = false;
            }

            return resultado;
        }

        private void selectUsuarioDBase()
        {
            grdDadosAnimal.DataSource = sqlAnimal.selectAnimalDBaseGrid();
        }


        private void selectUsuarioDBase(Int16 codAnimal)
        {
            DataSet dsAnimal = new DataSet();
            MySqlDataAdapter adapterAnimal = new MySqlDataAdapter();
            adapterAnimal = sqlAnimal.selectAnimalDBase(codAnimal);
            adapterAnimal.Fill(dsAnimal);

            txtNomeAnimal.Text = dsAnimal.Tables[0].Rows[0][1].ToString();
            cmbCor.SelectedValue = dsAnimal.Tables[0].Rows[0][2];
            cmbRaca.SelectedValue = dsAnimal.Tables[0].Rows[0][3];
            cmbSexo.SelectedValue = dsAnimal.Tables[0].Rows[0][4];
            cmbEspecie.SelectedValue = dsAnimal.Tables[0].Rows[0][5];
            cmbCliente.SelectedValue = dsAnimal.Tables[0].Rows[0][6];
            mskDataNascimento.Text = dsAnimal.Tables[0].Rows[0][7].ToString();
            mskDataCadastro.Text = dsAnimal.Tables[0].Rows[0][8].ToString();
            cmbAdotado.SelectedValue = dsAnimal.Tables[0].Rows[0][9];
            txtTemperamento.Text = dsAnimal.Tables[0].Rows[0][10].ToString();
            txtPeso.Text = dsAnimal.Tables[0].Rows[0][11].ToString();
            cmbTamanho.SelectedValue = dsAnimal.Tables[0].Rows[0][12];
            txtObservacao.Text = dsAnimal.Tables[0].Rows[0][13].ToString();
            picbxFotoAnimal.ImageLocation = dsAnimal.Tables[0].Rows[0][14].ToString();

        }

        private void insereAnimal()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
            novosDados = true;
        }

        private void alteraAnimal()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            novosDados = false;
        }

        private void excluiAnimal()
        {
            if (codAnimal != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (retorno == DialogResult.Yes)
                {
                    sqlAnimal.excluiAnimalDBase(codAnimal);

                    limpaCamposDados();
                    selectUsuarioDBase();
                }
            }
            else
            {
                MessageBox.Show("Não há informação selecionada para excluir!!", "Aviso!!!", MessageBoxButtons.OK);
            }
        }

        private void cancelaAnimal()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização dos Dados?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }

        private void fechaAnimal()
        {
            this.Close();
        }

        private void salvaAnimal()
        {
            

            if (verificaDadosVeridicos() == true)
            {
                if (codAnimal == 0)
                {
                    sqlAnimal.insereAnimalDBase(txtNomeAnimal.Text.ToString(), Convert.ToInt32(cmbCliente.SelectedValue),
                        Convert.ToInt32(cmbRaca.SelectedValue), Convert.ToInt32(cmbEspecie.SelectedValue), Convert.ToInt32(cmbCor.SelectedValue),Convert.ToDateTime(mskDataNascimento.Text.ToString()),
                        cmbSexo.SelectedIndex, Convert.ToDateTime(mskDataNascimento.Text.ToString()),cmbAdotado.SelectedIndex,txtTemperamento.Text.ToString(),
                        cmbTamanho.SelectedIndex,txtObservacao.Text.ToString(), Convert.ToDouble(txtPeso.Text.ToString()),picbxFotoAnimal.ImageLocation.ToString());
                }
                else
                {   
                    sqlAnimal.alteraAnimalDBase(codAnimal, txtNomeAnimal.Text.ToString(), Convert.ToInt32(cmbCliente.SelectedValue), Convert.ToInt32(cmbRaca.SelectedValue), Convert.ToInt32(cmbEspecie.SelectedValue), Convert.ToInt32(cmbCor.SelectedValue), Convert.ToDateTime(mskDataNascimento.Text.ToString()),
                        cmbTamanho.SelectedIndex, Convert.ToDateTime(mskDataNascimento.Text.ToString()), cmbAdotado.SelectedIndex, txtTemperamento.Text.ToString(),
                        cmbTamanho.SelectedIndex, txtObservacao.Text.ToString(), Convert.ToDouble(txtPeso.Text.ToString()), picbxFotoAnimal.ImageLocation.ToString());
                }
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
                selectUsuarioDBase();
            }
            else
            {
                MessageBox.Show("Dados Obrigatórios não informados", "Urgente!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barBtnNovo_Click(object sender, EventArgs e)
        {
            insereAnimal();
            iniciaCombos();
        }

        private void barBtnEditar_Click(object sender, EventArgs e)
        {
            alteraAnimal();
            iniciaCombos();
        }

        private void barBtnExcluir_Click(object sender, EventArgs e)
        {
            excluiAnimal();
        }

        private void barBtnSalvar_Click(object sender, EventArgs e)
        {
            salvaAnimal();
        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaAnimal();
        }

        private void barBtnFechar_Click(object sender, EventArgs e)
        {
            fechaAnimal();
        }

        private void grdDadosAnimal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codAnimal = Convert.ToInt16(grdDadosAnimal.Rows[grdDadosAnimal.CurrentRow.Index].Cells[0].Value.ToString());
            selectUsuarioDBase(codAnimal);
        }

        private void frmCadAnimal_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            selectUsuarioDBase();
            formataGrid();
            codAnimal = 0;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picbxFotoAnimal.ImageLocation = file.FileName;
            }
        }

        private void btnCadCor_Click(object sender, EventArgs e)
        {
            frmCadCor frmCor = new frmCadCor();
            frmCor.ShowDialog(this);
            
        }

        private void cmbCor_DropDown(object sender, EventArgs e)
        {
            iniciaCombos();
        }

        private void cmbRaca_DropDown(object sender, EventArgs e)
        {
            iniciaCombos();
        }

        private void cmbEspecie_DropDown(object sender, EventArgs e)
        {
            iniciaCombos();
        }

        private void cmbCliente_DropDown(object sender, EventArgs e)
        {
            iniciaCombos();
        }
    }
}
