using System;

namespace Library
{
    class Library
    {
        class Student 
        {
            // int _id;
            // string _givenName;
            string _surname;
            Status _status;
            DateTime _startdate;
            DateTime _endDate;
            DateTime _graduationDate;

            public int Id { get; init; }
            public string GivenName { get; set; }
            public string Surname { get; set; }
            public Status Status { 
                get {
                    return _status;
                }
                init {
                    if (StartDate.CompareTo(DateTime.Now) > 0) {
                        _status = Status.New;
                    }
                } 
            }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public DateTime GraduationDate { get; set; }
        }
    }
}
