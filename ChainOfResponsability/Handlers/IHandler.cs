namespace ChainOfResponsability.Handlers
{
    public interface IHandler
    {
        IHandler Next { get;  set; }
        
        string Execute(float salario);
        
    }
}
