namespace TestesUnitarios.Desafio.Console.Services
{
    // Classe que contém métodos para realizar validações em strings
    public class ValidacoesString
    {
        // Retorna a quantidade de caracteres na string fornecida
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        // Verifica se uma substring específica está presente na string fornecida
        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        // Verifica se a string fornecida termina com uma substring específica
        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}
