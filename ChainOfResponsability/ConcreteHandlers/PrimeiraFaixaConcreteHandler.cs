using ChainOfResponsability.Handlers;

namespace ChainOfResponsability.ConcreteHandlers
{
    internal class PrimeiraFaixaConcreteHandler : IHandler
    {
        public IHandler Next { get; set; }

        public string Execute(float salario)
        {
            if (salario >= 1903.99 && salario <= 2826.65)
                return "Você está na Primeira Faixa, seu desconto é de 7.5%";
            else
                return Next.Execute(salario);
        }
    }
}
