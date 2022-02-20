namespace Edmilson.Series
{
    public class Serie : BaseEntity
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
    }
}