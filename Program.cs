using baze;
using Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Ver \n2.Adicionar Carro \n3.Adicionar Aeronave");
                string p = Console.ReadLine();
                if (p == "1")
                {
                    ver();
                }
                else if (p == "2")
                {
                    adicionarCarro();
                }
                else if (p == "3")
                {
                    adicionarAeronave();
                }
                else
                {
                    Console.WriteLine("Escolha Invalida");
                }
            }

            //var b = new Carros() { Marca = "Toyota", Cor = "Cinnza", Velocidade = "360Km/h"};
            //b.Registar(); 
            //var c = new Aeronaves() { Marca = "Caça", Cor = "Cinnza", Velocidade = "800Km/h" };
            //c.Registar();
           
            //while (true)
            //{
            //    Console.WriteLine("Escolha  \n1.Ver Transportes \n2.Adicionar Transporte \n3.Sair");
            //    string p = Console.ReadLine();
            //    if (p=="1")
            //    {
            //        var j =  new Base().Ler();
            //    }
            //}
            

        }
        static void ver()
        {
            var b = new Carros();
            b.Ler();
            var c = new Aeronaves();
            c.Ler();
        }
        static void adicionarCarro()
        {
            Console.WriteLine("Digite a Marca");
            string Marca1 = Console.ReadLine();
            Console.WriteLine("A Cor");
            string cor = Console.ReadLine();
            Console.WriteLine("A velocidade");
            string velocidade = Console.ReadLine();
            var b = new Carros() { Marca = Marca1, Cor = cor, Velocidade = velocidade };
            b.Registar();
            //var c = new Aeronaves() { Marca = "Caça", Cor = "Cinnza", Velocidade = "800Km/h" };
            //c.Registar();
        }
        static void adicionarAeronave()
        {

            Console.WriteLine("Digite a Marca");
            string Marca1 = Console.ReadLine();
            Console.WriteLine("A Cor");
            string cor = Console.ReadLine();
            Console.WriteLine("A velocidade");
            string velocidade = Console.ReadLine();

            var b = new Aeronaves() { Marca = Marca1, Cor = cor, Velocidade = velocidade };
            b.Registar();
        }
    }
}
