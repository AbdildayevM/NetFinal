using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetFinal.Models;
using NetFinal.Repositories;

namespace NetFinal.Services
{
    public class PartnersService
    {
        private readonly IPartnersRepository _partnersRepo;

        public PartnersService(IPartnersRepository partnersRepo)
        {
            _partnersRepo = partnersRepo;
        }

        public async Task<List<Partners>> GetPartners()
        {
            return await _partnersRepo.GetAll();
        }
    }
}
