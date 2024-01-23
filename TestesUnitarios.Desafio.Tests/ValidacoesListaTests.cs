using System.Collections.Generic;
using TestesUnitarios.Desafio.Console.Services;
using Xunit;

// Cria uma classe que conterá todos os testes relacionados à classe ValidacoesLista.
public class ValidacoesListaTests
{
    // Instancia um objeto da classe ValidacoesLista para utilizá-lo nos testes.
    private ValidacoesLista _validacoes = new ValidacoesLista();

    // Testa se o método RemoverNumerosNegativos remove corretamente os números negativos de uma lista.
    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Prepara uma lista com números, incluindo alguns negativos.
        var lista = new List<int> { 5, -1, -8, 9 };
        // Define o resultado esperado após a remoção dos negativos.
        var resultadoEsperado = new List<int> { 5, 9 };

        // Executa o método a ser testado.
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Verifica se o resultado obtido é igual ao esperado.
        Assert.Equal(resultadoEsperado, resultado);
    }

    // Testa se o método ListaContemDeterminadoNumero identifica corretamente a presença de um número na lista.
    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Prepara uma lista com números, incluindo o número 9.
        var lista = new List<int> { 5, -1, -8, 9 };
        // Define o número a ser procurado na lista.
        var numeroParaProcurar = 9;

        // Executa o método a ser testado.
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Verifica se o resultado é verdadeiro, indicando que o número está presente na lista.
        Assert.True(resultado);
    }

    // Testa se o método ListaContemDeterminadoNumero identifica corretamente a ausência de um número na lista.
    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Prepara uma lista com números, excluindo o número 10.
        var lista = new List<int> { 5, -1, -8, 9 };
        // Define o número a ser procurado na lista.
        var numeroParaProcurar = 10;

        // Executa o método a ser testado.
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Verifica se o resultado é falso, indicando que o número não está presente na lista.
        Assert.False(resultado);
    }

    // Testa se o método MultiplicarNumerosLista multiplica corretamente todos os elementos da lista por um número dado.
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Prepara uma lista com números.
        var lista = new List<int> { 5, 7, 8, 9 };
        // Define o resultado esperado após a multiplicação por 2.
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

        // Executa o método a ser testado.
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Verifica se o resultado obtido é igual ao esperado.
        Assert.Equal(resultadoEsperado, resultado);
    }

    // Testa se o método RetornarMaiorNumeroLista identifica corretamente o maior número em uma lista.
    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Prepara uma lista com números, incluindo o número 9.
        var lista = new List<int> { 5, -1, -8, 9 };

        // Executa o método a ser testado.
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Verifica se o resultado obtido é igual ao maior número esperado.
        Assert.Equal(9, resultado);
    }

    // Testa se o método RetornarMenorNumeroLista identifica corretamente o menor número em uma lista.
    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Prepara uma lista com números, incluindo o número -8.
        var lista = new List<int> { 5, -1, -8, 9 };

        // Executa o método a ser testado.
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Verifica se o resultado obtido é igual ao menor número esperado.
        Assert.Equal(-8, resultado);
    }
}
