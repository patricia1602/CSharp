using System;
public class Program
{
    public abstract class LocadoraVeiculo
    {
        protected double TaxaDiaria { get; set; }
        public LocadoraVeiculo(double TaxaDiaria)
        {
            this.TaxaDiaria = TaxaDiaria;
        }
        public abstract double CalcularValorTotal(int numDiarias);
    }
    public class Carro : LocadoraVeiculo //classe carro
    {
       public Carro() : base(50)
        {
        }
        public override double CalcularValorTotal(int numDiarias)
        {
            return numDiarias * TaxaDiaria;
        }
    }
    public class Moto : LocadoraVeiculo //classe moto
    {
        public Moto() : base(25)
        {
        }
        public override global::System.Double CalcularValorTotal(int numDiarias)
        {
            return numDiarias * TaxaDiaria;
        }
    }
   static void Main()
    {
        Carro carro = new Carro();
        Moto moto = new Moto();

        int numDiarias = 10;

        double valorTotalCarro = carro.CalcularValorTotal(numDiarias);
        double valorTotalMoto = moto.CalcularValorTotal(numDiarias);

        Console.WriteLine($"Valor total para {numDiarias} diárias de Carro: R$ {valorTotalCarro}");
        Console.WriteLine($"Valor total para {numDiarias} diárias de Moto: R$ {valorTotalMoto}");
    }
}
