using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
namespace WebSite.Models
{
    public class Cidade
    {
        public Int32 id_cidade { get; set; }
        public String cidade { get; set; }

        public Cidade() { }

        public Cidade(Int32 id_cidade)
        {
            new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM Cidade WHERE id_cidade=@id_cidade;";
            Comando.Parameters.AddWithValue("@id_cidade", id_cidade);


            SqlDataReader Leitor = Comando.ExecuteReader();

            Leitor.Read();

            this.id_cidade = (Int32)Leitor["id_cidade"];
            this.cidade = (String)Leitor["cidade"];

            Conexao.Close();
        }

        public Cidade(String cidade)
        {
            SqlConnection Conexao =new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM Cidade WHERE id_cidade=@id_cidade;";
            Comando.Parameters.AddWithValue("@id_cidade", id_cidade);


            SqlDataReader Leitor = Comando.ExecuteReader();

            Leitor.Read();

            this.id_cidade = (Int32)Leitor["id_cidade"];
            this.cidade = (String)Leitor["cidade"];

            Conexao.Close();
        }
        public Boolean Salvar()
        {
            new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            SqlConnection Conexao = Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT INTO Cidades (cidade) VALUES (@cidade);";
            Comando.Parameters.AddWithValue("@cidade", this.cidade);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }
        public Boolean Alterar()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE Cidade id_cidade = @id_cidade, cidade = @cidade WHERE id_cidade= @id_cidade;";
            Comando.Parameters.AddWithValue("@cidade", this.cidade);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }

        public Boolean Remover()
        {
            SqlConnection Conexao =  new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE FROM Cidade WHERE id_cidade = @id_cidade;";
            Comando.Parameters.AddWithValue("@id_cidade", this.id_cidade);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }
        public static List<Cidade> Listar()
        {
            SqlConnection Conexao =  new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT * FROM Cidade ORDER BY cidade;";

            SqlDataReader Leitor = Comando.ExecuteReader();

            List<Cidade> Cidades = new List<Cidade>();
            while (Leitor.Read())
            {
                Cidade C = new Cidade();
                C.id_cidade = (Int32)Leitor["id_cidade"];
                C.cidade = (String)Leitor["cidade"];

                Cidades.Add(C);
            }

            Conexao.Close();

            return Cidades;
        }
    }
}