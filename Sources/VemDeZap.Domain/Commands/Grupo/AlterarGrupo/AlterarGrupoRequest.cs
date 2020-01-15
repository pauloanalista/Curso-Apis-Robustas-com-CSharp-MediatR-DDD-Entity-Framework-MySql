using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Commands.Grupo.AlterarGrupo
{
    public class AlterarGrupoRequest : IRequest<Response>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public EnumNicho Nicho { get; set; }
        public Guid? IdUsuario { get; set; }
    }
}
