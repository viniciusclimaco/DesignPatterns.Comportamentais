using State.Context;
using State.State;

namespace State.ConcretState
{
    public class Vermelho : ICores
    {   
        public void SetVerde(Semaforo context)
        {
            context.EstadoAtual = new Verde();
            Console.WriteLine("Opção correta");
        }

        public void SetVermelho(Semaforo context)
        {
            Console.WriteLine("Já encontra-se no Vermelho");            
        }

        public void SetAmarelo(Semaforo context)
        {            
            Console.WriteLine("Após o Vermelho, o próximo status é o Verde");
        }
    }
}
