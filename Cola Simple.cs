namespace ColasBlazor.Services
{
    public class ColaSimple
    {
        public int[] Elementos { get; private set; }  // Arreglo para la cola
        public int MAX { get; private set; }  // Tamaño máximo de la cola
        public int Frente { get; private set; }  // Índice del frente
        public int Final { get; private set; }  // Índice del final

        public ColaSimple(int max = 10)
        {
            MAX = max;
            Elementos = new int[MAX];
            Frente = -1;
            Final = -1;
        }

        public bool Vacia() => Frente == -1;
        public bool Llena() => Final == MAX - 1;

        public void Encolar(int valor)
        {
            if (Llena()) return; // No se puede encolar si está llena

            if (Vacia())
            {
                Frente = 0;
            }

            Final++;
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
                Frente++;
            }

            return valor;
        }
    }
}

