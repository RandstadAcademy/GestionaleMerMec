using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GestionaleMerMec
{
    public class GestioneCliente
    {

        public int id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string fiscalCode { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public DateTime signUpDate { get; set; }
        public decimal fido { get; set; }
        public int idcategoria { get; set; }

        public GestioneCliente(string p_nome, string p_cognome, string p_fiscalCode,
            string p_email, string p_phoneNumber, DateTime p_signUpDate,
            decimal p_fido, int p_idcategoria)
        {
            nome = p_nome;
            cognome = p_cognome;
            fiscalCode = p_fiscalCode;
            email = p_email;
            phoneNumber = p_phoneNumber;
            signUpDate = p_signUpDate;
            fido = p_fido;
            idcategoria = p_idcategoria;
        }

        public void InserisciCliente_ADO()
        {
            SqlConnection con;
            string errore = null;
            string query;
            SqlParameter paramentro;
            SqlParameter[] arr_parametri = new SqlParameter[8];

            GestioneQueryDB gest_query = new GestioneQueryDB();

            GestioneConnessioneDB gestcon = new GestioneConnessioneDB();

            con = gestcon.ApriConnnessione("PC2219\\PCGENTILE", "E-commerce", "gioelegentile ", "123", ref errore);

            if (errore == null)
            {
            }

            else
            {
                query = @"
                    INSERT INTO Customers
                               ([Name]
                               ,[Surname]
                               ,[FiscalCode]
                               ,[CustomerCategoryId]
                               ,[Email]
                               ,[PhoneNumber]
                               ,[SignUpDate]
                               ,[Balance])
                         VALUES
                               (@Name
                               ,@Surname
                               ,@FiscalCode
                               ,@CustomerCategoryId
                               ,@Email
                               ,@PhoneNumber
                               ,@SignUpDate
                               ,@Balance)
                    ";

                paramentro = new SqlParameter();

                paramentro.DbType = DbType.Int32;
                paramentro.ParameterName = "CustomerCategoryId";
                paramentro.Value = this.idcategoria;

                arr_parametri[0] = paramentro;

                paramentro = new SqlParameter();

                paramentro.DbType = DbType.String;
                paramentro.ParameterName = "Name";
                paramentro.Value = this.nome;

                arr_parametri[1] = paramentro;

                paramentro = new SqlParameter();

                paramentro.DbType = DbType.String;
                paramentro.ParameterName = "Surname";
                paramentro.Value = this.cognome;

                arr_parametri[2] = paramentro;

                paramentro = new SqlParameter();

                paramentro.DbType = DbType.String;
                paramentro.ParameterName = "FiscalCode";
                paramentro.Value = this.fiscalCode;

                arr_parametri[3] = paramentro;

                paramentro = new SqlParameter();

                paramentro.DbType = DbType.String;
                paramentro.ParameterName = "Email";
                paramentro.Value = this.email;

                arr_parametri[4] = paramentro;

                paramentro = new SqlParameter();

                paramentro.DbType = DbType.String;
                paramentro.ParameterName = "PhoneNumber";
                paramentro.Value = this.phoneNumber;

                arr_parametri[5] = paramentro;

                paramentro = new SqlParameter();

                paramentro.DbType = DbType.Date;
                paramentro.ParameterName = "SignUpDate";
                paramentro.Value = this.signUpDate;

                arr_parametri[6] = paramentro;

                paramentro = new SqlParameter();

                paramentro.DbType = DbType.Decimal;
                paramentro.ParameterName = "Balance";
                paramentro.Value = this.fido;

                arr_parametri[7] = paramentro;

                gest_query.EseguiComando(con, query, arr_parametri, ref errore);

                gestcon.ChiudiConnessione(con, ref errore);
            }
        }


        public void InserimentoCliente_DataSet()

        {
            DataSetCustomersTableAdapters.CustomersTableAdapter cliente = new DataSetCustomersTableAdapters.CustomersTableAdapter();
            cliente.Insert(nome,  cognome,  fiscalCode,
             idcategoria, email,  phoneNumber, signUpDate,
             fido);
        }

        public void ModificaCliente_DataSet()

        {
            DataSetCustomersTableAdapters.CustomersTableAdapter cliente = new DataSetCustomersTableAdapters.CustomersTableAdapter();

            cliente.Update(nome,cognome,fiscalCode, idcategoria, email,phoneNumber,fido,id,id);
        }

    }
}
