using TestesUnitarios.Desafio.Console.Services;
using Xunit;

// Cria uma classe que conterá todos os testes relacionados à classe ValidacoesString.
public class ValidacoesStringTests
{
    // Instancia um objeto da classe ValidacoesString para utilizá-lo nos testes.
    private ValidacoesString _validacoes = new ValidacoesString();

    // Testa se o método RetornarQuantidadeCaracteres retorna corretamente a quantidade de caracteres em uma palavra.
    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Arrange: Prepara uma palavra.
        var texto = "Matrix";
        // Define o resultado esperado, que é o número de caracteres na palavra "Matrix".
        var resultadoEsperado = 6;

        // Act: Executa o método a ser testado.
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert: Verifica se o resultado obtido é igual ao esperado.
        Assert.Equal(resultadoEsperado, resultado);
    }

    // Testa se o método ContemCaractere identifica corretamente a presença de uma palavra em um texto.
    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange: Prepara um texto e a palavra a ser procurada.
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Act: Executa o método a ser testado.
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert: Verifica se o resultado é verdadeiro, indicando que a palavra está presente no texto.
        Assert.True(resultado);
    }

    // Testa se o método ContemCaractere identifica corretamente a ausência de uma palavra em um texto.
    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange: Prepara um texto e a palavra a ser procurada.
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act: Executa o método a ser testado.
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert: Verifica se o resultado é falso, indicando que a palavra não está presente no texto.
        Assert.False(resultado);
    }

    // Testa se o método TextoTerminaCom identifica corretamente se um texto termina com uma palavra específica.
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange: Prepara um texto e a palavra a ser verificada no final do texto.
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act: Executa o método a ser testado.
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert: Verifica se o resultado é verdadeiro, indicando que o texto termina com a palavra desejada.
        Assert.True(resultado);
    }
}
