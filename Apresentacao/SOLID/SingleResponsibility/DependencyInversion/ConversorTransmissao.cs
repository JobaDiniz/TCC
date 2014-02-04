using System.Collections.Generic;

namespace SingleResponsibility.DependencyInversion
{
    class ConversorTransmissao : IConversorTransmissao
    {
        private IControladorDiscoRigido controlador;

        public ConversorTransmissao(IControladorDiscoRigido controlador)
        {
            this.controlador = controlador;
        }

        public IEnumerable<Transmissao> Converter(IEnumerable<TransmissaoXml> transmissoesXml)
        {
            var transmissoes = new List<Transmissao>();

            foreach (var transmissaoXml in transmissoesXml)
            {
                var transmissao = Converter(transmissaoXml);
                transmissoes.Add(transmissao);
            }

            return transmissoes;
        }

        private Transmissao Converter(TransmissaoXml transmissaoXml)
        {
            return new Transmissao
            {
                Codigo = transmissaoXml.CodigoTransmissao,
                Nome = transmissaoXml.NomeTransmissao,
                Pasta = transmissaoXml.Pasta,
                EspacoEmDiscoUsado = controlador.CalcularEspacoEmDiscoUsado(transmissaoXml.Pasta)
            };
        }
    }
}
