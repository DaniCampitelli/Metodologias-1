namespace Metodologias_1
{
    interface IColeccionable
    {
        int cuantos();
        public IComparable minimo();
        public IComparable maximo();
        bool agregar(IComparable c);
        IComparable sacar();// preguntar ari
        bool contiene(IComparable c);


{
    interface IColeccionable
    {
        public int cuantos();
        public int minimo();
        public int maximo();
        public void agregar(Icomparable a);
        public bool contiene(Icomparable a);

    }
}
