﻿using System.Threading.Tasks;
using BlogDemo.Core.interfaces;

namespace BlogDemo.Infrastructure.DataBase
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _myContext;
        public UnitOfWork(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task<bool> SaveAsync()
        {
            return await _myContext.SaveChangesAsync()>0;
        }

    }
}