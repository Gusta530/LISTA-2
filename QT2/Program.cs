 /*-------------------------------------------------------------------
Questão 2: Cálculo de Pontuação por Missão com Níveis de 
Dificuldade
Contextualização:
Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade.
Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando:
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas missões ele completou.
2. Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3. Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
* Fácil: 50 pontos por inimigo
* Médio: 100 pontos por inimigo
Serviço Nacional de Aprendizagem Industrial
Centro de Formação Profissional Antônio Urbano de Almeida
Técnico em Jogos Digitais
Lógica de Programação
Lista de Exercícios 3
3
* Difícil: 150 pontos por inimigo
O programa deve calcular e exibir a pontuação total acumulada pelo jogador.
@Lista: 03 - Condicionais
@Autor: Luis Gustavo Serafim de Souza
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? nvl;
        int miss, ini, fim = 0,fim1 = 0,fim2 = 0,fim3 = 0;
        Console.WriteLine(" Quantas missões foram completadas?");
        int.TryParse(Console.ReadLine(), out miss);
        for (int i = 0; i < miss; i++)
        {
            Console.WriteLine("Para cada missão, qual o nível de dificuldade?");
            nvl = Console.ReadLine();
            if (nvl == "facil")
            {
                Console.WriteLine("Quantos inimigos você derrotou nessa missão?");
                int.TryParse(Console.ReadLine(), out ini);
                fim = 50 * ini;
            }
             else if (nvl == "medio")
            {
                Console.WriteLine("Quantos inimigos você derrotou nessa missão?");
                int.TryParse(Console.ReadLine(), out ini);
                fim1 = 100 * ini;
            }
             else if (nvl == "dificil")
            {
                Console.WriteLine("Quantos inimigos você derrotou nessa missão?");
                int.TryParse(Console.ReadLine(), out ini);
                fim2 = 150 * ini;
            }
            fim3=fim+fim1+fim2;
        }
  Console.WriteLine($"Você ganhou {fim3} pontos!");
    }
}