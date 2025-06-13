﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.DataAccess
{
    public class UserInfoRepo : IUserInfoRepo<UserInfo>
    {
        private readonly EventDBContext _context;

        public UserInfoRepo(EventDBContext context)
        {
            _context = context;
        }

        public List<UserInfo> GetAll()
        {
            return _context.UserInfos.ToList();
        }

        public UserInfo GetByEmail(string email)
        {
            return _context.UserInfos.FirstOrDefault(u => u.EmailId == email);
        }

        public void Add(UserInfo user)
        {
            _context.UserInfos.Add(user);
        }

        public void Update(UserInfo user)
        {
            _context.UserInfos.Update(user);
        }

        public void Delete(string email)
        {
            var user = GetByEmail(email);
            if (user != null)
                _context.UserInfos.Remove(user);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public UserInfo GetUserById(string emailId)
        {
            return _context.UserInfos.FirstOrDefault(u => u.EmailId == emailId);
        }

    }
}
