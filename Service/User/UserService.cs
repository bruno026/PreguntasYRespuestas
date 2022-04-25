using Core.Data;
using Core.Models;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<User> GetByUserName(string userName)
        {
            var user = await _unitOfWork.UserRepository.FirstOrDefault(u => u.UserName.Equals(userName));
            return user;
        }

        public async Task<int> CreateUser(User user)
        {
            var userFromBD = await GetByUserName(user.UserName);
            if (!(userFromBD != null)) 
                await _unitOfWork.UserRepository.AddAsync(user);

            return await _unitOfWork.CommitAsync();
        }
    }
}
