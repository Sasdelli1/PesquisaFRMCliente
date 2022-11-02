using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaCliente.dao.Cliente
{
    class Cliente
    {
        string oChave = "Data Source = 10.39.45.44; Initial Catalog = Senac2022; Persist Security Info=True;User ID = Turma2022; Password=Turma2022@2022";

        public DataSet List_Client(string p_nome)
        { DataSet DataSetCliente = new DataSet();
            try
            {
                SqlConnection Conexao = new SqlConnection(oChave);
                Conexao.Open();
                string wQuery = $"select * from Customer_List where Name like '%{p_nome}%'";
                SqlDataAdapter adapter = new SqlDataAdapter(wQuery,Conexao);
                adapter.Fill(DataSetCliente);
            }
            catch (Exception)
            {

                throw;
            }
            return DataSetCliente;
        }

        public void IncluirCliente (string p_Name, string p_Contact, string p_Adress, int p_Credit)
        {
            try
            {
                SqlConnection Conexao = new SqlConnection(oChave);
                Conexao.Open();
            }
            catch (Exception)
            {

                throw;
            }
           
        
        
        
        
        }
    }
}
