using ReposititotyPattern.Models;

namespace ReposititotyPattern.Repository
{
    public interface IStudent
    {
        List<StudentModel> getallStudent();

        StudentModel getstudentbyid(int id);
        
    }
}
