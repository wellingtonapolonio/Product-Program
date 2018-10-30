using System;

namespace Product
{
    class Program
    {
        public static void Main(string[] args)
        {
            Assinatura a = new Assinatura
            {
                Codigo = 123,
                Nome = "Assinatura MVP",
                Preco = 69.99M,
                DataExpiracao = DateTime.Today.AddMonths(12)

            };
            
            Console.WriteLine($"Dias restantes de assinatura: {a.GetTempoRestante().Days}");
        }
    }
}
