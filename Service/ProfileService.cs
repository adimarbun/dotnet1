using Domain;
using Dotnet1.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProfileService
    {
        private readonly Dotnet1Context _context;
        public ProfileService(Dotnet1Context context)
        {
            this._context = context;
        }

        public ProfileService()
        {

        }

        public async Task<Profils> CreateProfile(Profils profils)
        {
            profils.Id = Guid.NewGuid();
            await _context.AddAsync(profils);
            await _context.SaveChangesAsync();
            return profils;
        }

        public async Task<List<Profils>> GetAllProfilsAsync()
        {
            //get all data profil
            var result = await _context.Profils.ToListAsync();
            return result;
        }
    }
}
