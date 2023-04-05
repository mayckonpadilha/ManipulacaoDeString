﻿using System;

namespace ManipulacaoDeString.Exercicio02
{
    internal class Program
    {

        static string r = "";
        static string fraseDigitada = "";
        static int contadorDePalavras = 0;
        static string novaFraseFormatada = "";
        static string[] novadivisao = new string[25];
        static void Main(string[] args)
        {
            PegaDigitosDoUsuario();
            SeparasAsPalavrasPorVirgula();
            SeparasAsPalavrasPorEspaco();
            MostraOsResultadosParaUsuario();
        }

        private static void MostraOsResultadosParaUsuario()
        {
            Console.WriteLine("Palavras da Frase: ");
            Console.WriteLine(contadorDePalavras);
        }

        private static void PegaDigitosDoUsuario()
        {
            Console.WriteLine("Frase aleatoria: ");
            fraseDigitada = Console.ReadLine();
        }

        private static void SeparasAsPalavrasPorEspaco()
        {
            for (int i = 0; i < novadivisao.Length; i++)
            {
                novadivisao = novaFraseFormatada.Split(" ");

                if (novadivisao[i] == "")
                { }
                else
                {
                    contadorDePalavras++;
                }
            }
        }

        private static void SeparasAsPalavrasPorVirgula()
        {
            string[] palavrasSeparadas = fraseDigitada.Split(",");

            for (int i = 0; i < palavrasSeparadas.Length; i++)
            {
                r = palavrasSeparadas[i] + " ";
                novaFraseFormatada += r;
            }
        }
    }
}
