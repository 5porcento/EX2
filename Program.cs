using System.Globalization;

namespace Exercicio2 { 
    class Progam
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem em sua casa?");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu utimo nome, idade e altura(mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string ultname = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco);
            Console.WriteLine(ultname);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }



}


