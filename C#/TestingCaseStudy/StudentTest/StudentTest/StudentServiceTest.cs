using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Compatibility;
using NUnit;
using TestingCaseStudy.BuisnessLogic;
using TestingCaseStudy.Domain; 
using TestingCaseStudy.Repository;
using NUnit.Framework.Legacy;

namespace TestingCaseStudy.StudentTest
{
    [TestFixture]
    public class StudentServiceTest
    {
        private StudentService _service;

        [SetUp]
        public void Setup()
        {
            var repo = new IMemoryStudentRepository();
            _service = new StudentService(repo);
        }

        [Test]
        public void AddStudent_ShouldAddSuccessfully()
        {
            var student = new Student { RollNo = 1, Name = "John", Email = "john@example.com" };
            _service.AddStudent(student);
            var result = _service.GetStudentByRollNo(1);
            ClassicAssert.AreEqual("John", result.Name);
        }

        [Test]
        public void UpdateStudent_ShouldUpdateSuccessfully()
        {
            var student = new Student { RollNo = 2, Name = "Alice", Email = "alice@example.com" };
            _service.AddStudent(student);

            student.Name = "Alice Updated";
            _service.UpdateStudent(student);

            var updated = _service.GetStudentByRollNo(2);
            ClassicAssert.AreEqual("Alice Updated", updated.Name);
        }

        [Test]
        public void DeleteStudent_ShouldDeleteSuccessfully()
        {
            var student = new Student { RollNo = 3, Name = "Bob", Email = "bob@example.com" };
            _service.AddStudent(student);

            _service.DeleteStudent(3);

            var result = _service.GetStudentByRollNo(3);
            ClassicAssert.IsNull(result);
        }

        [Test]
        public void GetAllStudents_ShouldReturnAll()
        {
            _service.AddStudent(new Student { RollNo = 4, Name = "A", Email = "a@example.com" });
            _service.AddStudent(new Student { RollNo = 5, Name = "B", Email = "b@example.com" });

            var result = _service.GetAllStudents();
            ClassicAssert.AreEqual(2, result.Count);
        }
    }
}
