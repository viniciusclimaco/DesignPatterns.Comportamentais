using ChainOfResponsability.Handlers;

namespace ChainOfResponsability.ConcreteHandlers
{
    internal class SegundaFaixaConcreteHandler : IHandler
    {
        public IHandler Next { get; set; }

        public string Execute(float salario)
        {
            if (salario >= 2826.66 && salario <= 3751.05)
                return "Você está na Segunda Faixa, seu desconto é de 15%";
            else
                return Next.Execute(salario);
        }
    }
}
