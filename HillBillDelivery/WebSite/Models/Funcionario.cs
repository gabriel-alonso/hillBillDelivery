using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


namespace WebSite.Models
{
    public class Funcionario
    {


        public Int32 id_funcionario { get; set; }

        public String nome { get; set; }

        public String ultimo_nome { get; set; }

        public DateTime data_de_nascimento { get; set; }

        public String email { get; set; }

        public String usuario { get; set; }

        public String senha { get; set; }

        public String cargo { get; set; }


        public Funcionario() { }

        public Funcionario(Int32 id_funcionario)
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            // SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM Funcionario WHERE id_funcionario=@id_funcionario;";
            Comando.Parameters.AddWithValue("@id_funcionario", id_funcionario);


            SqlDataReader Leitor = Comando.ExecuteReader();

            Leitor.Read();

            this.id_funcionario = (Int32)Leitor["id_funcionario"];
            this.nome = (String)Leitor["nome"];
            this.ultimo_nome = (String)Leitor["ultimo_nome"];
            this.data_de_nascimento = (DateTime)Leitor["da_de_nascimento"];
            this.email = (String)Leitor["email"];
            this.usuario = (String)Leitor["usuario"];
            this.senha = (String)Leitor["senha"];
            this.cargo = (String)Leitor["cargo"];


            Conexao.Close();
        }

        public Boolean Salvar()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT INTO Funcionario (nome, ultimo_nome, data_de_nascimento, email, usuario, senha, cargo) VALUES (@nome, @ultimo_nome, @data_de_nascimento, @email, @usuario, @senha, @cargo);";
            Comando.Parameters.AddWithValue("@nome", this.nome);
            Comando.Parameters.AddWithValue("@ultimo_nome", this.ultimo_nome);
            Comando.Parameters.AddWithValue("@data_de_nascimento", this.data_de_nascimento);
            Comando.Parameters.AddWithValue("@email", this.email);
            Comando.Parameters.AddWithValue("@usuario", this.usuario);
            Comando.Parameters.AddWithValue("@senha", this.senha);
            Comando.Parameters.AddWithValue("@cargo", this.cargo);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }
        public Boolean Alterar()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["LPW"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE Funcionario nome = @nome, ultimo_nome = @ultimo_nome, data_de_nascimento = @data_de_nascimento, email = @email, usuario = @usuario, senha = @senha, cargo =@cargo WHERE id_funcionario = @id_funcionario;";
            Comando.Parameters.AddWithValue("@nome", this.nome);
            Comando.Parameters.AddWithValue("@ultimo_nome", this.ultimo_nome);
            Comando.Parameters.AddWithValue("@data_de_nascimento", this.data_de_nascimento);
            Comando.Parameters.AddWithValue("@email", this.email);
            Comando.Parameters.AddWithValue("@usuario", this.usuario);
            Comando.Parameters.AddWithValue("@senha", this.senha);
            Comando.Parameters.AddWithValue("@cargo", this.cargo);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }

        public Boolean Remover()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE FROM Fucinario WHERE id_fucinario = @id_fucinario ;";
            Comando.Parameters.AddWithValue("@id_funcionario", this.id_funcionario);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }

        public static List<Funcionario> Listar()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            // SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT * FROM Acompanhamentos ORDER BY cargo;";

            SqlDataReader Leitor = Comando.ExecuteReader();

            List<Funcionario> Funcionarios = new List<Funcionario>();
            while (Leitor.Read())
            {
                Funcionario F = new Funcionario();
                F.id_funcionario = (Int32)Leitor["id_acompanhamento"];
                F.nome = (String)Leitor["nome"];
                F.ultimo_nome = (String)Leitor["ultimo_nome"];
                F.data_de_nascimento = (DateTime)Leitor["da_de_nascimento"];
                F.email = (String)Leitor["email"];
                F.usuario = (String)Leitor["usuario"];
                F.senha = (String)Leitor["senha"];
                F.cargo = (String)Leitor["cargo"];

                Funcionarios.Add(F);
            }

            Conexao.Close();

            return Funcionarios;
        }
    }
}