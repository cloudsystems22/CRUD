using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Win02.Modelos;
using System.ComponentModel.DataAnnotations;
using Win02.Banco;

namespace Win02
{
    public partial class CadastroFuncionario : Form
    {
        private TelaPrincipal telaPrincipal;
        private Funcionario func;
        public CadastroFuncionario(TelaPrincipal tela)
        {
            telaPrincipal = tela;
            //lblErros.Text = "";
            InitializeComponent();
        }

        
        public CadastroFuncionario(TelaPrincipal tela, int id)
        {
            telaPrincipal = tela;
            //lblErros.Text = "";
            InitializeComponent();

            func = FuncionarioDataAccess.PegaFuncionario(id);
            CarregarFuncionario(func);
        }

        
        private void SalvarAction(object sender, EventArgs e)
        {
            Funcionario funcionario;
            
            if(func != null)
            {
                //Atualizar o funcionário
                funcionario = func;
                funcionario.DataAtualizacao = DateTime.Now;
            }
            else
            {
                //Novo cadastro
                funcionario = new Funcionario();
                funcionario.DataCadastro = DateTime.Now;
                funcionario.DataAtualizacao = DateTime.Now;


            }

            //CARREGAR OS DADOS PARA CLASSE FUNCIONARIO
            funcionario.Nome = txtNome.Text.Trim();
            funcionario.Email = txtEmail.Text.Trim();
            try
            {
                funcionario.Salario = Convert.ToDecimal(txtSalario.Text);
            } catch {
                MessageBox.Show("O Campo salário não pode ser nullo, ou texto, precisa ser um valor decimal 0,00!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
            }
            
            funcionario.Sexo = (rbMasculino.Checked) ? "M" : "F";
            funcionario.TipoContrato = (rbCLT.Checked) ? "CLT" : (rbPJ.Checked) ? "PJ" : "AUT";
            

            //VALIDAR OS DADOS
            List<ValidationResult> listerros = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(funcionario);
            bool validado = Validator.TryValidateObject(funcionario, validationContext, listerros, true);
            if (validado)
            {
                //Validação Ok.
                bool resultado;
                if (func != null)
                {
                    //
                    resultado = FuncionarioDataAccess.AtualizarFuncionario(funcionario);
                }
                else
                {
                    resultado = FuncionarioDataAccess.InserirFuncionario(funcionario);
                }

                if (resultado)
                {
                    //FuncionarioDataAccess.InserirFuncionario(funcionario);
                    telaPrincipal.AtualizarTabela();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao tentar salvar esse funcionário. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                            
            }
            else
            {
                //Validação erro.
                StringBuilder sb = new StringBuilder();
                foreach(var l in listerros)
                {
                   sb.Append(l.ErrorMessage + "\n");
                }
                lblErros.Text = sb.ToString();
            }
            //SALVAR OS DADOS
            //FECHAR E ATUALIZAR A TELA PRINCIPAL


        }

        private void CarregarFuncionario(Funcionario funcionario)
        {
            txtNome.Text = funcionario.Nome.Trim();
            txtEmail.Text = funcionario.Email.Trim();
            txtSalario.Text = Convert.ToString(funcionario.Salario);
            if(funcionario.Sexo == "M") { rbMasculino.Checked = true; } else { rbFeminino.Checked = true; };
            if (funcionario.TipoContrato.Trim() == "CLT") { rbCLT.Checked = true; }
            else if(funcionario.TipoContrato.Trim() == "PJ") { rbPJ.Checked = true; } else if (funcionario.TipoContrato.Trim() == "AUT") { rbAutonomo.Checked = true; };
        }
    }
}
