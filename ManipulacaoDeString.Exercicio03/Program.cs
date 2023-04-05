﻿using System;

namespace ManipulacaoDeString.Exercicio03
{
    internal class Program
    {
        static char tamanhoEmChar;
        static int tamanhoFinal;
        static char novoChar;
        static string charParaString = "";
        static void Main(string[] args)
        {
            string palavra = RecebePalavraDoUsuario();
            char[] arraychar = palavra.ToCharArray();
            TransformaLetraEm2AFrente(arraychar);
            MostraProUsuario();
        }

        private static void MostraProUsuario()
        {
            Console.WriteLine(charParaString);
            Console.ReadLine();
        }

        private static void TransformaLetraEm2AFrente(char[] arraychar)
        {
            for (int i = 0; i < arraychar.Length; i++)
            {
                tamanhoEmChar = arraychar[i];
                tamanhoFinal = Convert.ToInt32(tamanhoEmChar + 2);
                novoChar = Convert.ToChar(tamanhoFinal);
                charParaString += novoChar;
            }
        }

        private static string RecebePalavraDoUsuario()
        {
            Console.WriteLine("\n------------------");
            Console.WriteLine("(Cifra de César: ");
            string palavra = Console.ReadLine();
            return palavra;
        }
    }
}
