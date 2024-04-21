namespace WpfAssign
{
    internal class Range
    {
        public int Start;
        public int End;

        // Constructeur pour initialiser la structure
        public Range(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Width { get { return End - Start; } }
        
    }
}
