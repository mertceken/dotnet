using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _190620_Web_Servis_Deneme
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public Bilgiler BilgileriGetir(int ID)
        {
            Bilgiler bilgilerimiz = new Bilgiler();

            string cs = ConfigurationManager.ConnectionStrings["DBBaglan"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Sp_BilgileriGetir", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = ID;

                cmd.Parameters.Add(param);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bilgilerimiz.ID = Convert.ToInt32(dr["ID"]);
                    bilgilerimiz.Adi = dr["Adi"].ToString();
                    bilgilerimiz.Soyadi = dr["Soyadi"].ToString();

                }
                

            }
            return bilgilerimiz;
        }
    }
}
