﻿using System.Runtime.Serialization;
using System.Xml;

namespace ExerciciosRepeticaoPt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados
            //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            //Exemplo:
            //            Digite um número inteiro positivo: -8
            //Valor incorreto!
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.

            //int num = -1;


            //while(num < 0 && num % 1 == 0)
            //{
            //    Console.Write("Digite um número inteiro positivo: ");
            //    num = int.Parse(Console.ReadLine());
            //    if (num % 1 == 0 && num > 0)
            //    {
            //        Console.Write("Números inteiros pares entre 1 e " + num + ": ");
            //        for (int i = 1; i < num; i++)
            //        {
            //            if (i % 2 == 0)
            //            {
            //                Console.Write(i + ", ");
            //            }
            //        }
            //    } else
            //    {
            //        Console.WriteLine("Valor incorreto!");
            //    }
            //}
            //=============
            //2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            //informar um outro número. Caso positivo, o programa em VS deve ser repetido.


            //Exemplo:
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.


            //Deseja informar outro número(s/ n)? S

            //Digite um número inteiro positivo: 12
            //Numero digitado: 20
            //Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
            //int num = -1;
            //string op = "S";

            //while (op != "N")
            //{
            //    while (num < 0 && num % 1 == 0)
            //    {
            //        Console.Write("Digite um número inteiro positivo: ");
            //        num = int.Parse(Console.ReadLine());
            //        if (num % 1 == 0 && num > 0)
            //        {
            //            Console.Write("Números inteiros pares entre 1 e " + num + ": ");
            //            for (int i = 1; i < num; i++)
            //            {
            //                if (i % 2 == 0)
            //                {
            //                    Console.Write(i + ", ");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Valor incorreto!");
            //        }
            //    }
            //    Console.WriteLine("Deseja informar outro número (S/N)? ");
            //    op = Console.ReadLine();
            //    if (op == "S") { num = -1; }
            //    else { num = num; };
            //}
            //-------------------------
            //3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
            //Se o usuário digitar 0 o programa em VS deve parar. 
            //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.

            //int num = 1;

            //while(num !=0)
            //{
            //    Console.WriteLine("Informe um número: ");
            //    num = int.Parse(Console.ReadLine());

            //    if(num % 2 == 0)
            //    {
            //        Console.WriteLine("O número é PAR!");
            //    } else
            //    {
            //        Console.WriteLine("O número é IMPAR!");
            //    }
            //}

            //--------------------------------------------------------------------

            /*4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
            Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
            Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
            Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
            escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
            de votos em branco. */

            //string entrada = "X";
            //int joao=0 , maria=0, branco=0;

            //Console.WriteLine("Digite FIM para parar!");
            //while (entrada != "FIM")
            //{
            //    Console.WriteLine("Digite o seu voto (JOAO/MARIA/BRANCO): ");
            //    entrada = Console.ReadLine();
            //    switch (entrada)
            //    {
            //        case "JOAO":
            //            joao++;
            //            break;
            //        case "MARIA":
            //            maria++;
            //            break;
            //        case "BRANCO":
            //            branco++;
            //            break;
            //        case "FIM":
            //            break;
            //        default:
            //            Console.WriteLine("Valor inválido!");
            //            break;
            //    }
            //}
            //Console.WriteLine("Foram " + joao + " votos para João");
            //Console.WriteLine("Foram " + maria + " votos para Maria");
            //Console.WriteLine("Foram " + branco + " votos em Branco");

            //================================================================================
            //5.Modifique o programa em VS anterior para aceitar votos nulos
            //(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
            //Ao final, informe o nome do candidato vencedor, o número de votos nulos
            //e o número de pessoas que votaram.

            //    string entrada = "X";
            //    int joao = 0, maria = 0, branco = 0, nulos = 0, qtd = 0;

            //    Console.WriteLine("Digite FIM para parar!");
            //    while (entrada != "FIM")
            //    {
            //        Console.WriteLine("Digite o seu voto (JOAO/MARIA/BRANCO): ");
            //        entrada = Console.ReadLine();
            //        switch (entrada)
            //        {
            //            case "JOAO":
            //                joao++;
            //                break;
            //            case "MARIA":
            //                maria++;
            //                break;
            //            case "BRANCO":
            //                branco++;
            //                break;
            //            case "FIM":
            //                break;
            //            default:
            //                nulos++;
            //                break;
            //        }
            //        qtd++;
            //    }
            //    if(joao>maria) 
            //    {
            //        Console.WriteLine("VENCEDOR - >>> JOAO / com " + joao + " votos" );
            //    } else if (maria > joao)
            //    {
            //        Console.WriteLine("VENCEDOR - >>> MARIA / com " + maria + " votos");
            //    }
            //    else if(joao == maria)
            //    {
            //        Console.WriteLine("Empate");
            //    }
            //    Console.WriteLine("Foram " + joao + " votos para João");
            //    Console.WriteLine("Foram " + maria + " votos para Maria");
            //    Console.WriteLine("Foram " + branco + " votos em Branco");
            //    Console.WriteLine("Foram " + nulos + " votos nulos");
            //    Console.WriteLine("TOTAL DE VOTOS: " + qtd);
            //}
            ///=========================================================
            /*6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
            Ao final, mostre a idade digitada.*/

            //int idade = 0;

            //while (idade <= 0)
            //{
            //    Console.WriteLine("Informe a sua idade: ");
            //    idade = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Idade digitada: " + idade);

            // ------------------------------------------------------
            /*7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
            A cada solicitação, teste se o usuário informou um valor válido. 
            Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            informe que ele está incorreto e saia do programa em VS. 
            Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
            informe que está errada e saia. Se estiver correta, solicite o salário. 
            Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
            Se estiver correto, mostre todos os valores lidos.*/

            //int idade;
            //string nome;
            //double salario;

            //Console.WriteLine("Informe seu nome: ");
            //nome = Console.ReadLine();

            //if(nome == null || int.TryParse(nome, out int resultado))
            //{
            //    Console.WriteLine("Valor incorreto!");
            //    return;
            //}

            //Console.WriteLine("Informe sua idade: ");
            //idade = int.Parse(Console.ReadLine());
            //if(idade < 0)
            //{
            //    Console.WriteLine("Idade incorreta");
            //    return;
            //}

            //Console.WriteLine("Informe seu salário: ");
            //salario = double.Parse(Console.ReadLine());
            //if(salario < 0)
            //{
            //    Console.WriteLine("Valor inválido");
            //    return;
            //}
            //Console.WriteLine(nome + " sua idade é " + idade + " e seu salário é " + salario + " reais");

            //---------------------------------------------------------------------------------

            /*8. Faça um programa em VS que solicite um numero inteiro. S
            e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
            Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.*/

            //double num = 1.5;
            //string op = "S";
            //Console.WriteLine(num);

            //while (op == "S")
            //{
            //    while (num % 1 != 0)
            //    {
            //        Console.WriteLine("Informe um número inteiro: ");
            //        num = double.Parse(Console.ReadLine());

            //        if (num % 1 == 0)
            //        {
            //            if (num % 2 == 0)
            //            {
            //                Console.WriteLine("O número é PAR!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("O número é IMPAR!");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("O número digitado não é um inteiro!");
            //        }
            //    }
            //    Console.WriteLine("Deseja continunar (S/N)? ");
            //    op = Console.ReadLine();
            //}
            //-------------------------------------------------------------------------------------
            /*9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
                o zoológico num determinado dia, imprimindo:
                Quantas pessoas tem entre 1 e 3 filhos.
                Quantas pessoas tem entre 4 e 7 filhos.
                Quantas pessoas tem mais de 8 filhos.
                Quantas pessoas não tem filhos.*/

            //    int qntFilhos = 0, condicao1 = 0, condicao2 = 0, condicao3 = 0, condicao4 = 0;
            //    for (int i = 0; i <= 30; i++)
            //    {
            //        Console.WriteLine("Pessoa " + i + " informe a quantidade de filhos: ");
            //        qntFilhos = int.Parse(Console.ReadLine());
            //        //fiz assim porque "entre" ficou meio seletivo demais
            //        if (qntFilhos >= 1 && qntFilhos <= 3)
            //        {
            //            condicao1++;
            //        }
            //        if (qntFilhos >= 4 && qntFilhos <= 7)
            //        {
            //            condicao2++;
            //        }
            //        if (qntFilhos >= 8)
            //        {
            //            condicao3++;
            //        }
            //        if (qntFilhos == 0)
            //        {
            //            condicao4++;
            //        }
            //    }
            //    Console.WriteLine(condicao1 + " pessoas tem de 1 a 3 filhos!");
            //    Console.WriteLine(condicao2 + " pessoas tem de 4 a 7 filhos!");
            //    Console.WriteLine(condicao3 + " pessoas tem mais de 8 filhos!");
            //    Console.WriteLine(condicao4 + " pessoas não tem filhos!");

            /*10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
            Número de pessoas do sexo masculino.
            Número de pessoas do sexo feminino.
            Número de pessoas com idade inferior a 30 anos.
            Número de pessoas com idade superior a 60 anos.
            Média de idade das mulheres.*/

            //string nome, sexo;
            //int idade, count = 0, masculino = 0, feminino = 0, idadeMenor30 = 0, idadeSuperior60 = 0, idadeFeminina = 0;


            //while (count < 50)
            //{
            //    Console.Write("Informe o seu nome: ");
            //    nome = Console.ReadLine();
            //    Console.Write("Informe seu sexo (M/F): ");
            //    sexo = Console.ReadLine();
            //    Console.Write("Informe sua idade: ");
            //    idade = int.Parse(Console.ReadLine());

            //    if (sexo == "M" || sexo == "m")
            //    {
            //        masculino++;
            //    }
            //    else if (sexo == "F" || sexo == "f")
            //    {
            //        feminino++;
            //        idadeFeminina += idade;
            //    }
            //    if (idade > 0 && idade < 30)
            //    {
            //        idadeMenor30++;
            //    }
            //    else if (idade > 60)
            //    {
            //        idadeSuperior60++;
            //    }
            //    count++;
            //}
            //Console.WriteLine("Número de pessoas do sexo masculino: " + masculino);
            //Console.WriteLine("Número de pessoas do sexo feminino: " + feminino);
            //Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + idadeMenor30);
            //Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + idadeSuperior60);
            //Console.WriteLine("A media das idades das mulheres é: " + idadeFeminina/feminino);
            //-----------------------------------------------------------------------------------------------
            /*11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
            a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.*/

            //int qtAlunos = 0;
            //double nota = 0, maior = 0, menor = 9999, soma = 0;
            //while(nota != -1)
            //{
            //    Console.WriteLine("Informe a nota: ");
            //    nota = double.Parse(Console.ReadLine());
            //    if(nota > maior)
            //    {
            //        maior = nota;
            //    }
            //    if(nota < menor && nota != -1)
            //    {
            //        menor = nota;
            //    }
            //    soma += nota;
            //    qtAlunos++;
            //}
            //qtAlunos--;
            //soma++;
            //Console.WriteLine("A maior nota foi: " + maior);
            //Console.WriteLine("A menor nota foi: " + menor);
            //Console.WriteLine("A média aritmetica é: " + (double)soma/qtAlunos);
            //Console.WriteLine("A quantidade de alunos é: " + qtAlunos);
            //=====================================================================================
            /*12. Apresentar o total da soma dos cem primeiros números inteiros.*/

            //int num, count = 0, soma = 0;

            //while(count < 100)
            //{
            //    Console.Write("Informe um numero: ");
            //    num = int.Parse(Console.ReadLine());
            //    soma += num;
            //    count++;
            //}
            //Console.WriteLine("A soma dos " + count + " primeiros números: " + soma);

            //-------------------------------------------------------------------------------------

            /*13. Elaborar um programa que apresente o somatório dos valores pares existentes 
            entre 1 e 500.*/
            //int soma = 0;
            //for(int i = 1;i<500;i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        soma += i;
            //    }
            //}
            //Console.WriteLine("O somatório dos pares de 1 a 500: " + soma);
            //-------------------------------------------------------------------------------------
            /*14. Mostrar as potências de 2 variando de 0 a 10.*/
            //int potencia = 1;
            //for(int i = 0; i <=10; i++)
            //{
            //    potencia *= 2;
            //    Console.WriteLine("2^" + i + " = " + potencia);
            //}
            //-------------------------------------------------------------------------------------
            /**/
        }
    }
}