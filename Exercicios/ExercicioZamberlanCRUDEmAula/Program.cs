﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioZamberlanCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Atleta> listaAtletas = new List<Atleta>();
            List<Treinador> listaTreinadores = new List<Treinador>();

            string opcao = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Padel");
                Console.WriteLine("1 - Cadastrar atleta");
                Console.WriteLine("2 - Listar atletas");
                Console.WriteLine("3 - Remover atleta");
                Console.WriteLine("4 - Cadastrar treinador");
                Console.WriteLine("5 - Listar treinadores");
                Console.WriteLine("6 - Remover treinador");
                Console.WriteLine("7 - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Cadastro de atleta");
                        Comunicacao.cadastrarAtleta(listaAtletas);
                        //Persistencia.gravarAtleta(listaAtletas);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Listagem de atletas");
                        Comunicacao.ListarAtletas(listaAtletas);

                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Remoção de atleta");
                        Comunicacao.removerAtleta(listaAtletas);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Cadastro de treinador");
                        Comunicacao.CadastrarTreinador(listaTreinadores);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Listagem de treinadores");
                        Comunicacao.ListarTreinador(listaTreinadores);

                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Remoção de treinador");
                        Comunicacao.RemoverTreinador(listaTreinadores);
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.Write("Tecle ENTER para continuar.....");
                Console.ReadKey(true);
            } while (opcao != "7");
        }
    }
}