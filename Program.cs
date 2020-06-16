using System;

namespace Aula18Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador player = new Jogador();
            
            System.Console.WriteLine("Digite o seu nome");
            player.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite sua posição");
            player.Posição = Console.ReadLine();

            player.ConfirmarPosição();

            System.Console.WriteLine("Digite sua data de nascimento");
            player.Nascimento = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite sua nacionalidade");
            player.Nacionalidade = Console.ReadLine();

            System.Console.WriteLine("Digite sua altura");
            player.Altura = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite seu peso");
            player.Peso = float.Parse(Console.ReadLine());

            System.Console.WriteLine(player.MostrarDados());
           
            System.Console.WriteLine(player.CalcularIdade());

            System.Console.WriteLine(player.CalcularAposentadoria());

        }
    }
}
