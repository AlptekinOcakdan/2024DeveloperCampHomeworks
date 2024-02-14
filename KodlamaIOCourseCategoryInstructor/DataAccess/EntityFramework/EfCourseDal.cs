using DataAccess.Abstracts;
using DataAccess.Repositories;
using Entity.Concretes;

namespace DataAccess.EntityFramework;

public class EfCourseDal:GenericRepository<Course>,ICourseDal
{
    
}