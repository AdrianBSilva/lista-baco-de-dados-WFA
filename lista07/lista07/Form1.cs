using lista07.Modelo;
using lista07.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista07
{
    public partial class CadastroDeAlunos : Form
    {
        public CadastroDeAlunos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alunos alunos = new Alunos()
            {
                Nome = txtNome.Text,
                Matricula = txtMatricula.Text,
                Nota01 = Convert.ToDouble(txtNota01.Text),
                Nota02 = Convert.ToDouble(txtNota02.Text),
                Nota03 = Convert.ToDouble(txtNota03.Text),
                Frequencia = Convert.ToInt32(txtFrequencia.Text)
            };
            
            if(string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                int id = new AlunosRepositorio().Inserir(alunos);
                txtCodigo.Text = id.ToString();
                MessageBox.Show("Registro cadastrado com sucesso.");
            }
            else
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                alunos.Id = id;
                bool alterou = new AlunosRepositorio().Alterar(alunos);
                if(alterou)
                {
                    MessageBox.Show("Registro alterado com sucesso");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar");
                }
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtMatricula.Text = "";
            txtNota01.Text = "";
            txtNota02.Text = "";
            txtNota03.Text = "";
            txtFrequencia.Text = "";
        }
    }
}
