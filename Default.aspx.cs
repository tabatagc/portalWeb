using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.Adapters;
using Portal_MVC.Modelo;


namespace Portal_MVC
{

    public partial class _Default : System.Web.UI.Page
    {

        private DAO d;


        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DAO();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id_func =  int.Parse(txtCodigo.Text.ToString());
            Funcionario f = d.buscaFuncionarioId(id_func);
       
            if (f != null){
            // encontrou funcionário e mostra os dados;
                txtNome.Text = f.Nome;
                txtIdade.Text = f.Idade.ToString();
                txtMatricula.Text = f.Matricula;
                txtCargo.Text = f.Cargo;
                txtSalario.Text = f.Salario.ToString();
                txtDataNascimento.Text = f.DataNasc;

                txtNome.Enabled = true;
                txtIdade.Enabled = true;
                txtMatricula.Enabled = true;
                txtCargo.Enabled = true;
                txtSalario.Enabled = true;
                txtDataNascimento.Enabled = true;

                btnBuscar.Enabled = false;
                btnCancelar.Enabled = false;

                btnAlterar.Enabled = true;
                btnLimpar.Enabled = true;
                btnSalvar.Enabled = true;
                
                

            }else{
            
            }
        
        }

        
    }
 }