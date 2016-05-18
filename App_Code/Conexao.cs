using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;



namespace Portal_MVC.Modelo
{ 

    public class Conexao
    {
        public SqlConnection con;
        public SqlCommand sen;
        public SqlDataReader rs;


        public Conexao()
        {
            con = new SqlConnection("Data Source=localhost;Initial Catalog=world;Persist Security Info=True;User ID=root;Password=root");
        } 
    
     
     
    
    
    
    
    
    }




}