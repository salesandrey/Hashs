using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cadastro
{
    public partial class TelaCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNome.MaxLength = 4;
            txtSenha.MaxLength = 4;
        }

        protected void btCadastra_Click(object sender, EventArgs e)
        {
            mdFunction md5hash = new mdFunction();
            Armazena armazena = new Armazena();
            if(txtNome.Text.Length < 4 && txtSenha.Text.Length <4 )
            {
                Console.WriteLine("Os campos Nome e Senha deve ter 4 digidos");
            }
            else
            {
                string senhaHash = md5hash.getMD5hash(md5hash.getHas, txtSenha.Text);
                armazena.gravar(txtNome.Text,senhaHash);
                Response.Redirect("Login.aspx");
          
            }
        }
    }
}