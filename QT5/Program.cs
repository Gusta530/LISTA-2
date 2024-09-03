/*-------------------------------------------------------------------
Questão 5: Sistema de Recompensas Diárias com Limites e Bônus
Contextualização
Em um jogo online, os jogadores ganham recompensas diárias por logarem consecutivamente. 
A cada dia consecutivo, o valor da recompensa aumenta, mas há um limite diário. Além disso, 
se o jogador atingir certos marcos de dias, recebe bônus adicionais.
Comando
Crie um programa em C# que:
1. Pergunte ao jogador por quantos dias consecutivos ele logou no jogo.
2. Pergunte qual é a recompensa inicial em moedas no primeiro dia.
3. Pergunte qual é o incremento da recompensa a cada dia consecutivo.
4. (Opcional) Pergunte se o jogador deseja considerar bônus por marcos de dias 
(Sim/Não). Se sim, pergunte a cada quantos dias consecutivos há um bônus e qual o 
valor do bônus.
O programa deve calcular e exibir o total de moedas acumuladas pelo jogador, incluindo os 
bônus se aplicável.
Observações:
* Sem considerar bônus (Input 4 = Não): Apenas soma das recompensas diárias.
* Considerando bônus (Input 4 = Sim): Além da soma das recompensas diárias, 
adiciona o bônus a cada marco alcançado.
@Lista: 03 - Condicionais
@Autor: Luís Gustavo Serafim de Souza
@Data: 03/09/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        string? dbs;
        int ds, pd, dcnsctvo = 0, bns = 0, fim1 = 0, fim2 = 0, vlr=0,fim3=0;
        Console.WriteLine("Quantos dias consecutivos você logou no jogo?");
        int.TryParse(Console.ReadLine(), out ds);
        Console.WriteLine("Qual foi recompensa inicial em moedas no primeiro dia?");
        int.TryParse(Console.ReadLine(), out pd);
        Console.WriteLine("Qual foi incremento da recompensa a cada dia consecutivo?");
        int.TryParse(Console.ReadLine(), out dcnsctvo);
        Console.WriteLine("Deseja considerar bônus por marcos de dias?");
        dbs = Console.ReadLine();
        if(dbs=="sim")
        {
        Console.WriteLine("Qual o valor do bônus?");
        int.TryParse(Console.ReadLine(), out vlr);
           Console.WriteLine(" quantos dias consecutivos há um bônus?");
                int.TryParse(Console.ReadLine(), out bns);
        }
        fim3=vlr*bns;
            fim1 = ds * dcnsctvo;
            fim2 = fim1 + pd +fim3;
            System.Console.WriteLine($"Você tem {fim2} pontos!");
    }
}