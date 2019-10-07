using Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class Login : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btCadastra_Click(object sender, EventArgs e)
        {
            Armazena armazena = new Armazena();


            if (armazena.ler(txtNome.Text, txtSenha.Text))
            {
                Response.Write("logou");
            }
            else
            {
                Response.Write("nao logou");
            }
                
        }
    }
}