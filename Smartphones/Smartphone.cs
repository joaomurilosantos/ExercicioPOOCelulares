using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Smartphones
{
    public abstract class Smartphone
    {
        public Smartphone(long numero, string modelo, long imei, int memoria)
        {
            bool numValido = false;
            
            this.numero = numero.ToString();
                                   
            this.modelo = modelo;

            this.imei = imei.ToString();

            this.memoria = memoria.ToString();
            
        }
        public string numero { get; set; }
        public string modelo { get; set; }
        public string imei { get; private set; }
        public string memoria { get; set; }

        public void Ligar(long numero)
        {
            Console.WriteLine("  ---------------");
            Console.WriteLine($"     {numero}");
            Console.WriteLine("  ---------------");
            Console.WriteLine("  Ligando...");
            Thread.Sleep(2000);
            Console.WriteLine("  Chamada realizada com sucesso.");
        }

        public void ReceberLigacao(long numero)
        {
            char atender;
            bool validacaoAtender = false;
            do
            {
                Console.WriteLine("  ---------------");
                Console.WriteLine($"     {numero}");
                Console.WriteLine("  ---------------");
                Console.Write("  Atender? s/n: ");
                atender = Console.ReadKey().KeyChar;
                if (atender == 's' || atender == 'S' || atender == 'n' || atender == 'N')
                {
                    validacaoAtender = true;
                }
                else
                {
                    Console.WriteLine("  Responda apenas com s/n.");
                    Console.Clear();
                }
            } while (!validacaoAtender);

            if(atender == 's' || atender == 'S')
            {
                Console.WriteLine("  Ligacao atendida...");
                Thread.Sleep(2000);
                Console.WriteLine("  Ligacao Realizada com sucesso.");
            }
            else
            {
                Console.WriteLine("  Ligacao recusada...");
            }
        }

        public virtual void InstalarApp(string nomeApp)
        {
            Console.WriteLine($"  Instalando {nomeApp}...");
            Thread.Sleep(2000);
            Console.Write($"{nomeApp} instalado");
        }
    }
}
