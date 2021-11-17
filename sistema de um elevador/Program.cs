using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_um_elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            elevador e = new elevador(20,10,0,0);
            pessoa p = new pessoa();
            do
            {
                menu = e.Menu();
                e.entrar(menu);
                e.escolherAndar(menu);
                e.mostrar(menu);
                e.sair(menu);
            } while (menu != 5);
            Console.WriteLine("digite qualquer tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("fechando o pragrama");
        }
    }
}
