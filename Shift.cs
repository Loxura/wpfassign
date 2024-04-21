namespace WpfAssign
{
    internal class Shift : Range
    {
        static public List<Shift> shifts = new List<Shift>();        
        public string Name; //Employee Name

        public Shift(string Name, int start, int end) : base(start, end)
        { 
            this.Name = Name.Trim();            
            shifts.Add(this);
        }

        public Shift(string employeeName, Range range) : base(range.Start, range.End)
        {
            Name = employeeName;
            shifts.Add(this);
        }
    }
}
