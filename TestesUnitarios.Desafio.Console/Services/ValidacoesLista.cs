namespace TestesUnitarios.Desafio.Console.Services
{
    // Classe que contém métodos para realizar validações em listas de números inteiros
    public class ValidacoesLista
    {
        // Remove números negativos da lista fornecida
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList();
        }

        // Verifica se um número específico está presente na lista
        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem;
        }

        // Multiplica todos os números na lista por um número dado
        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        // Retorna o maior número na lista
        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        // Retorna o menor número na lista
        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}
