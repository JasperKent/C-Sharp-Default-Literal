namespace Default
{
    public struct SomeStruct
    {
        private int y;
        private string b;

        public SomeStruct(int y, string b)
        {
            this.y = y;
            this.b = b;
        }

        public override string ToString()
        {
            return $"y is {y}. b is {b ?? "null"}.";
        }
    }
}
