using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreEmpty1.Models
{
    public interface IStudentRepository
    {
        Student GetStudent(int stu_id);
    }
}