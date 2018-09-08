using Core.Entities;
using Infrastructure.DateBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
   public  class PostService:IPostService
    {
        private IRepository<Post> _post;
        protected IUnitOfWork<MyContext> _unitofwork;
        public PostService(
          IUnitOfWork<MyContext> unitOfWork)
        {
            _unitofwork = unitOfWork;
            _post = _unitofwork.GetRepository<Post>();
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await _post.Query(r=>r.Id>1).ToListAsync();
        }
    }
}
