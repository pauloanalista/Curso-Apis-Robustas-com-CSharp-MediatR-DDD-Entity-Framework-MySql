using MediatR;

namespace VemDeZap.Domain.Commands.Grupo.RemoverGrupo
{
    public class RemoverGrupoNotification : INotification
    {
        public RemoverGrupoNotification(Entities.Grupo grupo)
        {
            Grupo = grupo;
        }

        public Entities.Grupo Grupo { get; set; }
    }
}
