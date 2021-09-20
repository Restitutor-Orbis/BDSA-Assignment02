using System;

namespace Library
{
    public record ImmutableStudent 
    {
        public int Id { get; init; }
        public string GivenName { get; init; }
        public string Surname { get; init; }
        public Status Status { 
            get {
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
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public DateTime GraduationDate { get; init; }

        public override string ToString() 
        {
            return $"Student #{Id}: {GivenName} {Surname}. Status: {Status.ToString()}.";
        } 
    }
}
