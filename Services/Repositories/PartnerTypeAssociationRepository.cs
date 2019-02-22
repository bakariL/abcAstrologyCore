using ckl.Data;
using ckl.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ckl.Services.Repositories
{
    public interface IPartnerTypeAssociationRepository
    {
        IQueryable<PartnerTypeAssociation> GetAll();
        Task<EntityEntry<PartnerTypeAssociation>> Insert(PartnerTypeAssociation association);
        void Delete(PartnerTypeAssociation association);
        void Add(PartnerTypeAssociation association);
        void Save();
    }

    public class PartnerTypeAssociationRepository : IPartnerTypeAssociationRepository
    {
        private readonly ApplicationDbContext _context;

        public PartnerTypeAssociationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(PartnerTypeAssociation association)
        {
            _context.PartnerTypeAssociations.Add(association);
            _context.SaveChanges();
        }

        public void Delete(PartnerTypeAssociation association)
        {
            _context.PartnerTypeAssociations.Remove(association);
            _context.SaveChanges();
        }

        public IQueryable<PartnerTypeAssociation> GetAll()
        {
            return _context.PartnerTypeAssociations;
        }

        public Task<EntityEntry<PartnerTypeAssociation>> Insert(PartnerTypeAssociation association)
        {
            return _context.PartnerTypeAssociations.AddAsync(association);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
