using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreEmpty1.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _student = new List<Student>();
        public MockStudentRepository() {
            _student.Add(new Student() { stu_id = 1, stu_name = "nuthana", stu_age = 22, email = "nuthana@gmail.com" });
            _student.Add(new Student() { stu_id = 2, stu_name = "nayana", stu_age = 22, email = "nayana@gmail.com" });
            _student.Add(new Student() { stu_id = 3, stu_name = "avi", stu_age = 22, email = "avi@gmail.com" });
            _student.Add(new Student() { stu_id = 4, stu_name = "namana", stu_age = 22, email = "namana@gmail.com" });
        }

        Student IStudentRepository.GetStudent(int stu_id) {
            return _student.FirstOrDefault(e => e.stu_id == stu_id);
        }
    }
}