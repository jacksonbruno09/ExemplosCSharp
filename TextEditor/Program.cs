﻿using System;
using System.IO; 

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Console.WriteLine("Hello World!");
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que você deseja fazer ?");
            Console.WriteLine("1 - Abrir Arquivo");
            Console.WriteLine("2 - Criar Novo arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine());

            switch(option){
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir(){
            Console.Clear(); 
            Console.WriteLine("Qual o caminho do arquivo desejado");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path)){
                string texte = file.ReadToEnd();
                Console.WriteLine(texte);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("----------------------------------");
            string text = "";
            
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            //Console.WriteLine(text);
            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho para salvar o arquivo ");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso !");
            Console.ReadLine();
            Menu();
        }
    }
}
