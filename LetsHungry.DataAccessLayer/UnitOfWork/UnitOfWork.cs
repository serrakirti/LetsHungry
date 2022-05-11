﻿using LetsHungry.Core.IntRepository;
using LetsHungry.Core.IntUnitOfWork;
using LetsHungry.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsHungry.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork      
    {
        private readonly LetsHungryDbContext _db;
        private RestaurantRepository _restaurantRepository;
        private CategoryRepository _categoryRepository;
        private CommentRepository _commentRepository;
        private UserRepository _userRepository;

        public UnitOfWork(LetsHungryDbContext db)
        {
            _db = db;
            
        }

        public IRestaurantRepository Restaurant => _restaurantRepository ??= new RestaurantRepository(_db);
        public ICategoryRepository Category => _categoryRepository ??= new CategoryRepository(_db);

        public IUserRepository User =>_userRepository ??=new UserRepository(_db);

        public ICommentRepository Comment => _commentRepository ??= new CommentRepository(_db);

        public void Commit()
        {
            _db.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
