using MediatR;
using System;
using VemDeZap.Domain.Enums;

namespace VemDeZap.Domain.Commands.Grupo.AdicionarGrupo
{
    public class AdicionarGrupoRequest : IRequest<Response>
    {
        public string Nome { get; set; }
        public EnumNicho Nicho { get; set; }
        public Guid? IdUsuario { get; set; }
    }
}
