using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphones
{
    public static class Funcoes
    {
        public static int EscolhaMenu()
        {
            int escolha;
            bool sucesso;
            do
            {
                do
                {
                    Console.Write("Selecione uma das opcoes acima: ");
                    sucesso = int.TryParse(Console.ReadLine(), out escolha);
                } while (!sucesso);
            } while (escolha < 0 || escolha > 2);

            return escolha;
        }

        public static long RecebeTelefone()
        {
            long num;
            bool sucesso = false;
            do
            {
                Console.Write("  Número de celular: ");
                sucesso = long.TryParse(Console.ReadLine(), out num);
                if (!sucesso)
                {
                    Console.WriteLine("  Utilize apenas algarismos.");
                    Thread.Sleep(2000);
                    Console.Clear();

                }
                else if (num < 900000000 || num > 999999999)
                {
                    Console.WriteLine("  Número de celular inexistente.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    sucesso = false;
                }
            } while (!sucesso);

            return num;
        }

        public static string RecebeModelo()
        {
            Console.Write("  Modelo do aparelho: ");
            return Console.ReadLine();
        }

        public static long RecebeIMEI()
        {
            long num;
            bool sucesso = false;
            do
            {
                Console.Write("  Número do IMEI: ");
                sucesso = long.TryParse(Console.ReadLine(), out num);
                if (!sucesso)
                {
                    Console.WriteLine("  Utilize apenas algarismos.");
                    Thread.Sleep(2000);
                    Console.Clear();

                }
                else if (num < 1000000000000000 || num > 999999999999999)
                {
                    Console.WriteLine("  Número de IMEI deve ter 15 algarismos.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    sucesso = false;
                }
            } while (!sucesso);

            return num;

        }

        public static void FuncoesIphone( Iphone iphone)
        {
            int escolha;
            bool sucesso = false;
            do
            {
                do
                {
                    Console.WriteLine("  IPHONE");
                    Console.WriteLine("  1 - Informações\n  2 - Ligar para um numero\n  3 - Receber Ligacao\n  4 - Instalar App\n  0 - voltar ao menu inicial");
                    Console.Write("  Selecione uma das opcoes acima: ");
                    sucesso = int.TryParse(Console.ReadLine(), out escolha);
                    if (!sucesso)
                    {
                        Console.WriteLine("  Utilize apenas algarismos.");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else if (escolha < 0 || escolha > 4)
                    {
                        Console.WriteLine("  Selecione apenas as posicoes acima.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        sucesso = false;
                    }
                } while (!sucesso);

                switch (escolha)
                {
                    case 0:
                        Console.WriteLine("  Voltando ao menu inicial.");
                        break;
                    case 1:
                        Console.WriteLine("  INFORMACOES DO CELULAR");
                        Console.WriteLine("  ======================");
                        Console.WriteLine("  Numero: " + iphone.numero);
                        Console.WriteLine("  Modelo: " + iphone.modelo);
                        Console.WriteLine("  IMEI: " + iphone.imei);
                        Console.WriteLine("  Memoria: " + iphone.memoria);

                        Console.WriteLine("Pressione qualquer tecla para voltar.");
                        Console.ReadKey();
                        break;
                    case 2:
                        iphone.Ligar(RecebeTelefone());
                        break;
                    case 3:
                        iphone.ReceberLigacao(RecebeTelefone());
                        break;
                    case 4:
                        Console.WriteLine("App para instalar: ");
                        iphone.InstalarApp(Console.ReadLine());
                        break;

                }
            } while (escolha != 0);          

        }

        public static void FuncoesMotorola(Motorola motorola)
        {
            int escolha;
            bool sucesso = false;
            do
            {
                do
                {
                    Console.WriteLine("  IPHONE");
                    Console.WriteLine("  1 - Informações\n  2 - Ligar para um numero\n  3 - Receber Ligacao\n  4 - Instalar App\n  0 - voltar ao menu inicial");
                    Console.Write("  Selecione uma das opcoes acima: ");
                    sucesso = int.TryParse(Console.ReadLine(), out escolha);
                    if (!sucesso)
                    {
                        Console.WriteLine("  Utilize apenas algarismos.");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else if (escolha < 0 || escolha > 4)
                    {
                        Console.WriteLine("  Selecione apenas as posicoes acima.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        sucesso = false;
                    }
                } while (!sucesso);

                switch (escolha)
                {
                    case 0:
                        Console.WriteLine("  Voltando ao menu inicial.");
                        break;
                    case 1:
                        Console.WriteLine("  INFORMACOES DO CELULAR");
                        Console.WriteLine("  ======================");
                        Console.WriteLine("  Numero: " + motorola.numero);
                        Console.WriteLine("  Modelo: " + motorola.modelo);
                        Console.WriteLine("  IMEI: " + motorola.imei);
                        Console.WriteLine("  Memoria: " + motorola.memoria);

                        Console.WriteLine("Pressione qualquer tecla para voltar.");
                        Console.ReadKey();
                        break;
                    case 2:
                        motorola.Ligar(RecebeTelefone());
                        break;
                    case 3:
                        motorola.ReceberLigacao(RecebeTelefone());
                        break;
                    case 4:
                        Console.WriteLine("App para instalar: ");
                        motorola.InstalarApp(Console.ReadLine());
                        break;

                }
            } while (escolha != 0);

        }
    }

}

