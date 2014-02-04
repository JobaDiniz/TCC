using System;
using System.Net.Mail;

namespace SingleResponsibility.SeguindoPrincipio
{
    class ControladorEmail
    {
        public void EnviarErro(Exception ex)
        {
            var smtpClient = new SmtpClient();
            var email = new MailMessage("joba@joba.com", "erros@webcasters.com.br", "Erro", ex.ToString());

            smtpClient.Send(email);
        }
    }
}
