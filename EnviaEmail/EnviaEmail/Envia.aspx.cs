using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace EnviaEmail
{
    public partial class Envia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SmtpClient cliente = new SmtpClient();
cliente.Host = "smtp.gmail.com";
cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
cliente.EnableSsl = true;
cliente.Port = 587;

            System.Net.NetworkCredential credenciais = new NetworkCredential("igor.ffp@gmail.com", "senha");
cliente.Credentials = credenciais;

            MailMessage mail = new MailMessage();
mail.From = new MailAddress("igor.ffp@gmail.com");
mail.To.Add(new MailAddress(TextBox2.Text));
mail.Body = "Corpo do e-mail. Email enviado pelo formulário we";
cliente.Send(mail);
        }
    }
}