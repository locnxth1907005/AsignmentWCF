using AsignmentWCF.Models;
using AsignmentWCF.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsignmentWCF.Helper
{
    public class ConvertTypeHelper
    {
        public static StudentClient ConvertServiceStudentToViewStudent(Student serviceStudent)
        {
            var stdView = new StudentClient
            {
                Id = serviceStudent.Id,
                RoleNumber = serviceStudent.RoleNumber,
                Name = serviceStudent.Name,
                Birthday = serviceStudent.Birthday,
                Email = serviceStudent.Email,
                Genre = serviceStudent.Genre,
                Introduction = serviceStudent.Introduction
            };
            return stdView;
        }

        public static Student ConvertViewStudentToServiceStudent(StudentClient studentClient)
        {
            var student = new Student
            {

                RoleNumber = studentClient.RoleNumber,
                Birthday = studentClient.Birthday,
                Email = studentClient.Email,
                Genre = studentClient.Genre,
                Introduction = studentClient.Introduction,
                Name = studentClient.Name
            };
            return student;
        }
    }
}