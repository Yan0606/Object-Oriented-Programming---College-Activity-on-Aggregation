class Produto
{
    private int cod;
    private string nome;
    private double preco;

    public int Cod
    {
        get { return cod; }
    }

    public string Nome
    {
        get { return nome; }
    }

    public double Preco
    {
        get { return preco; }
        set
        {
            if (value >= 0)
                preco = value;
            else
                Console.WriteLine("O preço não pode ser negativo!");
        }
    }

    public Produto(int cod, string nome, double preco)
    {
        this.cod = cod;
        this.nome = nome;
        this.preco = preco;
    }
}