using Newtonsoft.Json;
using StudentsAPI.Model;

namespace StudentsAPI.BisinessLayer
{
    public class StudentServiceClass : IStudenService
    {
        string IStudenService.GetStudents()
        {
            var data = new List<StudentModel>();
            StudentModel studentModel = new StudentModel();
            studentModel.Name = "Alice";
            studentModel.Age = "20";
            studentModel.Hobbies = new string[] { "reading", "swimming", "coding" };
            data.Add(studentModel);

            studentModel = new StudentModel();
            studentModel.Name = "Bob";
            studentModel.Age = "22";
            studentModel.Hobbies = new string[] { "painting", "dancing", "singing" };
            data.Add(studentModel);

            //StudentReponse studentReponse = new StudentReponse();
            //studentReponse.Students = data;
            string jsonOutput = JsonConvert.SerializeObject(data);

            return jsonOutput;
            
        }
    }
}
