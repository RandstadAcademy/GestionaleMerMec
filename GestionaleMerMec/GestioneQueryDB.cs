using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GestionaleMerMec
{
    class GestioneQueryDB
    {
        public DataTable EseguiQuery(out string strError, SqlConnection objConnect, string strSQL, SqlParameter[] vntPar = null)
        {
            SqlCommand objCommand = new SqlCommand();
            //Esegue i comandi sul DB
            DataTable objDtQuery = new DataTable();
            SqlDataAdapter objdaQuery = new SqlDataAdapter();
            //Riempie il datable
            int intIndice = 0;

            strError = "";


            try
            {
                objCommand.Connection = objConnect;
                objCommand.CommandText = strSQL;
                objdaQuery.SelectCommand = objCommand;

                if ((vntPar != null))
                {
                    for (intIndice = 0; intIndice <= vntPar.Length - 1; intIndice++)
                    {
                        objdaQuery.SelectCommand.Parameters.Add(vntPar[intIndice]);
                    }

                }
                objdaQuery.SelectCommand.CommandTimeout = 1000000000;
                objdaQuery.Fill(objDtQuery);


            }
            catch (Exception ex)
            {
                strError = ex.Message;
            }

            return objDtQuery;

        }


        public void EseguiComando(SqlConnection objConnect, string strSQL, SqlParameter[] vntPar, ref string strError)
        {
            SqlCommand objCommand = new SqlCommand();
            //Esegue i comandi sul DB
            int intIndice = 0;

            strError = "";


            try
            {
                objCommand.Connection = objConnect;
                objCommand.CommandText = strSQL;
                if ((vntPar != null))
                {
                    for (intIndice = 0; intIndice <= vntPar.Length - 1; intIndice++)
                    {
                        objCommand.Parameters.Add(vntPar[intIndice]);
                    }
                }

                objCommand.CommandTimeout = 1000000000;

                objCommand.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                strError = ex.Message;
            }



        }




    }
}
