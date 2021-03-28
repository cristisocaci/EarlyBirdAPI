﻿using EarlyBird.DataAccess.DTOs;
using EarlyBird.DataAccess.Entities;
using EarlyBird.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarlyBird.DataAccess.Repositories
{
    public class UsersRepositoryMock : IUsersRepository
    {
        private List<UserEntity> _users = new List<UserEntity>();

        public UserEntity GetById(Guid id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        public UserEntity GetByUsername(string username)
        {
            return _users.FirstOrDefault(x => x.Username == username);
        }
        public UserEntity Add(UserEntity user)
        {
            user.Id = Guid.NewGuid();
            _users.Add(user);
            return user;
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UpdateUserDto updateUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
