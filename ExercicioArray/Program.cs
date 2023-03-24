namespace ExercicioArray
{
    internal class Program
    {
        public static void EncontraMaiorValor(int[] v)
        {
            int maiorValor = int.MinValue;
            for (int i = 0; i < v.Length; i++) 
            {
                if (v[i] > maiorValor)
                    maiorValor = v[i];
            }
            Console.WriteLine("Maior valor: " + maiorValor);
        }

        public static void EncontraMenorValor(int[] v)
        {
            int menorValor = int.MaxValue;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < menorValor)
                    menorValor = v[i];
            }
            Console.WriteLine("Menor valor: " + menorValor);
        }
        public static void EncontraValorMedio(int[] v){
            int soma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                soma += v[i];
            }
            soma = soma / v.Length;
            Console.WriteLine("Valor Médio: " + soma);
        }
        public static void Encontra3Maiores(int[] v)
        {
            int a = int.MinValue, b = int.MinValue, c = int.MinValue;
            for (int i = 0; i < v.Length; i++)
            {
                if(a < v[i])
                {
                    c = b;
                    b = a;
                    a = v[i];
                }
                else if(b < v[i]) 
                {
                    c = b;
                    b = v[i];
                }
                else if(c < v[i])
                {
                    c = v[i];
                }
                
            }
        }

        public static void EncontraNegativos(int[] v)
        {
            Console.Write("Valores Negativos: ");
            for (int i = 0;i < v.Length;i++)
            {
                if (v[i] < 0)
                {
                    Console.Write($"{v[i]}; ");
                }
            }
            Console.WriteLine();
        }

        public static void MostraSequencia(int[] v)
        {
            Console.Write("Valores da Sequência: ");
            for (int i = 0; i < v.Length ; i++) 
            {
                Console.Write($"{v[i]}; ");
            }
            Console.WriteLine();
        }

        public static void RemoverItem(int[] v)
        {
            int p = 0;
            Console.Write("Escolha uma posição para excluir: ");
            p = Convert.ToInt32(Console.ReadLine());
            while (p < 0 && p > v.Length)
                Console.Write($"Escolha uma posição válida entre {0} e {v.Length-1}: ");
            Console.Write("Nova Sequência: ");
            for (int i = 0; i < v.Length; i++)
                if (i != p)
                    Console.Write($"{v[i]}; ");
            
        }

        static void Main(string[] args)
        {
            int[] vetor = {-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6};
            EncontraMaiorValor(vetor);
            EncontraMenorValor(vetor);
            EncontraValorMedio(vetor);
            Encontra3Maiores(vetor);
            EncontraNegativos(vetor);
            MostraSequencia(vetor);
            RemoverItem(vetor);
        }
    }
}