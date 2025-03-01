namespace ColaBlazor.Services
{
    public class ColaCircular
    {
        public int[] Elementos { get; private set; }  // Arreglo para la cola
        public int MAX { get; private set; }  // Tamaño máximo de la cola
        public int Frente { get; private set; }  // Índice del frente
        public int Final { get; private set; }  // Índice del final

        public ColaCircular(int max = 5)
        {
            MAX = max;
            Elementos = new int[MAX];
            Frente = -1;
            Final = -1;
        }

        public bool Vacia() => Frente == -1;
        public bool Llena() => (Final + 1) % MAX == Frente;

        public void Encolar(int valor)
        {
            if (Llena()) return; // No se puede encolar si la cola está llena

            if (Vacia())
            {
                Frente = 0;
            }

            Final = (Final + 1) % MAX;
            Elementos[Final] = valor;
        }

        public int Desencolar()
        {
            if (Vacia()) return -1; // Retorna -1 si la cola está vacía

            int valor = Elementos[Frente];

            if (Frente == Final) // Si solo hay un elemento, se vacía la cola
            {
                Frente = -1;
                Final = -1;
            }
            else
            {
                Frente = (Frente + 1) % MAX;
            }

            return valor;
        }
    }
}
