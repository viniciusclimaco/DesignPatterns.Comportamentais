using State.ConcretState;
using State.Context;

Semaforo semaforo = new Semaforo(new Vermelho());
string proximoEstado = String.Empty;

while (true)
{   
    Console.WriteLine($"Ajude a definir o próximo estado do Semáforo. \nAtualmente encontra-se no estado: {semaforo.EstadoAtual.GetType().Name.ToUpper()}.");
    Console.WriteLine($"Qual o próximo estado? \nV - Verde | A - Amarelo | R - Vermelho");
        
    proximoEstado = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("----- RESPOSTA -----");
    switch (proximoEstado)
    {
        case "A":
            semaforo.EstadoAtual.SetAmarelo(semaforo);
            break;
        case "V":
            semaforo.EstadoAtual.SetVerde(semaforo);
            break;
        case "R":
            semaforo.EstadoAtual.SetVermelho(semaforo);
            break;
        default:
            Console.WriteLine("Opção não existe, favor refazer sua opção.");
            break;
    }
    Console.WriteLine("--------------------");
    Console.WriteLine();
}