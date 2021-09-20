using System;

namespace Library
{
    public class Student 
    {
        public int Id { get; init; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public Status Status { 
            get {
                //prevent illogical dates

                if (StartDate.CompareTo(DateTime.Now) > 0) {
                    return Status.New;
                } else if (EndDate.CompareTo(DateTime.Now) > 0 && GraduationDate.CompareTo(DateTime.Now) > 0) {
                    return Status.Active;
                } else if (EndDate.CompareTo(GraduationDate) < 0) {
                    return Status.Dropout;
                } else {
                    return Status.Graduated;
                }
            }
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public override string ToString() 
        {
            return $"Student #{Id}: {GivenName} {Surname}. Status: {Status.ToString()}.";
        } 
    }
}
