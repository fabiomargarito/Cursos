using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;


namespace JBSDAL
{

    public class Pessoa {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public DateTime DataNascimento { get; set; }
        

        public void Correr(int km,string cidade, double velocida) {

        }

        public string QualEhSeuNome() {
            return Nome;
        }
    }


    public class DALVEICULOS
    {
        public IList<VeiculoDTO> RetornarListaDeVeiculos() {
           
            string _conectionString = ConfigurationManager.ConnectionStrings["BDJBS"].ConnectionString;
            IList<VeiculoDTO> veiculos = new List<VeiculoDTO>();

            using (OracleConnection conexaoOracle = new OracleConnection(_conectionString)) {

                conexaoOracle.Open();

                OracleCommand comandoOracle = new OracleCommand();
                comandoOracle.Connection = conexaoOracle;
                comandoOracle.CommandType = System.Data.CommandType.StoredProcedure;
                comandoOracle.CommandText = "SP_RETORNARVEICULOS";
                comandoOracle.Parameters.Add("VEICULOS",OracleDbType.RefCursor,System.Data.ParameterDirection.Output);

                OracleDataReader leitor = comandoOracle.ExecuteReader();
                while (leitor.Read())
                {
                    veiculos.Add(new VeiculoDTO {Placa = leitor.GetString(0), Categoria = leitor.GetInt16(1) });
                }
            }

            return veiculos;

        }

        public bool InserirVeiculo(VeiculoDTO veiculo) {

            string _conectionString = ConfigurationManager.ConnectionStrings["BDJBS"].ConnectionString;

            using (OracleConnection conexaoOracle = new OracleConnection(_conectionString))
            {

                conexaoOracle.Open();

                OracleCommand comandoOracle = new OracleCommand();
                comandoOracle.Connection = conexaoOracle;
                comandoOracle.CommandType = System.Data.CommandType.StoredProcedure;
                comandoOracle.CommandText = "SP_INSERIRVEICULO";
                comandoOracle.Parameters.Add("PLACA", OracleDbType.Varchar2, System.Data.ParameterDirection.Input).Value = veiculo.Placa;
                comandoOracle.Parameters.Add("CATEGORIA", OracleDbType.Int16, System.Data.ParameterDirection.Input).Value = veiculo.Categoria;
                comandoOracle.ExecuteNonQuery();

                return true;
            }

        }
       
    }

    

}
