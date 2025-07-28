using ReposititotyPattern.Models;

namespace ReposititotyPattern.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getallStudent()
        {
            return DataSourace();
        }

        public StudentModel getstudentbyid(int id)
        {
            return DataSourace().Where(x => x.id == id).FirstOrDefault();
        }

         private List<StudentModel> DataSourace()
        {
            return new List<StudentModel>
            {
                new StudentModel {id = 1 ,name = "Shubham" ,gender = "Male",age = 18 },
                new StudentModel {id = 2 ,name = "Sourabh" ,gender = "Male",age = 19 },
                new StudentModel {id = 3 ,name = "Nitesg" ,gender = "Male",age = 21 },
                new StudentModel {id = 4 ,name = "Rohan" ,gender = "Male",age = 20 },
                new StudentModel {id = 5 ,name = "Barasha" ,gender = "Female",age = 21 },
                new StudentModel {id = 6 ,name = "Das" ,gender = "Female",age = 20 }

            };
        }
    }


}
