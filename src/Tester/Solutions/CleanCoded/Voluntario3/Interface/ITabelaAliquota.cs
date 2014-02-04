
namespace Voluntario3.Interface
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
        /// Define o ano da tabela
        /// </summary>
        /// <returns>Ano da tabela</returns>
        int Ano();
    }
}
