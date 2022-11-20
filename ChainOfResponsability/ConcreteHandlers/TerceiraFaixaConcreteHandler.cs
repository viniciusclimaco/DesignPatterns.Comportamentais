using ChainOfResponsability.Handlers;

namespace ChainOfResponsability.ConcreteHandlers
{
    internal class TerceiraFaixaConcreteHandler : IHandler
    {
        public IHandler Next { get; set; }

        public string Execute(float salario)
        {
            if (salario >= 3751.05 && salario <= 4664.68)
                return "Você está na Terceira Faixa, seu desconto é de 22.5%";
            else
                return Next.Execute(salario);
        }
    }
}
