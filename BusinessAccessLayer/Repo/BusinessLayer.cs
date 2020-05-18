using DataAccessLayer.Model;
using DataAccessLayer.Model.UDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityFrameworkExtras.EF5;
using DataTransferObject.ViewModel;


namespace BusinessAccessLayer
{
    public class BusinessLayer : IBusinessLayer
    {
        private dbMvcEF2Entities _entities = new dbMvcEF2Entities();
        public IQueryable<AuthorModel> GetEmployees()
        {            
            IQueryable<AuthorModel> data = _entities.Authors
                         .Include(x => x.AuthorDetails)
                         .Include(x=>x.AuthorsBooks)
                         .Include(x => x.AuthorsBooks.Select(z => z.Book))
                         .AsQueryable()
                         .Select(x => new AuthorModel
                         {
                             AuthorId = x.AuthorId,
                             FirstName = x.FirstName,
                             LastName = x.LastName,
                             AuthorDetailModel = new AuthorDetailModel
                             {
                                 DetailId = x.AuthorDetails.Select(z => z.DetailId).FirstOrDefault(),
                                 Birthday = x.AuthorDetails.Select(z => z.Birthday).FirstOrDefault(),
                                 Address = x.AuthorDetails.Select(z => z.Address).FirstOrDefault(),
                                 DetailAuthorId = x.AuthorDetails.Select(z => z.DetailAuthorId).FirstOrDefault()
                             },
                             BookModel = new BookModel
                             {
                                 BookId = x.AuthorsBooks.Select(z=>z.Book.BookId).FirstOrDefault(),
                                 Title = x.AuthorsBooks.Select(z=>z.Book.Title).FirstOrDefault(),
                                 About = x.AuthorsBooks.Select(z=>z.Book.About).FirstOrDefault(),
                             },
                             AuthorBookModel = new AuthorBookModel
                             {
                                 MapId = x.AuthorsBooks.Select(z=>z.MapId).FirstOrDefault(),
                                 MapAuthoId = x.AuthorsBooks.Select(z=>z.MapAuthorId).FirstOrDefault(),
                                 MapBookId = x.AuthorsBooks.Select(z=>z.MapBookId).FirstOrDefault()
                             }
                         });

            return data;
        }

        public IQueryable<AuthorModel> GetEmployee(int id)
        {
           

            IQueryable<AuthorModel> data = _entities.Authors
                         .Include(x => x.AuthorDetails)
                         .Include(x=>x.AuthorsBooks)
                         .Include(x => x.AuthorsBooks.Select(z => z.Book))
                         .Select(x => new AuthorModel
                         {
                             AuthorId = x.AuthorId,
                             FirstName = x.FirstName,
                             LastName = x.LastName,
                             AuthorDetailModel = new AuthorDetailModel
                             {
                                 DetailId = x.AuthorDetails.Select(z => z.DetailId).FirstOrDefault(),
                                 Birthday = x.AuthorDetails.Select(z => z.Birthday).FirstOrDefault(),
                                 Address = x.AuthorDetails.Select(z => z.Address).FirstOrDefault(),
                                 DetailAuthorId = x.AuthorDetails.Select(z => z.DetailAuthorId).FirstOrDefault()
                             },
                             BookModel = new BookModel
                             {
                                 BookId = x.AuthorsBooks.Select(z => z.Book.BookId).FirstOrDefault(),
                                 Title = x.AuthorsBooks.Select(z => z.Book.Title).FirstOrDefault(),
                                 About = x.AuthorsBooks.Select(z => z.Book.About).FirstOrDefault(),
                             },
                             AuthorBookModel = new AuthorBookModel
                             {
                                 MapId = x.AuthorsBooks.Select(z => z.MapId).FirstOrDefault(),
                                 MapAuthoId = x.AuthorsBooks.Select(z => z.MapAuthorId).FirstOrDefault(),
                                 MapBookId = x.AuthorsBooks.Select(z => z.MapBookId).FirstOrDefault()
                             }
                         })
                         .Where(x=>x.AuthorId == id);
            return data;
        }

        public void Create(List<AuthorModel> model)
        {
            //User-define-Table type model class list
            List<UDT_InsertAuthorType> listData = new List<UDT_InsertAuthorType>();

            foreach(var data in model)
            {
                listData.Add(new UDT_InsertAuthorType
                {
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    Address = data.AuthorDetailModel.Address,
                    Birthday = data.AuthorDetailModel.Birthday,
                    Title = data.BookModel.Title,
                    About = data.BookModel.About
                });
            }

            //pass UDT list to insertBulkEmployee Sp parameter
            var procedure = new SP_InsertBulkAuthor()
            {
                InsertAuthorTypes = listData
            };

            //Now finally execute insertBulkEmployee Store procedure
            _entities.Database.ExecuteStoredProcedure(procedure);
        }

        public void Update( List<AuthorModel> model)
        {
            //User-define-Table type model class list
            List<UDT_UpdateAuthorType> listData = new List<UDT_UpdateAuthorType>();

            foreach (var data in model)
            {
                listData.Add(new UDT_UpdateAuthorType
                {
                    //id = id,
                    AuthorId = data.AuthorId,
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    DetailId = data.AuthorDetailModel.DetailId,
                    Address = data.AuthorDetailModel.Address,
                    Birthday = data.AuthorDetailModel.Birthday,
                    DetailAuthorId = data.AuthorDetailModel.DetailAuthorId,
                    BookId = data.BookModel.BookId,
                    Title = data.BookModel.Title,
                    About = data.BookModel.About,
                    MapId = data.AuthorBookModel.MapId,
                    MapAuthorId = data.AuthorBookModel.MapAuthoId,
                    MapBookId = data.AuthorBookModel.MapBookId
                });
            }

            //pass UDT list to insertBulkEmployee Sp parameter
            var procedure = new SP_UpdateAuthorType()
            {
                UpdateAuthorTypes = listData
            };

            //Now finally execute insertBulkEmployee Store procedure
            _entities.Database.ExecuteStoredProcedure(procedure);
        }

        public void Delete(List<IdModel> id)
        {
            //User-define-Table type model class list
            List<UDT_DeleteAuthorType> listData = new List<UDT_DeleteAuthorType>();

           foreach(var i in id)
            {
                listData.Add(new UDT_DeleteAuthorType
                {
                    Id = i.id
                });
            }

            //pass UDT list to insertBulkEmployee Sp parameter
            var procedure = new SP_DeleteBulkAuthor()
            {
                DeleteAuthorTypes = listData
            };

            //Now finally execute insertBulkEmployee Store procedure
            _entities.Database.ExecuteStoredProcedure(procedure);
        }
    }
}
