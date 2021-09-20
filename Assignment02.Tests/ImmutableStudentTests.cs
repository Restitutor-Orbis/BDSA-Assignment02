using System;
using Xunit;

namespace Library.Tests
{
    public class ImmutableStudentTests
    {
        [Fact]
        public void Equality_Of_DateTime_Objects() {
            // Assemble
            var student = new ImmutableStudent{
                Id = 100,
                GivenName = "Daddy",
                Surname = "Cool",
                StartDate = new DateTime(2021, 12, 28)
            };

            // Assert
            Assert.Equal(new DateTime(2021, 12, 28), student.StartDate);
        }

        [Fact]
        public void Equality_Of_String_Objects() {
            var student = new ImmutableStudent{
                Id = 71,
                GivenName = "Mamma",
                Surname = "Mia",
                GraduationDate = new DateTime(1995, 5, 29)
            };

            Assert.Equal("Mamma", student.GivenName);
        }

        [Fact]
        public void Equality_Of_Student_Objects() {
            var student1 = new ImmutableStudent{
                Id = 666,
                GivenName = "Ms.",
                Surname = "Jackson",
                StartDate = new DateTime(2012, 12, 12),
                EndDate = new DateTime(2021, 2, 21),
                GraduationDate = new DateTime(2021, 2, 21)
            };

            var student2 = new ImmutableStudent{
                Id = 666,
                GivenName = "Ms.",
                Surname = "Jackson",
                StartDate = new DateTime(2012, 12, 12),
                EndDate = new DateTime(2021, 2, 21),
                GraduationDate = new DateTime(2021, 2, 21)
            };

            Assert.Equal(student1, student2);
        }
    }
}
