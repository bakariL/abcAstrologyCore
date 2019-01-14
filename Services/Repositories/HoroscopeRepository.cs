using ckl.Data;
using ckl.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ckl.Services.Repositories
{
    public interface IHoroscopeRepository
    {
        IQueryable<HoroscropeReading> GetAll();
        Task<EntityEntry<HoroscropeReading>> Insert(HoroscropeReading reading);
        EntityEntry<HoroscropeReading> Update(HoroscropeReading reading);
        void Delete(HoroscropeReading reading);
        void Add(HoroscropeReading reading);
        void Save();

    }
    public class HoroscopeRepository : IHoroscopeRepository
    {
        private readonly ApplicationDbContext _context;
         public HoroscopeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(HoroscropeReading reading)
        {
            _context.HoroscropeReadings.Add(reading);
            _context.SaveChanges();
            
        }

        public void Delete(HoroscropeReading reading)
        {
            _context.HoroscropeReadings.Remove(reading);
            _context.SaveChanges();
        }

        public IQueryable<HoroscropeReading> GetAll()
        {
           return _context.HoroscropeReadings;
        }

        public Task<EntityEntry<HoroscropeReading>> Insert(HoroscropeReading reading)
        {
            return _context.HoroscropeReadings.AddAsync(reading);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public EntityEntry<HoroscropeReading> Update(HoroscropeReading reading)
        {
            return _context.HoroscropeReadings.Update( reading);
        }
    }
}
