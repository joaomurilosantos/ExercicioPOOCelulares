using System;

namespace Smartphones
{
    public class Program
    {
        public static void Main()
        {
            int escolha;
            do
            {
                Console.WriteLine("==================");
                Console.WriteLine("  Cadastro Celular");
                Console.WriteLine("==================");
                Console.WriteLine();
                Console.WriteLine("==================");
                Console.WriteLine("  1 - Iphone\n  2 - Motorola\n  0 - Sair");

                escolha = Funcoes.EscolhaMenu();

                switch (escolha)
                {
                    case 0:
                        Console.WriteLine("Fechando programa");
                        break;
                    case 1:
                        Iphone iphone = new Iphone(Funcoes.RecebeTelefone(), Funcoes.RecebeModelo(), Funcoes.RecebeIMEI(), Funcoes.RecebeMemoria());
                        Funcoes.FuncoesIphone(iphone);
                        break;
                    case 2:
                        Motorola motorola = new Motorola(Funcoes.RecebeTelefone(), Funcoes.RecebeModelo(), Funcoes.RecebeIMEI(), Funcoes.RecebeMemoria());
                        Funcoes.FuncoesMotorola(motorola);
                        break;
                }
            } while (escolha != 0);
                             
        }
    }    
}