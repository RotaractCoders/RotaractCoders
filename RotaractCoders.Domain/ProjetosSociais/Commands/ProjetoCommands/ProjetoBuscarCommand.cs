namespace RotaractCoders.Domain.ProjetosSociais.Commands.ProjetoCommands
{
    public class ProjetoBuscarCommand
    {
        public int Pagina { get; set; }

        public string Distrito { get; set; }

        public int CodigoClube { get; set; }
    }
}
