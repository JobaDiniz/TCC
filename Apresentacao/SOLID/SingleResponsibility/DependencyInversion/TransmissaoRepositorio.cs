using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleResponsibility.DependencyInversion
{
    class TransmissaoRepositorio
    {
        private IConversorTransmissao conversor;
        private IControladorEmail controladorEmail;

        public TransmissaoRepositorio(IConversorTransmissao conversor, IControladorEmail controladorEmail)
        {
            this.conversor = conversor;
            this.controladorEmail = controladorEmail;
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
