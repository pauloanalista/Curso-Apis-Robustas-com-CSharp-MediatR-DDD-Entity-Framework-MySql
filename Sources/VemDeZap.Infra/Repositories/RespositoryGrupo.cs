using System;
using VemDeZap.Domain.Entities;
using VemDeZap.Domain.Interfaces.Repositories;
using VemDeZap.Infra.Repositories.Base;

namespace VemDeZap.Infra.Repositories
{
    public class RespositoryGrupo : RepositoryBase<Grupo, Guid>, IRepositoryGrupo
    {
        private readonly VemDeZapContext _context;
        public RespositoryGrupo(VemDeZapContext context) : base(context)
        {
            _context = context;
        }
    }
}
