using System;

namespace TestesProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string digitado;
            bool menu = true;
            
            while (menu == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ MENU PRINCIPAL ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ ");
                Console.ResetColor();

                Console.WriteLine("\n * Selecione uma das Opções Abaixo: \n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 . Operações Artiméticas");
                Console.ResetColor();

                Console.WriteLine("\n * Insira apenas o número da opcão...\n");

                Console.Write("\nOpção: ");
                digitado = Console.ReadLine();

                switch (digitado)
                {
                    case "1":
                        MenuOperacoesArtimeticas();
                        break;
                }
            }
        }

        static void MenuOperacoesArtimeticas()
        {
            int OperacaoAritimetica;
            bool RealNumeroInteiro, MenuOperacoes = true;
            
            while (MenuOperacoes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n ►◄ ►◄ ►◄ ►◄ ►◄ OPERAÇÕES ARITIMÉTICAS ►◄ ►◄ ►◄ ►◄ ►◄ ");
                Console.ResetColor();

                Console.WriteLine("\n * Selecione uma operação artimética:\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 . Soma");
                Console.WriteLine("2 . Subtração");
                Console.WriteLine("3 . Multiplicação");
                Console.WriteLine("4 . Divisão");
                Console.WriteLine("5 . Exponenciação");
                Console.WriteLine("6 . Radiciação");
                Console.WriteLine();
                Console.WriteLine("7 . Retornar ao menu");
                Console.WriteLine("8 . Fechar o programa");
                Console.ResetColor();

                Console.WriteLine("\n * Insira apenas o número da opcão...\n");

                Console.Write("\nOpção: ");
                RealNumeroInteiro = Int32.TryParse(Console.ReadLine(), out OperacaoAritimetica);

                if (RealNumeroInteiro)
                {
                    if (OperacaoAritimetica > 0 & OperacaoAritimetica < 9)
                    {
                        switch (OperacaoAritimetica)
                            {
                                case 1:
                                    Soma();
                                    break;
                                case 2:
                                    Subtracao();
                                    break;
                                case 3:
                                    Multiplicacao();
                                    break;
                                case 4:
                                    Divisao();
                                    break;
                                case 5:
                                    Exponenciacao();
                                    break;
                                case 6:
                                    Radiciacao();
                                    break;
                                case 7:
                                    MenuOperacoes = false;
                                    RetornarAoMenu();
                                    break;
                                case 8:
                                    FecharPrograma();
                                    break;


                            }
                    }
                    else
                    {
                        ErroOpcaoIndisponivelNoMenuAtual();
                    }
                }
                else
                {
                    ErroNumeroNaoInteiro();
                }
            }

        }

        static void Soma()
        {
            int QuantidadeDeNumeros, ContadorSoma = 0;
            bool RealQuantidadeDeNumeros, RealNumeroDigitado;
            double NumeroDigitado, Soma = 0;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ SOMA ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ ");
            Console.ResetColor();

            Console.Write("\n * Quantos números a serem somados: ");
            RealQuantidadeDeNumeros = Int32.TryParse(Console.ReadLine(), out QuantidadeDeNumeros);

            if (QuantidadeDeNumeros < 0)
            {
                RealQuantidadeDeNumeros = false;
            }

            if (RealQuantidadeDeNumeros)
            {
                Console.WriteLine();
                while (ContadorSoma < QuantidadeDeNumeros)
                {
                    ContadorSoma += 1;
                    Console.Write($" * Número {ContadorSoma}: ");
                    RealNumeroDigitado = Double.TryParse(Console.ReadLine(), out NumeroDigitado);

                    if (RealNumeroDigitado)
                    {
                        Soma += NumeroDigitado;
                    }
                    else
                    {
                        ErroNumeroNaoReal();
                        ContadorSoma -= 1;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n * O resultado da soma é..: {Soma}");
                Console.ResetColor();

                Console.WriteLine($" * Precione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }
            else
            {
                if (QuantidadeDeNumeros < 0)
                {
                    ErroNumeroNegativo();
                }
                else
                {
                    ErroNumeroNaoInteiro();
                }
            }
        }

        static void Subtracao()
        {
            int QuantidadeDeNumeros, ContadorSubtracao = 0;
            bool RealQuantidadeDeNumeros, RealNumeroDigitado;
            double NumeroDigitado, Subtracao = 0;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ SUBTRAÇÃO ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ ");
            Console.ResetColor();

            Console.Write("\n * Quantos números a serem subtraidos: ");
            RealQuantidadeDeNumeros = Int32.TryParse(Console.ReadLine(), out QuantidadeDeNumeros);

            if (QuantidadeDeNumeros < 0)
            {
                RealQuantidadeDeNumeros = false;
            }

            if (RealQuantidadeDeNumeros)
            {
                Console.WriteLine();
                while (ContadorSubtracao < QuantidadeDeNumeros)
                {
                    ContadorSubtracao += 1;
                    Console.Write($" * Número {ContadorSubtracao}: ");
                    RealNumeroDigitado = Double.TryParse(Console.ReadLine(), out NumeroDigitado);

                    if (RealNumeroDigitado)
                    {
                        if (ContadorSubtracao == 1)
                        {
                            Subtracao = NumeroDigitado;
                        }
                        else
                        {
                            Subtracao -= NumeroDigitado;
                        }
                    }
                    else
                    {
                        ErroNumeroNaoReal();
                        ContadorSubtracao -= 1;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n * O resultado da subtração é..: {Subtracao}");
                Console.ResetColor();

                Console.WriteLine($" * Precione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }
            else
            {
                if (QuantidadeDeNumeros < 0)
                {
                    ErroNumeroNegativo();
                }
                else
                {
                    ErroNumeroNaoInteiro();
                }
            }
        }

        static void Multiplicacao()
        {
            int QuantidadeDeNumeros, ContadorMultiplicacao = 0;
            bool RealQuantidadeDeNumeros, RealNumeroDigitado;
            double NumeroDigitado, Multiplicacao = 0;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ MULTIPLICAÇÃO ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ ");
            Console.ResetColor();
            
            Console.Write("\n * Quantos números a serem multiplicados: ");
            RealQuantidadeDeNumeros = Int32.TryParse(Console.ReadLine(), out QuantidadeDeNumeros);

            if (QuantidadeDeNumeros < 0)
            {
                RealQuantidadeDeNumeros = false;
            }

            if (RealQuantidadeDeNumeros)
            {
                Console.WriteLine();
                while (ContadorMultiplicacao < QuantidadeDeNumeros)
                {
                    ContadorMultiplicacao += 1;
                    Console.Write($" * Número {ContadorMultiplicacao}: ");
                    RealNumeroDigitado = Double.TryParse(Console.ReadLine(), out NumeroDigitado);

                    if (RealNumeroDigitado)
                    {
                        if (ContadorMultiplicacao == 1)
                        {
                            Multiplicacao = NumeroDigitado;
                        }
                        else
                        {
                            Multiplicacao *= NumeroDigitado;
                        }
                    }
                    else
                    {
                        ErroNumeroNaoReal();
                        ContadorMultiplicacao -= 1;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n * O resultado da multilpicação é..: {Multiplicacao}");
                Console.ResetColor();

                Console.WriteLine($" * Precione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }
            else
            {
                if (QuantidadeDeNumeros < 0)
                {
                    ErroNumeroNegativo();
                }
                else
                {
                    ErroNumeroNaoInteiro();
                }
            }
        }

        static void Divisao()
        {
            double Divisao, Dividendo = 0, Divisor = 0;
            bool RealDividendo, RealDivisor, NumeroRealDividendo = true, NumeroRealDivisor = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ DIVISÃO ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ ");
            Console.ResetColor();

            Console.WriteLine("\n * Insira os valores para efetuar a operação...");

            while (NumeroRealDividendo)
            {
                Console.Write("\n * Número a ser Dividido.....: ");
                RealDividendo = Double.TryParse(Console.ReadLine(), out Dividendo);

                if (!RealDividendo)
                {
                    ErroNumeroNaoReal();
                }
                else
                {
                    NumeroRealDividendo = false;
                }
            }
            while (NumeroRealDivisor)
            {
                Console.Write(" * Número Divisor............: ");
                RealDivisor = Double.TryParse(Console.ReadLine(), out Divisor);

                if (!RealDivisor)
                {
                    ErroNumeroNaoReal();
                }
                else 
                {
                    NumeroRealDivisor = false;
                }
            }
            Divisao = Dividendo / Divisor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n * O resultado da divisão é..: {Divisao:N2}");
            Console.ResetColor();

            Console.WriteLine($" * Precione qualquer tecla para continuar...\n");
            Console.ReadKey();
        }

        static void Exponenciacao()
        {
            double Potencia, Base = 0, Expoente = 0;
            bool RealBase, RealExpoente, NumeroRealBase = true, NumeroRealExpoente = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ EXPONENCIAÇÃO ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ ");
            Console.ResetColor();

            Console.WriteLine("\n * Insira os valores para efetuar a operação...");

            while (NumeroRealBase)
            {
                Console.Write("\n * Insira o número Base.....: ");
                RealBase = Double.TryParse(Console.ReadLine(), out Base);

                if (!RealBase)
                {
                    ErroNumeroNaoReal();
                }
                else
                {
                    NumeroRealBase = false;
                }
            }
            while (NumeroRealExpoente)
            {
                Console.Write(" * Insira o Expoente........: ");
                RealExpoente = Double.TryParse(Console.ReadLine(), out Expoente);

                if (!RealExpoente)
                {
                    ErroNumeroNaoReal();
                }
                else 
                {
                    NumeroRealExpoente = false;
                }
            }
            Potencia = Math.Pow(Base, Expoente);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n * O resultado da potenciação é..: {Potencia}");
            Console.ResetColor();

            Console.WriteLine($" * Precione qualquer tecla para continuar...\n");
            Console.ReadKey();
        }

        static void Radiciacao()
        {
            double Raiz, Radicando = 0;
            bool RealRadicando, NumeroRealRadicando = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ RADICIAÇÃO ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ ");
            Console.ResetColor();

            Console.WriteLine("\n * Insira o valor para calcular a raiz quadrada...");

            while (NumeroRealRadicando)
            {
                Console.Write("\n * Insira o Radicando........: ");
                RealRadicando = Double.TryParse(Console.ReadLine(), out Radicando);

                if (Radicando < 0)
                {
                    ErroNumeroNegativo();
                    NumeroRealRadicando = false;
                }
                else 
                {
                    if (!RealRadicando)
                    {
                        ErroNumeroNaoReal();
                    }
                    else
                    {
                        NumeroRealRadicando = false;
                    }
                }
            }
            if (Radicando >= 0)
            {
                Raiz = Math.Sqrt(Radicando);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n * A raiz quadrada é..: {Raiz}");
                Console.ResetColor();

                Console.WriteLine($" * Precione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }
        }

        static void RetornarAoMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n * Selecionado 'Retornar ao menu', precione");
            Console.WriteLine("   qualquer tecla para continuar...\n");
            Console.ResetColor();
            Console.ReadKey();
        }

        static void FecharPrograma()
        {
            int DesejaMesmoFechar;
            bool RealDesejaMesmoFechar, MenuFechar = true;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ MENU DE ENCERRAMENTO ►◄ ►◄ ►◄ ►◄ ►◄ ►◄ ");
            Console.ResetColor();

            Console.WriteLine("\n * Você está prestes a Fechar o Programa'!");
            
            while (MenuFechar)
            {
                Console.WriteLine(" * Deseja mesmo continuar?...\n");

                Console.WriteLine("1 . SIM");
                Console.WriteLine("2 . NÃO\n");

                Console.Write("\nOpção: ");

                RealDesejaMesmoFechar = Int32.TryParse(Console.ReadLine(), out DesejaMesmoFechar);
                
                if (RealDesejaMesmoFechar)
                {
                    if (DesejaMesmoFechar == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n * Muito obrigado por usar o programa!\n");
                        Console.ResetColor();
                        Environment.Exit(-1);
                    }
                    if (DesejaMesmoFechar == 2)
                    {
                        MenuFechar = false;
                    }
                    if (DesejaMesmoFechar < 1 || DesejaMesmoFechar > 2)
                    {
                        ErroOpcaoIndisponivelNoMenuAtual();
                    }
                }
                else
                {
                    ErroNumeroNaoInteiro();
                }
            }
        }

        static void ErroNumeroNaoInteiro()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n * O valor inserido, não é um número inteiro!\n");
            Console.ResetColor();
        }

        static void ErroOpcaoIndisponivelNoMenuAtual()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n * Essa opção não se encontra disponível!\n");
            Console.ResetColor();
        }

        static void ErroNumeroNaoReal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n * O valor inserido, não é um número real!\n");
            Console.ResetColor();
        }

        static void ErroNumeroNegativo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n * O valor inserido, não pode ser um número negativo!\n");
            Console.ResetColor();
        }
    }
}
