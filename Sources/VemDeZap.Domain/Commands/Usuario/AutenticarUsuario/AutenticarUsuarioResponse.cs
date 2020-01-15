using System;

namespace VemDeZap.Domain.Commands.Usuario.AutenticarUsuario
{
    public class AutenticarUsuarioResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Autenticado { get; set; }

        public static explicit operator AutenticarUsuarioResponse(Entities.Usuario usuario)
        {
            return new AutenticarUsuarioResponse()
            {
                Id = usuario.Id,
                Nome = usuario.PrimeiroNome,
                Autenticado = true
            };
        }
    }
}
