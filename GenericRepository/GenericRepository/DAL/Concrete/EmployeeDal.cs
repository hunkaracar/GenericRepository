using GenericRepository.DAL.Abstract;
using GenericRepository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL.Concrete
{
    public class EmployeeDal : BaseRepository<Employee>,IEmployeeDal
    {
       
    }

}
