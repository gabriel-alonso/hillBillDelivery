using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebSite.Models
{
    public class Pagamento
    {
        public Int32 id_pagamento { get; set; }
        public Cliente id_cliente { get; set; }
        public float valor { get; set; }
        public String status { get; set; }
        public String tipo_de_pagamento { get; set; }
        public DateTime data_de_pagamento { get; set; }

        public Pagamento() { }

        public Pagamento(Int32 id_pagamento)
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            // SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT * FROM Pagamento WHERE id_pagamento=@id_pagamento;";
            Comando.Parameters.AddWithValue("@id_pagamento", id_pagamento);


            SqlDataReader Leitor = Comando.ExecuteReader();

            Leitor.Read();

            this.id_pagamento = (Int32)Leitor["id_pagamento"];
            this.id_cliente = (Cliente)Leitor["id_cliente"];
            this.valor = (float)Leitor["valor"];
            this.status = (String)Leitor["status"];
            this.data_de_pagamento = (DateTime)Leitor["data_de_pagamento"];

            Conexao.Close();

        }
        public Boolean Salvar()
        {
            SqlConnection Conexao = new SqlConnection("Server=ESN509VMSSQL; Database=HillBill_Delivery; User Id=Aluno; Password=Senai1234;");
            //SqlConnection Conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Hillbill_Delivery"].ConnectionString);
            Conexao.Open();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT INTO Pagamento (valor, status, data_de_pagamento, quantidade,) VALUES (@logradouro @bairro, @cep);";
            //Comando.Parameters.AddWithValue("@logradouro", this.logradouro);

            Int32 Resultado = Comando.ExecuteNonQuery();

            Conexao.Close();

            return Resultado > 0 ? true : false;
        }

    }
}