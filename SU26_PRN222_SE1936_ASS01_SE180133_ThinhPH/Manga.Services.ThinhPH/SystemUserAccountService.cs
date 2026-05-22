using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Services.ThinhPH
{
    public class SystemUserAccountService
    {
        private readonly Repositories.ThinhPH.SystemUserAccountRepository _repository;
        public SystemUserAccountService(Repositories.ThinhPH.SystemUserAccountRepository repository)
        {
            _repository = repository;
        }
        public async Task<Entites.ThinhPH.Models.SystemUserAccount> GetUserAsync(string userName, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                {
                    throw new ArgumentException("Username and password cannot be null or empty.");
                }
                return await _repository.GetUserAsync(userName, password);
            }
            catch (ArgumentException ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Input validation error: {ex.Message}");
                return new Entites.ThinhPH.Models.SystemUserAccount(); // Return an empty user account on validation failure
            }       
        }
        public async Task<Entites.ThinhPH.Models.SystemUserAccount?> GetUserByEmailAsync(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    throw new ArgumentException("Email cannot be null or empty.");
                }
                return await _repository.GetUserByEmailAsync(email);
            }
            catch (ArgumentException ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Input validation error: {ex.Message}");
                return null; // Return null on validation failure
            }
        }
        public async Task<List<Entites.ThinhPH.Models.SystemUserAccount>> GetAllUsersAsync()
        {
            try
            {
                return await _repository.GetAllUsersAsync();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error retrieving users: {ex.Message}");
                return new List<Entites.ThinhPH.Models.SystemUserAccount>(); // Return an empty list on failure
            }
        }
    }
}
