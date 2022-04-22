namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int coluna { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.coluna = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
