namespace Default
{
    public class SomeClass
    {
        private int x;
        private string a;

        public SomeClass(int x, string a)
        {
            this.x = x;
            this.a = a;
        }

        public override string ToString()
        {
            return $"x is {x}. a is {a ?? "null"}.";
        }
    }
}
