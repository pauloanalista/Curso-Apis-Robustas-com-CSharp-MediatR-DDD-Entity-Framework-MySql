using MediatR;
using System;

namespace VemDeZap.Domain.Commands.Grupo.RemoverGrupo
{
    public class RemoverGrupoResquest : IRequest<Response>
    {
        public RemoverGrupoResquest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
