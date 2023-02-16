
using Microsoft.EntityFrameworkCore;
using Project_1.Models;

namespace Project_1.Services
{
    public class InformationServices : IInformationServices 
    {
        private readonly ApplicationDbContext _context;

        public InformationServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Information> Add(Information information)
        {
            await _context.AddAsync(information);
            _context.SaveChanges();
            return information;
        }

        public Information Delete(Information information)
        {
           _context.Remove(information);
           _context.SaveChanges();
            return information;
        }

        public async Task<IEnumerable<Information>> GetAll()
        {
            return await _context.Informations.ToListAsync();
        }

        public async Task<Information> GetById(byte id)
        {
           return await _context.Informations.SingleOrDefaultAsync(x=> x.Id == id);
        }

        public Information update(Information information)
        {
          _context.Update(information);
            _context.SaveChanges();
            return information;
        }
    }
}
