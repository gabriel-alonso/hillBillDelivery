using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


namespace WebSite.Models
{
    public class Cliente
    {
        public Int32 id_cliente { get; set; }
        public Endereco id_endereco { get; set; }
        public String nome { get; set; }
        public String ultimo_nome { get; set; }
        public DateTime data_de_nascimento { get; set; }
        public String cpf { get; set; }
        public String rg { get; set; }
        public Int32 telefone { get; set; }
        public String email { get; set; }
        public String usuario { get; set; }
        public String senha { get; set; }


        public Cliente( ) {  }

        public Cliente(Int32 id_cliente)
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM Cliente WHERE id_cliente=@id_cliente;";
            Comando.Parameters.AddWithValue("@id_cliente", id_cliente);


            SqlDataReader Leitor = Comando.ExecuteReader();

            Leitor.Read();

            this.id_cliente = (Int32)Leitor["id_cliente"];
            this.id_endereco = (Endereco)Leitor["id_endereco"];
            this.nome = (String)Leitor["nome"];
            this.ultimo_nome = (String)Leitor["ultimo_nome"];
            this.data_de_nascimento = (DateTime)Leitor["data_de_nascimento"];
            this.cpf = (String)Leitor["cpf"];
            this.rg = (String)Leitor["rg"];
            this.email = (String)Leitor["email"];
            this.usuario = (String)Leitor["usuario"];
            this.senha = (String)Leitor["senha"];

            Conexao.Close();
        }
        public Cliente(String cpf)
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM Cliente WHERE cpf=@cpf;";
            Comando.Parameters.AddWithValue("@cpf", cpf);


            SqlDataReader Leitor = Comando.ExecuteReader();

            Leitor.Read();

            this.id_cliente = (Int32)Leitor["id_cliente"];
            this.id_endereco = (Endereco)Leitor["id_endereco"];
            this.nome = (String)Leitor["nome"];
            this.ultimo_nome = (String)Leitor["ultimo_nome"];
            this.data_de_nascimento = (DateTime)Leitor["data_de_nascimento"];
            this.cpf = (String)Leitor["cpf"];
            this.rg = (String)Leitor["rg"];
            this.email = (String)Leitor["email"];
            this.usuario = (String)Leitor["usuario"];
            this.senha = (String)Leitor["senha"];

            Conexao.Close();
        }

        public Boolean Pedir()
        {
            throw new NotImplementedException();
        }

        public Boolean Cancelar()
        {
            throw new NotImplementedException();
        }

        public static Boolean Autenticar(String email, String senha)
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);

            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID FROM Cliente WHERE email=@email AND senha=@senha;";
            Comando.Parameters.AddWithValue("@email", email);
            Comando.Parameters.AddWithValue("@senha", senha);

            SqlDataReader Leitor = Comando.ExecuteReader();

            Boolean Resultado = Leitor.HasRows;

            Conexao.Close();

            return Resultado ? true : false;
        }
    }
}