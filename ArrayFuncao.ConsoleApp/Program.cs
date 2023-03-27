namespace ArrayFuncao.ConsoleApp
{
    internal class Program
    {

        public static void Main()
        {

            double[] numeros = new double[11];

            MostrarTitulo();


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite o " + i + "º valor da sequência");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }

            do
            {
                Console.Clear();

                int operacao = MostrarMenu();

                switch (operacao)
                {
                    case 1:

                        EncontrarMaiorValor(numeros);

                        break;

                    case 2:

                        EncontrarMenorValor(numeros);

                        break;

                    case 3:

                        EncontrarMediaValores(numeros);

                        break;

                    case 4:

                        Encontrar3MaioresValores(numeros);

                        break;

                    case 5:

                        EncontrarValoresNegativos(numeros);


                        break;

                    case 6:

                        MostrarSequenciaNaTela(numeros);

                        break;

                    case 7:

                        RemoverItem(numeros);

                        break;



                }

            }
            while (true);

            static void MostrarTitulo()
            {
                Console.WriteLine("Arrays, Funções e Programação Estruturada");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
            }

            static int MostrarMenu()
            {

                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("--------------------------");
                Console.WriteLine();

                Console.WriteLine("(1) Encontrar o Maior Valor da sequência");
                Console.WriteLine("(2) Encontrar o Menor Valor da sequência");
                Console.WriteLine("(3) Encontrar o Valor Médio da sequência");
                Console.WriteLine("(4) Encontrar os 3 maiores valores da sequência");
                Console.WriteLine("(5) Encontrar os valores negativos da sequência");
                Console.WriteLine("(6) Mostrar na Tela os valores da sequência");
                Console.WriteLine("(7) Remover um item da sequência");

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();

                int operacao = Convert.ToInt32(Console.ReadLine());

                return operacao;

            }

            static void EncontrarMaiorValor(double[] numeros)
            {
                Array.Sort(numeros);
                double maiorValor = numeros[9];

                Console.WriteLine("O maior valor é: " + maiorValor);

                Console.ReadLine();

            }

            static void EncontrarMenorValor(double[] numeros)
            {
                Array.Sort(numeros);
                double menorValor = numeros[0];

                Console.WriteLine("O menor valor é: " + menorValor);

                Console.ReadLine();

            }

            static void EncontrarMediaValores(double[] numeros)
            {
                double soma = 0;

                for (int i = 1; i <= 10; i++)
                {
                    soma += numeros[i];

                }

                Console.Write("A média dos valores é igual a: " + soma);
            }

            static void Encontrar3MaioresValores(double[] numeros)
            {
                Array.Sort(numeros);

                Console.WriteLine("O maior valor é: " + numeros[9]);
                Console.WriteLine("O segundo maior valor é: " + numeros[8]);
                Console.WriteLine("O terceiro maior valor é: " + numeros[7]);

                Console.ReadLine();

            }

            static void EncontrarValoresNegativos(double[] numeros)
            {
                Console.Write("Os números negativos são: ");

                for (int i = 1; i <= 10; i++)
                {
                    if (numeros[i] < 0)
                    {
                        Console.Write(numeros[i] + ", ");
                    }
                }

                Console.ReadLine();

            }

            static void MostrarSequenciaNaTela(double[] numeros)
            {

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(numeros[i] + ", ");

                }

                Console.ReadLine();

            }

            static void RemoverItem(double[] numeros)
            {
                Console.WriteLine("Qual valor deve ser removido da sequencia?");
                int remover = Convert.ToInt32(Console.ReadLine());

                numeros[remover] = 0;

            }

        }

    }

}
