using State.State;

namespace State.Context
{
    public class Semaforo
    {
        private ICores estadoAtual;
        public ICores EstadoAtual
        {            
            get { return estadoAtual; }            
            set
            {
                estadoAtual = value;
            }
        }

        public Semaforo(ICores estadoAtual)
        {
            this.estadoAtual = estadoAtual;
        }

    }
}
