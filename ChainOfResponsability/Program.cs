using ChainOfResponsability.ConcreteHandlers;
using ChainOfResponsability.Handlers;

IHandler faixaIsento = new IsentoConcreteHandler();
IHandler faixaPrimeira = new PrimeiraFaixaConcreteHandler();
IHandler faixaSegunda = new SegundaFaixaConcreteHandler();
IHandler faixaTerceira = new TerceiraFaixaConcreteHandler();
IHandler faixaQuarta = new QuartaFaixaConcreteHandler();

faixaIsento.Next = faixaPrimeira;
faixaPrimeira.Next = faixaSegunda;
faixaSegunda.Next = faixaTerceira;
faixaTerceira.Next = faixaQuarta;

Console.WriteLine("--- Qual será seu deconto de Imposto de Renda ---");
Console.WriteLine("Informe seu salário: ");
float salario = (float)Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($" ---- Resultado da Pesquisa ---- ");
Console.WriteLine(faixaIsento.Execute(salario));

Console.ReadKey();
