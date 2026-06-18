using LA.Entities;
using LA.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repositories.Implementations
{
    public class CountryRepo : ICountryRepo
    {
        private ApplicationDbContext _context;

        public CountryRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Edit(Country country)
        {
            _context.Countries.Update(country);
            _context.SaveChanges();
        }

        public IEnumerable<Country> GetAll()
        {
            return _context.Countries.ToList();
        }

        public Country GetById(int id)
        {
            return _context.Countries.Find(id);
        }

        public void RemoveData(Country country)
        {
            _context.Countries.Remove(country);
            _context.SaveChanges();
        }

        public void Save(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
        }
    }
}
