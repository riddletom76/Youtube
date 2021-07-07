using Grpc.Core;
using Microsoft.Extensions.Logging;
using SampleGrpcService.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleGrpcService.Services
{
    public class ClassRoomService : ClassRoom.ClassRoomBase
    {
        private readonly ILogger<ClassRoomService> logger;
        private List<Student> students = null; 
        public ClassRoomService(ILogger<ClassRoomService> logger)
        {
            this.logger = logger;
            students = new List<Student>();
            students.Add(new Student() { RollNo = 1, Name = "Student 1", EmailId = "student1@school.com" });
            students.Add(new Student() { RollNo = 2, Name = "Student 2", EmailId = "student2@school.com" });
            students.Add(new Student() { RollNo = 3, Name = "Student 3", EmailId = "student3@school.com" });
        }

        public override Task<Student> GetStudentInformation(StudentRequest request, ServerCallContext context)
        {
            return Task.FromResult(students.Where(x => x.RollNo == request.RollNo).SingleOrDefault());
        }

        public override Task<AllStudents> GetAllStudents(GetAllStudentsRequest request, ServerCallContext context){
            AllStudents allStudents = new AllStudents();
            foreach(var student in students){
                allStudents.Students.Add(student);
            }
            return Task.FromResult(allStudents);
        }
    }
}
