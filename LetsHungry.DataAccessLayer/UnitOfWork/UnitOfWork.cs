using LetsHungry.Core.IntRepository;
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
        private ProductCategoryRepository _productCategoryRepository;
        private ProductRepository _productRepository;
        private CommentRepository _commentRepository;
        private RezervationRepository _rezervationRepository;
        private UserRepository _userRepository;
        private RaitingRepository _raitingRepository;
        private OrderRepository _orderRepository;



        public UnitOfWork(LetsHungryDbContext db)
        {
            _db = db;
            
        }

        public IRestaurantRepository Restaurant => _restaurantRepository ??= new RestaurantRepository(_db);
        public ICategoryRepository Category => _categoryRepository ??= new CategoryRepository(_db);

        public IUserRepository User =>_userRepository ??=new UserRepository(_db);

        public ICommentRepository Comment => _commentRepository ??= new CommentRepository(_db);

        public IRaitingRepository Raiting => _raitingRepository ??= new RaitingRepository(_db);

        public IProductCategoryRepository ProductCategory=> _productCategoryRepository ??= new ProductCategoryRepository(_db);

        public IOrderRepository Order => _orderRepository ??= new OrderRepository(_db);

        public IProductRepository Product => _productRepository ??= new ProductRepository(_db);

        public IRezervationRepository Rezervation => _rezervationRepository ??= new RezervationRepository(_db);

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
