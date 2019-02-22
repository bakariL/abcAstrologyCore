using ckl.Data;
using ckl.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ckl.Services.Repositories
{
    public interface IPartnerRepository
    {
        IQueryable<Partner> GetAllPartners();
        Task<EntityEntry<Partner>> Insert(Partner item);
        EntityEntry<Partner> Update(Partner item);
        EntityEntry<Partner> Delete(Partner item);
        void Delete(IEnumerable<Partner> partners);
        void Save();
    }
    public class PartnerRepository : IPartnerRepository
    {
        private readonly ApplicationDbContext _context;

        public PartnerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public EntityEntry<Partner> Delete(Partner item)
        {
            return _context.Remove(item);
        }

        public void Delete(IEnumerable<Partner> partners)
        {
            _context.RemoveRange(partners);
        }

        public IQueryable<Partner> GetAllPartners()
        {
            return _context.Partners;
        }

        public Task<EntityEntry<Partner>> Insert(Partner item)
        {
            return _context.Partners.AddAsync(item);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public EntityEntry<Partner> Update(Partner item)
        {
            return _context.Update(item);
        }
    }
}
