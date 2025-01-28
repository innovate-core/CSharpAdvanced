namespace CSharpAdvanced;

/// <summary>
/// Generics
/// </summary>
public static class Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
        }
    }

    public class Book
    {
    }

    public class Protuct
    {
        public string Title { get; set; }
        public float Price { get; set; }

    }


    // where T : Protuct
    // where T : struct
    // where T : class
    // where T : new()

    // where T : IComparable
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //public T Max<T>(T a, T b) where T : IComparable
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }

    // where T : Protuct
    public class DiscountCalculator<TProtuct> where TProtuct : Protuct
    {
        public float CalculateDiscount(TProtuct protuct)
        {
            return protuct.Price;
        }
    }

    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }

    public static void Run()
    {
        Console.WriteLine("Start -> Generics");

        var numbers = new GenericList<int>();
        numbers.Add(1);

        var books = new GenericList<Book>();
        books.Add(new Book());

        var dictionaty = new GenericDictionary<string, Book>();
        dictionaty.Add("1234", new Book());

        var number = new Nullable<int>(5);

        Console.WriteLine("Has Value ? " + number.HasValue); //Output : Has Value ? true
        Console.WriteLine("Value: " + number.GetValueOrDefault()); //Output: Value: 5 

        Console.WriteLine("Finish -> Generics");
    }
}
