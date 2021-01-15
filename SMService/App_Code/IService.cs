using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	Student CreateStudent(Student student);
	[OperationContract]
	IEnumerable<Student> GetListStudents();

	[OperationContract]
	Student UpdateStudent(int id, Student newStudent);

	[OperationContract]
	Student DeleteStudent(int id);

	[OperationContract]
	Student GetStudentById(int id);

}
[DataContract]
public class Student
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string RoleNumber { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string Birthday { get; set; }
    [DataMember]
    public string Genre { get; set; }
    [DataMember]
    public string Email { get; set; }
    [DataMember]
    public string Introduction { get; set; }
    
    

}

// Use a data contract as illustrated in the sample below to add composite types to service operations
