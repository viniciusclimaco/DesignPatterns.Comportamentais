using State.Context;
using State.State;

namespace State.ConcretState
{
    public class Verde : ICores
    {
        public void SetVerde(Semaforo context)
        {            
            Console.WriteLine("Já encontra-se no Verde");
        }

        public void SetVermelho(Semaforo context)
        {
            Console.WriteLine("Após o Verde, o próximo status é o Amarelo");
        }

        public void SetAmarelo(Semaforo context)
        {
            context.EstadoAtual = new Amarelo();
            Console.WriteLine("Opção correta");            
        }
    }
}
