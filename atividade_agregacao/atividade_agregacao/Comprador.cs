class Comprador
{
    private double verba;

    public double Verba
    {
        get { return verba; }
        set
        {
            if (value >= 0)
                verba = value;
            else
                Console.WriteLine("A verba não pode ser negativa!");
        }
    }

    public Comprador(double verba)
    {
        this.verba = verba;
    }
}