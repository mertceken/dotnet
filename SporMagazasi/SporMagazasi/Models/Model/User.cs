using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SporMagazasi.Models.Model
{
    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz.")]
        [Display(Name = "E-Mail")]
        public string EMail { get; set; }

        public string FullName { get; set; }

        public string BirthDay { get; set; }

        public string CityName { get; set; }

        public string CountyName { get; set; }

        public int UserType { get; set; }

        public bool RememberMe { get; set; }

        public bool IsValid(string _username, string _pwd)
        {
            string _sql = "Select UserName From User Where UserName='" + _username + "' And Password='" + _pwd + "'";
 
            SqlConnection cn = new SqlConnection("Data Source=KADERERDOGAN;Integrated Security=True;database=SporMagazam");
 
            cn.Open();
        SqlCommand cmd = new SqlCommand(_sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                return true;
            else
                return false;
 
        }
    }

       
    }
