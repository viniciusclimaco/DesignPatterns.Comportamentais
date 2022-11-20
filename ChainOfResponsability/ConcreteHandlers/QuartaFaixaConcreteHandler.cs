using ChainOfResponsability.Handlers;

namespace ChainOfResponsability.ConcreteHandlers
{
    internal class QuartaFaixaConcreteHandler : IHandler
    {
        public IHandler Next { get; set; }

        public string Execute(float salario)
        {
            if (salario >= 4664.68)
                return "Você está na Quarta Faixa, seu desconto é de 27.5%";
            else
                return Next.Execute(salario);
        }
    }
}
