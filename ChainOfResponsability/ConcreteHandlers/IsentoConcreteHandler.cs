using ChainOfResponsability.Handlers;

namespace ChainOfResponsability.ConcreteHandlers
{
    public class IsentoConcreteHandler : IHandler
    {
        public IHandler Next { get;  set; }

        public string Execute(float salario)
        {
            if (salario <= 1903.98)
                return "Você está na faixa de isento";
            else
                return Next.Execute(salario);
        }
        
    }
}
