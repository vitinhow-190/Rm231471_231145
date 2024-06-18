using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Rm231471_231145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("deseja iniciar? ");
            string resp = Console.ReadLine();

            while (resp == "s")
            {

                double saldo = 0;

                Console.WriteLine("Digite qual aplicação deseja efetuar: Depósito[D], Saque[S], Pagamento[P] ou Saldo[CS]");
                string ap = Console.ReadLine();

                apl(ap, saldo, resp);

                Console.ReadKey();
            }
        }
        static void apl(string ap, double saldo, string resp)
            {
                switch (ap)
                {
                    case "D":
                        Console.WriteLine("Quanto deseja depositar? ");
                        double di = double.Parse(Console.ReadLine());

                        saldo += di;

                        Console.WriteLine("Seu saldo é de: " + saldo);

                        Console.WriteLine("deseja continuar? ");
                        resp = Console.ReadLine();
                        break;

                    case "S":
                        Console.WriteLine("Quanto deseja sacar? ");
                        double saque = double.Parse(Console.ReadLine());

                        if (saldo > saque)
                        {
                            saldo -= saque;

                            Console.WriteLine("seu saque foi efetuado com sucesso. Saldo restante " + saldo);
                            Console.WriteLine("deseja continuar? ");
                            resp = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("não é possível efetuar o saque. Saldo insuficiente");
                            Console.WriteLine("deseja continuar? ");
                            resp = Console.ReadLine();
                        }
                        break;

                    case "P":
                        Console.WriteLine("Quanto deseja pagar? ");
                        double pagamento = double.Parse(Console.ReadLine());

                        if (saldo > pagamento)
                        {
                            saldo -= pagamento;

                            Console.WriteLine("seu pagamento foi efetuado com sucesso. Saldo restante " + saldo);
                            Console.WriteLine("deseja continuar? ");
                            resp = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("não é possível efetuar o pagamento. Saldo insuficiente");
                            Console.WriteLine("deseja continuar? ");
                            resp = Console.ReadLine();
                        }
                        break;

                    case "CS":
                        Console.WriteLine("seu saldo é: " + saldo);
                        Console.WriteLine("deseja continuar? ");
                        resp = Console.ReadLine();
                    break;

                    default:
                        Console.WriteLine("a opção é inválida.");
                        Console.WriteLine("deseja continuar? ");
                        resp = Console.ReadLine();
                    break;

                }
            
        }
            
    }   
}
