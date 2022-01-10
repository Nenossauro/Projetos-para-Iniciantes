using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Estrutura_If___
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            //aqui estamos declarando um ponto para ao qual desejamos voltar em nosso codigo
            

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Digite a primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite a segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite a terceira nota: ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite a quarta nota: ");
            double n4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            //aqui estamos salvando as informações digitadas pelo usuario em suas devidas variaveis

            double mf = (n1 * 0.2) + (n2 * 0.2) + (n3 * 0.3) + (n4 * 0.3);
            //aqui estamos fazendo um calculo de média ponderada (aonde cada valor tem um peso especifico)
            
            
            Console.WriteLine("");
            //usamos um console.writeline em branco para pular linha
            Console.WriteLine("Sua média final é: " + mf);
            Console.WriteLine("");

            if (mf >= 6)
            
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O aluno " + nome + " foi aprovado!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            //aqui estamos declarando que SE (if em ingles) a media final (mf) for MAIOR ou IGUAL a seis (6) o aluno foi aprovado
            else if (mf <= 5 && mf >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O aluno " + nome + " está de recuperação!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            //aqui estamos declarando que OU SE (else if em ingles) a media final (mf) for MENOR ou IGUAL a três (3) o aluno foi aprovado
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O aluno " + nome + " está reprovado!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            //aqui estamos declarando que SE a media final NÃO (else em ingles) for nenhum das outras duas condições o aluno foi reprovado

            Console.ReadKey();
            Console.Clear();
            goto inicio;
            //aqui estamos executando um comando que faz com que o codigo execute tudo novamente a partir do ponto que definimos (linha 14)
        }
    }
}
