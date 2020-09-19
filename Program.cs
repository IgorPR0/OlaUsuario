using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            //Entrada(Digite//
            Console.Write("Digite Seu Nome: ");
            nome = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine($"Olá, {nome}!");
            //Final(Digite)//

            //Partida(Sair)//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //final(Sair)//
        }
    }
}
