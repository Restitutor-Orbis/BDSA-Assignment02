using System;
using Xunit;
using System.Collections.Generic;

namespace Library.Tests
{
    public class StudentTests
    {
        public static readonly object[][] StudentDatesData =
        {
            //start date, end date, graduation date, expected status
            new object[] {new DateTime(2020, 2, 20), new DateTime(2023, 2, 20), new DateTime(2023, 2, 20), Status.Active},
            new object[] {new DateTime(2020, 2, 20), new DateTime(2021, 2, 20), new DateTime(2023, 2, 20), Status.Dropout},
            new object[] {new DateTime(2000, 1, 1),  new DateTime(2000, 12, 30), new DateTime(3000, 7, 1), Status.Dropout},
            new object[] {new DateTime(2010, 1, 1),  new DateTime(2015, 6, 29), new DateTime(2015, 6, 29), Status.Graduated},
            new object[] {new DateTime(1900, 1, 1),  new DateTime(2021, 7, 1), new DateTime(2015, 7, 1), Status.Graduated},
            new object[] {new DateTime(2022, 9, 1),  new DateTime(2025, 7, 1), new DateTime(2025, 7, 1), Status.New},
            new object[] {new DateTime(2100, 9, 1),  new DateTime(2200, 7, 1), new DateTime(2200, 7, 1), Status.New},
            
            new object[] {new DateTime(2020, 1, 1),  new DateTime(2010, 1, 1), new DateTime(2000, 7, 1), Status.Invalid},
            new object[] {new DateTime(2020, 1, 1),  new DateTime(2010, 1, 1), new DateTime(2023, 7, 1), Status.Invalid},
            new object[] {new DateTime(2120, 1, 1),  new DateTime(2023, 1, 1), new DateTime(2023, 1, 1), Status.Invalid},
        };

        [Theory, MemberData(nameof(StudentDatesData))]
        public void student_status_correctlyAssigned(DateTime startDate, DateTime endDate, DateTime graduationDate, Status expected) 
        {
            //Arrange
            Student s = new Student();
            s.StartDate = startDate;
            s.EndDate = endDate;
            s.GraduationDate = graduationDate;

            //Act
            Status actual = s.Status;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
