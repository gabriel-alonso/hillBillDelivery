using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebSite.Models
{
    public class Endereco
    {
        public Int32 id_endereco { get; set; }
        public Cidade id_cidade { get; set; }
        public String logradouro { get; set; }
        public String bairro { get; set; }
        public int cep { get; set; }


        public Endereco() { }

        public Endereco(Int32 id_endereco)
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            // SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM Endereco WHERE id_endereco=@id_endereco;";
            Comando.Parameters.AddWithValue("@id_endereco", id_endereco);


            SqlDataReader Leitor = Comando.ExecuteReader();

            Leitor.Read();

            this.id_endereco = (Int32)Leitor["id_endereco"];
            this.logradouro = (String)Leitor["logradouro"];
            this.bairro = (String)Leitor["bairro"];
            this.cep = (Int32)Leitor["cep"];

            Conexao.Close();
        }

        public Endereco(String logradouro)
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM Endereco WHERE logradouro=@logradouro;";
            Comando.Parameters.AddWithValue("@logradouro", logradouro);


            SqlDataReader Leitor = Comando.ExecuteReader();

            Leitor.Read();

            this.id_endereco = (Int32)Leitor["id_endereco"];
            this.logradouro = (String)Leitor["logradouro"];
            this.bairro = (String)Leitor["bairro"];
            this.cep = (Int32)Leitor["cep"];

            Conexao.Close();
        }

        public Boolean Salvar()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT INTO Endereco (logradouro, bairro, cep, quantidade,) VALUES (@logradouro @bairro, @cep);";
            Comando.Parameters.AddWithValue("@logradouro", this.logradouro);
            Comando.Parameters.AddWithValue("@bairro", this.bairro);
            Comando.Parameters.AddWithValue("@cep", this.cep);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }

        public Boolean Alterar()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            // SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["LPW"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE Endereco id_endereco = @id_endereco, logradouro = @logradouro, cep= @cep WHERE id_endereco= @id_endereco;";
            Comando.Parameters.AddWithValue("@logradouro", this.logradouro);
            Comando.Parameters.AddWithValue("@bairro", this.bairro);
            Comando.Parameters.AddWithValue("@cep", this.cep);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }

        public Boolean Remover()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            // SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE FROM Post WHERE id_endereco= @id_endereco;";
            Comando.Parameters.AddWithValue("@id_endereco", this.id_endereco);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }
        public static List<Endereco> Listar()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            // SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT * FROM Endereco ORDER BY logradouro;";

            SqlDataReader Leitor = Comando.ExecuteReader();

            List<Endereco> endereco = new List<Endereco>();
            while (Leitor.Read())
            {
                Endereco A = new Endereco();
                A.id_endereco = (Int32)Leitor["id_endereco"];
                A.logradouro = (String)Leitor["logradouro"];
                A.bairro = (String)Leitor["bairro"];
                A.cep = (Int32)Leitor["cep"];
                
                endereco.Add(A);
            }
            Conexao.Close();

            return endereco;
        }
    }
}