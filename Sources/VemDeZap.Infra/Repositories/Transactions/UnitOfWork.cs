using VemDeZap.Infra.Repositories.Base;

namespace VemDeZap.Infra.Repositories.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VemDeZapContext _context;

        public UnitOfWork(VemDeZapContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
