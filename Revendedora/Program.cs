using System;

namespace Revendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Exercício 1
            /*int anos;
            int meses;
            int dia;
            int total;

            Console.WriteLine("Insira seu ano de nascimento: ");
            anos = Convert.ToInt32(Console.ReadLine()) * 365;
            Console.WriteLine("Insira seu mês de nascimento: ");
            meses = Convert.ToInt32(Console.ReadLine()) * 30;
            Console.WriteLine("Insira o dia do seu nascimento: ");
            dia = Convert.ToInt32(Console.ReadLine());

            total = anos + meses + dia;

            Console.WriteLine($"Você tem {total} dias de idade!");*/

            ///Exercício 2
            /*SELECT Produto.NOME_PROD, SUM(Cores.PRECO_COR + Produto.PRECO_PROD) AS Preco_Produto FROM Produto
            INNER JOIN Cores
            ON Cores.IDPRODUTO = Produto.IDPRODUTO
            WHERE Produto.NOME_PROD IS NOT NULL
            GROUP BY Produto.NOME_PROD
            ORDER BY Preco_Produto*/

            ///Exercício 3
            int carrosVendidos;
            int salarioFixo;
            int comissaoCarro;
            double totalVendas;
            double salarioFinal;

            Console.WriteLine("Insira a quantidade de carros vendidos pelo funcionário: ");
            carrosVendidos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o salário fixo do funcionário: ");
            salarioFixo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a comissão para cada carro vendido: ");
            comissaoCarro = Convert.ToInt32(Console.ReadLine()) * carrosVendidos;
            Console.WriteLine("Insira o valor total de vendas feitas pelo funcionário: ");
            totalVendas = Convert.ToDouble(Console.ReadLine());

            totalVendas *= 0.05;
            salarioFinal = salarioFixo + comissaoCarro + totalVendas;

            Console.WriteLine($"O salário final do funcionário é de {salarioFinal} R$");
        }
    }
}
