using System;
using System.Net.Mail;

namespace SingleResponsibility.DependencyInversion
{
    class ControladorEmail : IControladorEmail
    {
        public void EnviarErro(Exception ex)
        {
            var smtpClient = new SmtpClient();
            var email = new MailMessage("joba@joba.com", "erros@webcasters.com.br", "Erro", ex.ToString());

            smtpClient.Send(email);
        }
    }
}
