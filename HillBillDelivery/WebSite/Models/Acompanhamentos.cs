using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebSite.Models
{
    public class Acompanhamentos
    {
        public Int32 id_acompanhamento { get; set; }

        public String nome { get; set; }

        public String descricao { get; set; }

        public Double preco { get; set; }

        public Int32 quantidade { get; set; }

        public DateTime ultima_atualizacao { get; set; }


        public Acompanhamentos() { }

        public Acompanhamentos(Int32 id_acompanhamento)
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM Acompanhamentos WHERE id_acompanhamento=@id_acompanhamento;";
            Comando.Parameters.AddWithValue("@id_acompanhamento", id_acompanhamento);


            SqlDataReader Leitor = Comando.ExecuteReader();

            Leitor.Read();

            this.id_acompanhamento = (Int32)Leitor["id_acompanhamento"];
            this.nome = (String)Leitor["nome"];
            this.descricao = (String)Leitor["descricao"];
            this.preco = (float)Leitor["preco"];
            this.quantidade = (Int32)Leitor["quantidade"];

            Conexao.Close();
        }

        public Acompanhamentos(String nome)
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM Acompanhamentos WHERE nome=@nome;";
            Comando.Parameters.AddWithValue("@nome", nome);


            SqlDataReader Leitor = Comando.ExecuteReader();

            Leitor.Read();

            this.id_acompanhamento = (Int32)Leitor["id_acompanhamento"];
            this.nome = (String)Leitor["nome"];
            this.descricao = (String)Leitor["descricao"];
            this.preco = (float)Leitor["preco"];
            this.quantidade = (Int32)Leitor["quantidade"];

            Conexao.Close();
        }

        public Boolean Salvar()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            // SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT INTO Acompanhamentos (nome, descricao, preco, quantidade,ultima_atualizacao) VALUES (@nome, @descricao, @preco, @quantidade,@ultima_atualizacao);";
            Comando.Parameters.AddWithValue("@nome", this.nome);
            Comando.Parameters.AddWithValue("@descricao", this.descricao);
            Comando.Parameters.AddWithValue("@preco", this.preco);
            Comando.Parameters.AddWithValue("@quantidade", this.quantidade);
            Comando.Parameters.AddWithValue("@ultima_atualizacao", this.ultima_atualizacao);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }

        public Boolean Alterar()
        {
            // SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["HillBill_Delivery"].ConnectionString);
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            Conexao.Open();



            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE Acompanhamentos id_acompanhamento = @id_acompanhamento, nome = @nome, preco = @preco WHERE id_acompanhamento = @id_acompanhamento;";
            Comando.Parameters.AddWithValue("@nome", this.nome);
            Comando.Parameters.AddWithValue("@descricao", this.descricao);
            Comando.Parameters.AddWithValue("@preco", this.preco);
            Comando.Parameters.AddWithValue("@quantidade", this.quantidade);

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
            Comando.CommandText = "DELETE FROM Acompanhamentos WHERE id_acompanhamento = @id_acompanhamento;";
            Comando.Parameters.AddWithValue("@id_acompanhamento", this.id_acompanhamento);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }
        public List<Acompanhamentos> Listar()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT * FROM Acompanhamentos ORDER BY nome;";

            SqlDataReader Leitor = Comando.ExecuteReader();

            List<Acompanhamentos> Acompanhamento = new List<Acompanhamentos>();
            while (Leitor.Read())
            {
                Acompanhamentos A = new Acompanhamentos();
                A.id_acompanhamento = Convert.ToInt32(Leitor["id_acompanhamento"].ToString());
                A.nome = Leitor["nome"].ToString();
                A.descricao = Leitor["descricao"].ToString();
                A.preco = Convert.ToDouble(Leitor["preco"].ToString());
                A.quantidade = Convert.ToInt32(Leitor["quantidade"].ToString());

                Acompanhamento.Add(A);
            }

            Conexao.Close();

            return Acompanhamento;
        }
      }
    }