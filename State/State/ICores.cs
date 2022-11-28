using State.Context;

namespace State.State
{
    public interface ICores
    {
        void SetAmarelo(Semaforo context);
        void SetVermelho(Semaforo context);
        void SetVerde(Semaforo context);
    }
}
