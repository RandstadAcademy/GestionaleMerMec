using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GestionaleMerMec
{
    class GestioneConnessioneDB
    {

        public SqlConnection ApriConnnessione(string strIdIstanza, string strNomeDB, string strUserName, string strPassword, ref string strError)
        {
            string strConnect = null;
            SqlConnection objConnect = default(SqlConnection);

            strError = "";
            strConnect = "Data Source= " + strIdIstanza + ";Initial Catalog= " + strNomeDB + ";User ID= " + strUserName + "; password = " + strPassword + ";";

            try
            {

                objConnect = new SqlConnection(strConnect);
                objConnect.Open();
            }
            catch (SqlException ex)
            {
                strError = ex.Message;
                objConnect = null;
            }

            return objConnect;

        }

        public void ChiudiConnessione(SqlConnection objConnect, ref string strError)
        {
            strError = "";
            try
            {
                if (objConnect.State == ConnectionState.Open)
                {
                    objConnect.Close();
                }
            }
            catch (SqlException ex)
            {
                strError = ex.Message;
            }

        }


    }
}
