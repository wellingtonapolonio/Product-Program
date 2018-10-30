using System;
namespace Product
{
    public class Assinatura : Product, IExpiravel
    {
        private DateTime dataExpiracao;

        public DateTime DataExpiracao
        {
            get => dataExpiracao;
            set => dataExpiracao = value;
        }

        public TimeSpan GetTempoRestante()
        {
            return dataExpiracao - DateTime.Today;
        }

    }
}
