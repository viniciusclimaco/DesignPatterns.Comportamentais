using State.Context;
using State.State;

namespace State.ConcretState
{
    public class Amarelo : ICores
    {
        public void SetVerde(Semaforo context)
        {
            Console.WriteLine("Após o Amarelo, o próximo status é o Vermelho");
        }

        public void SetVermelho(Semaforo context)
        {
            context.EstadoAtual = new Vermelho();
            Console.WriteLine("Opção correta");
        }
        
        public void SetAmarelo(Semaforo context)
        {
            Console.WriteLine("Já encontra-se no Amarelo");
        }
    }
}
