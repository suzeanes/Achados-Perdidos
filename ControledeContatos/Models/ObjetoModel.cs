namespace ControledeContatos.Models
{
    public class ObjetoModel
    {
        private string detalhes;

        public int Id { get; set; }
        public string Objeto { get; set; }
        public string Modelo { get; set; }
        public string Detalhes { get => detalhes; set => detalhes = value; }
        public string Localizacao { get; set; }
    }
}
