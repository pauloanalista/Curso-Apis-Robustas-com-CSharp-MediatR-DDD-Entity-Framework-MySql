using System;
using VemDeZap.Domain.Entities;
using VemDeZap.Domain.Interfaces.Repositories.Base;

namespace VemDeZap.Domain.Interfaces.Repositories
{
    public interface IRepositoryUsuario : IRepositoryBase<Usuario, Guid>
    {
        
    }
}
