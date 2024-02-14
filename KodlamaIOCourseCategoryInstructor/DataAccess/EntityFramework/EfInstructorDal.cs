using DataAccess.Abstracts;
using DataAccess.Repositories;
using Entity.Concretes;

namespace DataAccess.EntityFramework;

public class EfInstructorDal:GenericRepository<Instructor>,IInstructorDal
{
    
}