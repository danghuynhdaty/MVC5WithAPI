using OnlineShop.Model.Models;
using OnlineShop.Service;
using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineShop.Web.Infrastucture.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;

        public ApiControllerBase(IErrorService errorService)
        {
            _errorService = errorService;
        }

        protected HttpResponseMessage CreateHttpRespone(HttpRequestMessage httpRequestMessage, Func<HttpResponseMessage> func)
        {
            HttpResponseMessage respone = null;
            try
            {
                respone = func.Invoke();
            }
            catch (DbEntityValidationException dbEntityEx)
            {
                foreach (var exc in dbEntityEx.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{exc.Entry.GetType().Name}\" in state \"{exc.Entry.State}\" has the following validation errors ");
                    foreach (var exce in exc.ValidationErrors)
                    {
                        Trace.WriteLine($"- Property: \"{exce.PropertyName}\", Error: \"{exce.ErrorMessage}\" ");
                    }
                }

                LogError(dbEntityEx);
                respone = httpRequestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEntityEx.InnerException.Message);
            }
            catch (DbUpdateException dbEx)
            {
                LogError(dbEx);
                respone = httpRequestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEx.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                respone = httpRequestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return respone;
        }

        private void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.CreatedDate = DateTime.Now;
                error.Message = ex.Message;
                error.StackTrace = ex.StackTrace;
                _errorService.Create(error);
                _errorService.Save();
            }
            catch
            {
            }
        }
    }
}