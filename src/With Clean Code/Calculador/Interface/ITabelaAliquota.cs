
namespace Calculador.Interface
{
    /// <summary>
    /// Representa uma tabela de alíquotas do desconto do INSS.
    /// </summary>
    public interface ITabelaAliquota
    {
        /// <summary>
        /// Calcula o desconto referente ao salário especificado.
        /// </summary>
        /// <param name="salario">O salário que se deseja calcular o desconto.</param>
        decimal CalcularDesconto(decimal salario);

        /// <summary>
        /// Verifica se a tabela pode calcular o desconto para o ano especificado.
        /// </summary>
        /// <param name="ano">O ano que se deseja calcular o desconto.</param>
        bool PodeCalcularParaOAno(int ano);
    }
}
