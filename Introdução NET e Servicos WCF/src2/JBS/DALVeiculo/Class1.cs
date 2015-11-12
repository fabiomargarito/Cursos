using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace DALVeiculo
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public int Categoria { get; set; }

    }

    public class DALVeiculo
    {

        public DALVeiculo() {
            stringDeConexao = ConfigurationManager.ConnectionStrings["JBS"].ConnectionString;
        }

        public string stringDeConexao { get; set; }

        //Criar função que retorne ListaDeVeiculos
        public List<Veiculo> retornarVeiculos()
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            using (var conexao = new OracleConnection(stringDeConexao))
            {

                OracleCommand comando = new OracleCommand();
                comando.Connection = conexao;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_RETORNARVEICULOS";
                comando.Parameters.Add("VEICULOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);

                conexao.Open();

                OracleDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    veiculos.Add(new Veiculo { Placa = leitor.GetString(0), Categoria = leitor.GetInt16(1) });
                }
            }



            return veiculos;
        }

        public List<Veiculo> retornarVeiculosV2()
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            using (var conexao = new OracleConnection(stringDeConexao))
            {

                OracleCommand comando = new OracleCommand();
                comando.Connection = conexao;
                comando.CommandText = "SELECT PLACA,CATEGORIA FROM TBVEICULO";
                //comando.Parameters.Add("@P1", OracleDbType.Varchar2, System.Data.ParameterDirection.Input);

                conexao.Open();

                OracleDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    veiculos.Add(new Veiculo { Placa = leitor.GetString(0), Categoria = leitor.GetInt16(1) });
                }
            }

            return veiculos;
        }

        //Inserir veiculo
        public bool inserirVeiculo(Veiculo veiculo)
        {

            using (var conexao = new OracleConnection(stringDeConexao))
            {

                OracleCommand comando = new OracleCommand();
                comando.Connection = conexao;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERIRVEICULO";
                comando.Parameters.Add("PLACA", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = veiculo.Placa;
                comando.Parameters.Add("CATEGORIA", OracleDbType.Int16, System.Data.ParameterDirection.Input).Value = veiculo.Categoria;

                conexao.Open();

                comando.ExecuteNonQuery();

            }

            return true;

        }

    }
}
