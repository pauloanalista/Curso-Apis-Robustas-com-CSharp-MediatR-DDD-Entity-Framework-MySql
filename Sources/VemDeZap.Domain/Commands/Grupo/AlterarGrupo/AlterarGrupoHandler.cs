using MediatR;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VemDeZap.Domain.Interfaces.Repositories;
using VemDeZap.Domain.Resources;

namespace VemDeZap.Domain.Commands.Grupo.AlterarGrupo
{
    public class AlterarGrupoHandler : Notifiable, IRequestHandler<AlterarGrupoRequest, Response>
    {
        private readonly IMediator _mediator;
        private readonly IRepositoryGrupo _repositoryGrupo;
        private readonly IRepositoryUsuario _repositoryUsuario;

        public AlterarGrupoHandler(IMediator mediator, IRepositoryGrupo repositoryGrupo, IRepositoryUsuario repositoryUsuario)
        {
            _mediator = mediator;
            _repositoryGrupo = repositoryGrupo;
            _repositoryUsuario = repositoryUsuario;
        }

        public async Task<Response> Handle(AlterarGrupoRequest request, CancellationToken cancellationToken)
        {
            //Validar se o requeste veio preenchido
            if (request == null)
            {
                AddNotification("Resquest", MSG.OBJETO_X0_E_OBRIGATORIO.ToFormat("Grupo"));
                return new Response(this);
            }

            var usuario = _repositoryUsuario.ObterPorId(request.IdUsuario.Value);


            if (usuario == null)
            {
                AddNotification("Usuario", MSG.X0_NAO_INFORMADO.ToFormat("Usuário"));
                return new Response(this);
            }


            Entities.Grupo grupo = _repositoryGrupo.ObterPorId(request.Id);

            grupo.AlterarGrupo(request.Nome, request.Nicho);
          

            if (grupo == null)
            {
                AddNotification("Grupo", MSG.X0_NAO_INFORMADO.ToFormat("Grupo"));
                return new Response(this);
            }

            grupo = _repositoryGrupo.Editar(grupo);

            var result = new { Id = grupo.Id, Nome = grupo.Nome, Nicho = grupo.Nicho };

            //Criar meu objeto de resposta
            var response = new Response(this, result);

            return await Task.FromResult(response);
        }
    }
}
