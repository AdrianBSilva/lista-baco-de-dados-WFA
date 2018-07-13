using lista07.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista07.Repositorio
{
    class AlunosRepositorio
    {
        private string connerctionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\104996\Documents\lista07.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection = null;

        public AlunosRepositorio()
        {
            connection = new SqlConnection(connerctionString);
        }

        public int Inserir(Alunos alunos)
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO alunos (nome, matricula, nota01, nota02, nota03, frequencia)
            OUTPUT INSERTED.ID
            VALUES (@NOME, @MATRICULA, @NOTA01, @NOTA02, @NOTA03, @FREQUENCIA)";

            command.Parameters.AddWithValue("@NOME", alunos.Nome);
            command.Parameters.AddWithValue("@MATRICULA", alunos.Matricula);
            command.Parameters.AddWithValue("@NOTA01",alunos.Nota01);
            command.Parameters.AddWithValue("@NOTA02",alunos.Nota02);
            command.Parameters.AddWithValue("@NOTA03",alunos.Nota03);
            command.Parameters.AddWithValue("@FREQUENCIA",alunos.Frequencia);
            int id = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
            return id;
        }

        public bool Alterar(Alunos alunos)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"UPDATE alunos SET
nome = @NOME,
matricula = @MATRICULA,
nota01 = @NOTA01,
nota01 = @NOTA02,
nota01 = @NOTA03,
frequencia = @FREQUENCIA
WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", alunos.Nome);
            comando.Parameters.AddWithValue("@MATRICULA", alunos.Matricula);
            comando.Parameters.AddWithValue("@NOTA01", alunos.Nota01);
            comando.Parameters.AddWithValue("@NOTA02", alunos.Nota02);
            comando.Parameters.AddWithValue("@NOTA03", alunos.Nota03);
            comando.Parameters.AddWithValue("@FREQUENCIA", alunos.Frequencia);
            int quantidadeAlterada = comando.ExecuteNonQuery();
            connection.Close();
            return quantidadeAlterada == 1;
        }

        public List<Alunos> ObterTodos(
                string textoParaPesquisar = "%%",
                string colunaOrdenacao = "nome",
                string tipoOrdenacao = "ASC")
        {
            textoParaPesquisar = "%" + textoParaPesquisar + "%";
            List<Alunos> alunos = new List<Alunos>();
            connection.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;

            comando.CommandText = @"SELECT id, nome, matricula, nota01, nota02, nota03, frequencia FROM alunos
                                    WHERE nome LIKE @PESQUISA OR matricula LIKE @PESQUISA 
                                    ORDER BY " + colunaOrdenacao + " " + tipoOrdenacao;

            comando.Parameters.AddWithValue("@PESQUISA", textoParaPesquisar);

            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            for(int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                Alunos aluno = new Alunos();
                aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[i][0]);
                aluno.Nome = tabelaEmMemoria.Rows[i][1].ToString();
                aluno.Matricula = tabelaEmMemoria.Rows[i][2].ToString();
                aluno.Nota01 = Convert.ToDouble(tabelaEmMemoria.Rows[i][3].ToString());
                aluno.Nota02 = Convert.ToDouble(tabelaEmMemoria.Rows[i][4].ToString());
                aluno.Nota03 = Convert.ToDouble(tabelaEmMemoria.Rows[i][5].ToString());
                alunos.Add(aluno);
            }
            connection.Close();
            return alunos;
        }

        public Alunos ObterPeloCodigo(int codigo)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"SELECT id, nome, matricula, nota01, nota02, nota03, frequencia FROM alunos
                                    WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", codigo);

            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            if(tabelaEmMemoria.Rows.Count == 0)
            {
                return null;
            }

            Alunos aluno = new Alunos();
            aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[0][0]);
            aluno.Nome = tabelaEmMemoria.Rows[0][1].ToString();
            aluno.Matricula = tabelaEmMemoria.Rows[0][2].ToString();
            aluno.Nota01 = Convert.ToDouble(tabelaEmMemoria.Rows[0][3].ToString());
            aluno.Nota02 = Convert.ToDouble(tabelaEmMemoria.Rows[0][4].ToString());
            aluno.Nota03 = Convert.ToDouble(tabelaEmMemoria.Rows[0][5].ToString());
            connection.Close();
            return aluno;
        }

        public bool Apagar(int codigo)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = "DELETE FROM alunos WHERE id = @CODIGO";
            comando.Parameters.AddWithValue("@CODIGO", codigo);
            int quantidade = comando.ExecuteNonQuery();
            connection.Close();
            return quantidade == 1;
        }

    }
}
