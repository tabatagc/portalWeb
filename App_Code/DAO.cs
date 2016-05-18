using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Portal_MVC.Modelo
{ 
    public class DAO
    {

        private Conexao c;

        public DAO() {
            c = new Conexao();
        }
    
       /*CRUD*/
        public void cadastraFuncionario(Funcionario f) {

            String dataatual = DateTime.Now.ToShortDateString();

            String insert = "insert into tb_funcionario values('"+f.Id_Func+"','"+f.Nome+"','"+f.Idade+"','"+f.Matricula+"','"+f.Cargo+"',1,'"+f.DataNasc+"','"+dataatual+"')";
            executar(insert);
        
        }

        public Funcionario buscaFuncionarioId(int id) {
            Funcionario f = null;

            //Execute Reader() --> SqlDataReader --. C.RS

            c.con.Open();
            String select = "select * from tb_funcionario where id_funcionario='"+id+"'";
            c.sen = new SqlCommand(select, c.con);

            c.rs = c.sen.ExecuteReader();

            if(c.rs.Read()) {
                f = new Funcionario();
                f.Id_Func = int.Parse(c.rs[0].ToString());
                f.Nome = c.rs[1].ToString(); //f.Nome = c.rs.GetString(1);
                f.Idade = int.Parse(c.rs[2].ToString());
                f.Matricula = c.rs[3].ToString();
                f.Cargo = c.rs[4].ToString();
                f.Salario = double.Parse(c.rs[5].ToString());
                f.DataNasc = c.rs[6].ToString();
            }


            c.con.Close();

            return f;
        }

        public void atualizarFuncionario(Funcionario f) {

            String update = "update tb_funcionario set nome = '"+f.Nome+"', idade = '"+f.Idade+"', matricula = '"+f.Matricula+"', cargo = '"+f.Cargo+"', salario = '"+f.Salario+"', data_nasc='"+f.DataNasc+"' where id_funcionario = '"+ f.Id_Func + "' ";
            executar(update);       
        }

        public void deletarFuncionario(int id) {

            String delete = "delete from tb_funcionario where id_funcionario ='" + id + "'";
            executar(delete);
        }

        //Inserir, atualizar ou deletar
        private void executar(String sql) {
            c.con.Open();
            c.sen = new SqlCommand(sql, c.con);
            c.sen.ExecuteNonQuery();
            c.con.Close();
        
        }

    }


}