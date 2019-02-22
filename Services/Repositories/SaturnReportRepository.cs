using ckl.Data;
using ckl.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ckl.Services.Repositories
{
    public interface ISaturnReportRepository
    {
        IQueryable<SaturnReport> GetSaturnReportById(Guid saturnId);
        IQueryable<SaturnReport> GetAllSaturnReports();
        EntityEntry<SaturnReport> Update(SaturnReport saturnReport);
        Task<EntityEntry<SaturnReport>> Insert(SaturnReport item);
        void Add(SaturnReport saturnReport);
        void Delete(SaturnReport saturnReport);
        void Save();
    }
    public class SaturnReportRepository : ISaturnReportRepository
    {

        public readonly ApplicationDbContext _context;

        public SaturnReportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<SaturnReport> GetSaturnReportById(Guid saturnId)
        {
            return _context.SaturnReports.Where(x => x.Id == saturnId);
        }

        public EntityEntry<SaturnReport> Update(SaturnReport saturnReport)
        {
            return _context.SaturnReports.Update(saturnReport);
        }

        public IQueryable<SaturnReport> GetAllSaturnReports()
        {
            return _context.SaturnReports;
        }

        public void Add(SaturnReport saturnReport)
        {
            _context.SaturnReports.Add(saturnReport);
            _context.SaveChanges();
        }

        public void Delete(SaturnReport saturnReport)
        {
            _context.SaturnReports.Remove(saturnReport);
            _context.SaveChanges();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Task<EntityEntry<SaturnReport>> Insert(SaturnReport item)
        {
            throw new NotImplementedException();
        }
    }
}
