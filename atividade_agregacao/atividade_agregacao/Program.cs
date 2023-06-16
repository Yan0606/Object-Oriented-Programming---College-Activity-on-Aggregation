class Program
{
    static void Main(string[] args)
    {
        Vendedor vendedor = new Vendedor(0.02);
        Comprador comprador = new Comprador(1000.0); 

        List<Produto> vetProd = new List<Produto>();
        vetProd.Add(new Produto(500, "Chuteira Nike", 150.0));  
        vetProd.Add(new Produto(501, "Chuteira Adidas", 170.0));
        vetProd.Add(new Produto(502, "Chuteira Puma", 100.0));

        Venda venda = new Venda(comprador, vendedor, vetProd);
        venda.RealizarVenda(501);

        Console.WriteLine("Verba do comprador depois da venda: R$ " + comprador.Verba);
    }
}
