using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetFinal.Controllers;
using NetFinal.Models;
using NetFinal.Data;
using Microsoft.EntityFrameworkCore;
using NetFinal.Repositories;


//will write some examples as there are a lot of methods in my controllers
//Install-Package Moq -Version 4.15.2 skachal
namespace NetFinal.Services
{
    public class UsersService
    {
        private readonly IUserRepository _clientRepo;

        public UsersService(IUserRepository clientRepo)
        {
            _clientRepo = clientRepo;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _clientRepo.GetAll();
        }

       

    }
}
