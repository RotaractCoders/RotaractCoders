namespace RotaractCoders.Domain.ProjetosSociais.Commands.ProjetoCommands
{
    public class ExtrairProjetosOmirBrasilCommand
    {
        public ExtrairProjetosOmirBrasilCommand(bool iniciarDoUltimo = true)
        {
            IniciarDoUltimo = iniciarDoUltimo;
        }

        public bool IniciarDoUltimo { get; set; }
    }
}
