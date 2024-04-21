using System;

namespace WpfAssign
{
    internal class Appointment : Range
    {
        public string id;      
        static public List<Appointment> appointments = new List<Appointment>();
        public Appointment(string Id, Range range) : base(range.Start, range.End)
        {
            this.id = Id;       
            appointments.Add(this);
        }

        public Appointment(string Id, int start, int end): base(start, end)
        {
            this.id = Id;
            appointments.Add(this);
        }
    }
}
