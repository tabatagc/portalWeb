using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Funcionario
/// </summary>
namespace Portal_MVC.Modelo
{
	public class Funcionario
	{

        private int id_func;

        public int Id_Func
        {
            get { return id_func; }
            set { id_func = value; }
        }
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        private String matricula;

        public String Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private String cargo;

        public String Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        private double salario;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        private String dataNasc;

        public String DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
	}
}