using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SingleResponsibility.PrincipioQuebrado
{
    class TransmissaoRepositorio
    {
        public IEnumerable<Transmissao> ListarTransmissoes()
        {
            try
            {
                var transmissoesXml = LerDoXml();
                var transmissoes = new List<Transmissao>();
                foreach (var transmissaoXml in transmissoesXml)
                {
                    long espaco = 0;
                    var dir = new DirectoryInfo(transmissaoXml.Pasta);
                    if (!dir.Exists)
                        espaco = 0;

                    Parallel.ForEach(dir.EnumerateFiles("*.*", SearchOption.AllDirectories), file =>
                    {
                        espaco += file.Length;
                    });

                    var transmissao = new Transmissao { EspacoEmDiscoUsado = espaco };
                    transmissoes.Add(transmissao);
                }

                return transmissoes;
            }
            catch (Exception ex)
            {
                var smtpClient = new SmtpClient();
                var email = new MailMessage("joba@joba.com", "erros@webcasters.com.br", "Erro", ex.ToString());

                smtpClient.Send(email);
            }

            return null;
        }

        private IEnumerable<TransmissaoXml> LerDoXml()
        {
            //Faz de conta que está lendo do xml...
            yield return new TransmissaoXml { CodigoTransmissao = 1, NomeTransmissao = "Teste 1", Pasta = @"c:\temp\" };
            yield return new TransmissaoXml { CodigoTransmissao = 2, NomeTransmissao = "Teste 2", Pasta = @"c:\temp\joba" };
        }
    }
}
