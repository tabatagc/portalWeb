using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;




namespace Portal_MVC.Modelo
{ 

    public class Conexao
    {
        public MySqlConnection con;
        public MySqlCommand sen;
        public MySqlDataReader rs;


        public Conexao()
        {
            con = new MySqlConnection("Data Source=localhost;Initial Catalog=world;Persist Security Info=True;User ID=root;Password=root");
        } 
    
     
     
    
    
    
    
    
    }




}