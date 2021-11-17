using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_um_elevador
{
    class elevador : pessoa
    {
        public int andarAtual;
        public int totalAndares;
        public int capacidade;
        public int qntPessoas;
        public List<pessoa> pessoas = new List<pessoa>();

        public elevador(int _capacidade, int _totalAndares,int _andarAtual,int _qntPessoas)
        {
            this.capacidade = _capacidade;
            this.totalAndares = _totalAndares;
            this.andarAtual = _andarAtual;
            this.qntPessoas = _qntPessoas;
        }
        public int Menu() {
            qntPessoas = pessoas.Count;
            Console.WriteLine("======================================================================");
            Console.WriteLine("voce esta no andar " + this.andarAtual);
            Console.WriteLine("há " +qntPessoas+" pessoas no elevador");
            Console.WriteLine("digite '1' para entrar no elevador");
            Console.WriteLine("digite '2' para escolher andar");
            Console.WriteLine("digite '3' para mostrar quem esta no elevador");
            Console.WriteLine("digite '4' para sair do elevador");
            Console.WriteLine("digite '5' para sair do programa");
            int lop = int.Parse(Console.ReadLine());
            Console.WriteLine("======================================================================");
            Console.Clear();
            return (lop);
        }
        public void entrar(int menu)
        {
                switch (menu)
                {
                    case 1:
                    Console.WriteLine("voce esta no andar "+andarAtual);
                        Console.WriteLine("digite quantas pessoas querem entrar no elevador");
                        qntPessoas = int.Parse(Console.ReadLine());
                    int o = qntPessoas;
                    if (this.qntPessoas <= this.capacidade)
                        {
                        if (pessoas.Count > 0)
                        {
                            o = o + 1;
                            qntPessoas = pessoas.Count;
                        }
                            for (int i = pessoas.Count; i <o; i++)
                            {
                                Console.WriteLine("===========================================================");
                                Console.WriteLine("digite seu nome");
                                nome = Console.ReadLine();
                                Console.WriteLine("digite sua idade");
                                idade = Console.ReadLine();
                                Console.WriteLine("===========================================================");
                                pessoas.Add(new pessoa());
                                pessoas[i].nome = nome;
                                pessoas[i].idade = idade;
                            }
                        Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("o elevador chegou a sua capacidade maxima que é de " + this.capacidade+ " pessoas");
                        }
                        break;
                }
            
        }
        public void escolherAndar(int menu)
        {
            switch (menu)
            {
                case 2:
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("há " + qntPessoas + " pessoas no elevador");
                    Console.WriteLine("você esta no andar " + andarAtual);
                    Console.WriteLine("digite o andar a onde quer chegar");
                    this.andarAtual = int.Parse(Console.ReadLine());
                    Console.WriteLine("===========================================================");
                    if(andarAtual <= totalAndares)
                    {
                        Console.WriteLine("o elevador esta no andar " + andarAtual);
                    }
                    else
                    {
                        Console.WriteLine("o andar que você digitou não existe ou você digitou errado");
                    }
                    Console.Clear();
                    break;

            }
        }
        public void mostrar(int menu)
        {
            switch (menu)
            {
                case 3:
                    Console.WriteLine("você esta no andar " + this.andarAtual);
                    Console.WriteLine("há " + pessoas.Count + " pessoas");
                    for(int i=0; i<pessoas.Count;i++)
                    {
                        Console.WriteLine("==================================================");
                        Console.WriteLine(pessoas[i].nome);
                        Console.WriteLine(pessoas[i].idade);
                        Console.WriteLine("==================================================");
                    }
                    break;
            }
        }
        public void sair(int menu)
        {
            switch (menu)
            {
                case 4:
                    if (this.qntPessoas == 0)
                    {
                        Console.WriteLine("não há pessoas no elevador para sairem");
                    }
                    else
                    {
                        Console.WriteLine("você esta no andar " + andarAtual);
                        Console.WriteLine("há " + pessoas.Count + " pessoas");
                        Console.WriteLine("digite o numero de pessoas que querem sair");
                        int sairam = int.Parse(Console.ReadLine());
                        qntPessoas = qntPessoas - sairam;
                        if (sairam <= pessoas.Count)
                        {
                            for (int i = 0; i < sairam; i++)
                            {
                                pessoas.RemoveAt(i);
                            }
                        }
                        else
                        {
                            Console.WriteLine("não existem pessoas o suficientes para sairem");
                        }
                        Console.Clear();
                    }
                    break;


            }
        }       

    
}
}
