using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GestionaleMerMec
{
    class GestioneCliente
    {

        private string nome;
        private string cognome;
        private string indirizzo;
        private decimal fido;
        private int idcategoria;


        public GestioneCliente (string p_nome, string p_cognome,string p_indirizzo, decimal p_fido,int p_idcategoria)
        {

            nome = p_nome;
            cognome = p_cognome;
            indirizzo = p_indirizzo;
            fido = p_fido;
            idcategoria = p_idcategoria;


        }



        public void InserisciCliente_ADO()
        {
            SqlConnection con;
            string errore=null;
            string query;
            SqlParameter paramentro;
            SqlParameter[] arr_parametri= new SqlParameter[5];


            GestioneQueryDB gest_query = new GestioneQueryDB();

            GestioneConnessioneDB gestcon = new GestioneConnessioneDB();

            con=gestcon.ApriConnnessione("GIOSEF-PC\\SQLEXPRESS","DBMASTER.MDF","pippo","pippo",ref errore);

            if (errore!=null)
            {



            }

            else
            {


                query = "INSERT INTO Cliente (IdCliente) VALUES (@Idcliente) ";

                paramentro = new SqlParameter();

                paramentro.DbType = DbType.Int32;
                paramentro.ParameterName = "Idcliente";
                paramentro.Value = this.idcategoria;
                arr_parametri[0] = paramentro;

               

                gest_query.EseguiComando(con, query, arr_parametri, ref errore);

                gestcon.ChiudiConnessione(con, ref errore);




            }




        }


        public void InserimentoCliente_DataSet()

        {

            DatasetCategorieClienteTableAdapters.ClienteTableAdapter cliente=new DatasetCategorieClienteTableAdapters.ClienteTableAdapter;


            cliente.Insert(this.idcategoria,this.nome,this.cognome,this.indirizzo);







        }
    }
}
