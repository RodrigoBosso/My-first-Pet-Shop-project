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
    public partial class frmCadCor : Form
    {
        public frmCadCor()
        {
            InitializeComponent();
        }

        private Int16 codCor;
        private bool novosDados;
        private dbCor sqlCor = new dbCor();

        private void selectCorDBase()
        {
            DataTable dtCor = new DataTable();
            MySqlDataAdapter adapterCor = new MySqlDataAdapter();
            adapterCor = sqlCor.selectCorDBase();
            adapterCor.Fill(dtCor);
            grdDadosCor.DataSource = dtCor;
        }

        private void selectCorDBase(Int16 codCor)
        {
            DataSet dsCor = new DataSet();
            MySqlDataAdapter adapterCor = new MySqlDataAdapter();
            adapterCor = sqlCor.selectCorDBase(codCor);
            adapterCor.Fill(dsCor);

            txtNomeCor.Text = dsCor.Tables[0].Rows[0][0].ToString();
            
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

        private void habilitaCamposDados(bool habilitar)
        {
            txtNomeCor.Enabled = habilitar;
            grdDadosCor.Enabled = !habilitar;
        }

        private void limpaCamposDados()
        {
            txtNomeCor.Text = "";
            codCor = 0;
        }

        private bool verificaDadosObrigatorios()
        {
            bool resultado = true;
            //Verifica Dados do Nome
            if (txtNomeCor.Text.Trim().Length < 3)
            {
                resultado = false;
            }

            return resultado;
        }

        private void formataGrid()
        {
            grdDadosCor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDadosCor.Columns[0].HeaderText = "Código";
            grdDadosCor.Columns[1].HeaderText = "Nome";

            grdDadosCor.Columns[0].Width = 0;
            grdDadosCor.Columns[1].Width = 180;

        }

        private void frmCadCor_Load(object sender, EventArgs e)
        {
            habilitaBotoesMenu(true);
            habilitaCamposDados(false);
            selectCorDBase();
            formataGrid();
            codCor = 0;
        }


        private void barBtnNovo_Click(object sender, EventArgs e)
        {
            insereCor();
        }

        private void insereCor()
        {
            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            limpaCamposDados();
            novosDados = true;
        }

        private void barBtnEditar_Click(object sender, EventArgs e)
        {
            alteraCor();
        }

        private void alteraCor()
        {
            if (txtNomeCor.Text.ToString() == "")
            {
                MessageBox.Show("Escolha alguma informação antes de editar!!", "Aviso", MessageBoxButtons.OK);
            }
            else 
            { 

            habilitaBotoesMenu(false);
            habilitaCamposDados(true);
            novosDados = false;
            
            }
        }

        private void barBtnExcluir_Click(object sender, EventArgs e)
        {
            excluiCor();
        }

        private void excluiCor()
        {
            DialogResult retorno = MessageBox.Show("Deseja excluir a informação selecionada", "Aviso!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (codCor != 0)
            {
                if (retorno == DialogResult.Yes)
                {
                    sqlCor.excluiCorDBase(codCor);

                    limpaCamposDados();
                    selectCorDBase();
                }
            }
            else
            {
                MessageBox.Show("Nao ha informacao selecionada para excluir!!", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void barBtnSalvar_Click(object sender, EventArgs e)
        {
            salvaCor();
        }

        private void salvaCor()
        {
            if (verificaDadosObrigatorios() == true)
            {
                if (novosDados)
                {
                    sqlCor.insereCorDBase(txtNomeCor.Text.ToString());
                }
                else
                {
                    sqlCor.alteraCorDBase(txtNomeCor.Text.ToString(), codCor);
                }

                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
                selectCorDBase();
            }
            else
            {
                MessageBox.Show("Dados Obrigatórios não informados", "Urgente!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void barbtnCancelar_Click(object sender, EventArgs e)
        {
            cancelaCor();
        }

        private void cancelaCor()
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar o Cadastro/Atualização dos Dados?", "Aviso!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                habilitaBotoesMenu(true);
                habilitaCamposDados(false);
                limpaCamposDados();
            }
        }

        private void barBtnFechar_Click(object sender, EventArgs e)
        {
            fechaCor();
        }

        private void fechaCor()
        {
            this.Close();
        }

        private void grdDadosCor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codCor = Convert.ToInt16(grdDadosCor.Rows[grdDadosCor.CurrentRow.Index].Cells[0].Value.ToString());
            selectCorDBase(codCor);
        }

        
    }
}
