using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessLayer.Model;
using DataTransferObject.ViewModel;

namespace BusinessAccessLayer
{
    public interface IBusinessLayer
    {
        IQueryable<AuthorModel> GetEmployees();
        IQueryable<AuthorModel> GetEmployee(int id);
        void Create(List<AuthorModel> model);
        void Update( List<AuthorModel> model);
        void Delete(List<IdModel> id);
    }
}
