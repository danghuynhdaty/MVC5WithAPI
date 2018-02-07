using OnlineShop.Data.Infrastructure;
using OnlineShop.Data.Repository;
using OnlineShop.Model.Models;
using System.Collections.Generic;

namespace OnlineShop.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);

        void Update(PostCategory postCategory);

        void Delete(int ID);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParentID(int parentID);

        PostCategory GetPostCategoryByID(int ID);

        void SaveChanges();
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            _postCategoryRepository = postCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryRepository.Add(postCategory);
        }

        public void Delete(int ID)
        {
            _postCategoryRepository.Delete(ID);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentID(int parentID)
        {
            return _postCategoryRepository.GetMulti(p => p.Status && p.ParentID == parentID);
        }

        public PostCategory GetPostCategoryByID(int ID)
        {
            return _postCategoryRepository.GetSingleByID(ID);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}