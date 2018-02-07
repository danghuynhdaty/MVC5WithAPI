using OnlineShop.Data.Infrastructure;
using OnlineShop.Data.Repository;
using OnlineShop.Model.Models;
using System;

namespace OnlineShop.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void Save();
    }

    public class ErrorService : IErrorService
    {
        private IErrorRepository _errorRepository;
        private IUnitOfWork _unitOfWork;

        public ErrorService(IErrorRepository errorService, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorService;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}