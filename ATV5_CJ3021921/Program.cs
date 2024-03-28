namespace ATV5_CJ3021921
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========MENU DO MARQUESITO========");

            Console.WriteLine("Digite 1 para o exercício 1");

            Console.WriteLine("Digite 2 para o exercício 2");

            Console.WriteLine("Digite 3 para o exercício 3");

            Console.WriteLine("Digite 4 para o exercício 4");

            Console.WriteLine("Digite 5 para o exercício 5");

            Console.WriteLine("Digite 6 para o exercício 6");

            Console.WriteLine("Digite 7 para o exercício 7");

            Console.WriteLine("Digite 0 para sair");

            Console.WriteLine("=====================================");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 0:

                    Console.WriteLine("obrigado por utilizar o programa");
                    break;

                case 1:

                    //1

                    int n, i;

                    Console.WriteLine("Digite um número:");
                    i = int.Parse(Console.ReadLine());


                    for (n = 1; n <= i; n++)
                    {




                        Console.WriteLine(n);
                    }


                    break;


                case 2:

                    int r, j;

                    Console.WriteLine("Digite um número:");
                    j = int.Parse(Console.ReadLine());


                    for (r = 1; r <= j; r++)
                    {
                        if (r % 2 == 0)
                        {
                            Console.WriteLine(r);


                        }
                    }

                    break;

                case 3:

                    int p3, l2;

                    Console.WriteLine("Digite um número até 1000:");
                    l2 = int.Parse(Console.ReadLine());

                    for (p3 = l2; p3 < 1000; p3++)
                    {
                        if (p3 % 2 == 0)
                        {
                            Console.WriteLine(p3);
                        }
                    }

                    break;

                case 4:

                    int x1;

                    int soma = 200;

                    Console.WriteLine("Digite um número");
                    x1 = int.Parse(Console.ReadLine());

                    for (x1 = 1; x1 < soma; x1++)
                    {
                        if (x1 < 0)
                        {
                            Console.WriteLine("número inválido");
                        }

                        else

                            Console.WriteLine(x1);
                    }

                    break;

                case 5:

                    int val1, n1;

                    Console.WriteLine("Digite um número:");
                    n1 = int.Parse(Console.ReadLine());

                    for (n1 = 0; n1 <= val1; n1++)
                    {
                        if (val1 % n1 == 0)
                        {
                            Console.WriteLine(n1);
                        }

                    }
                    break;


                case 6:

                    int n12, n22;

                    for (n12 = 0; n12 < 11; n12++)
                    {
                        Console.WriteLine("Digite um valor");
                        n22 = int.Parse(Console.ReadLine());

                        if (n22 < n22)
                        {
                            Console.WriteLine("o número maior é = {0}", n22);

                        }


                        if (n22 > n22)
                        {
                            Console.WriteLine("o número menor é = {0}", n22);
                        }


                    }

                    break;

                case 7:

                    int n7, h3;
                    int p1 = 0, g3 = 0;

                    for (n = 0; n < 10; n++)
                    {
                        Console.WriteLine("Digite um valor");
                        h3 = int.Parse(Console.ReadLine());

                        if (h3 <= 0)

                            break;

                        if (n7 % 2 != 0)
                        {
                            n7 = n7 + n7;
                        }

                        if (n7 % 2 == 0)
                        {
                            n7 = n7 + p1;
                        }
                        Console.WriteLine("soma dos números ímpares = {0}", g3, p3, "soma dos números pares {1}", p3);
                    }


                    break;

            }
        }
    }
}
        
    

