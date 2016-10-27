using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RotaractCoders.Domain.ProjetosSociais.Enums
{
    public enum Participante
    {
        Rotaractianos,
        Rotarianos,
        [Description("Voluntários Adicionais")]
        VoluntariosAdicionais
    }
}
