using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleResponsibility.SeguindoPrincipio
{
    class TransmissaoRepositorio
    {
        private ConversorTransmissao conversor;
        private ControladorEmail controladorEmail;

        public TransmissaoRepositorio()
        {
            conversor = new ConversorTransmissao();
            controladorEmail = new ControladorEmail();
        }

        public IEnumerable<Transmissao> ListarTransmissoes()
        {
            try
            {
                var transmissoesXml = LerDoXml();
                return conversor.Converter(transmissoesXml);
            }
            catch (Exception ex)
            {
                controladorEmail.EnviarErro(ex);
            }

            return Enumerable.Empty<Transmissao>();
        }

        private IEnumerable<TransmissaoXml> LerDoXml()
        {
            //Faz de conta que está lendo do xml...
            yield return new TransmissaoXml { CodigoTransmissao = 1, NomeTransmissao = "Teste 1", Pasta = @"c:\temp\" };
            yield return new TransmissaoXml { CodigoTransmissao = 2, NomeTransmissao = "Teste 2", Pasta = @"c:\temp\joba" };
        }
    }
}
