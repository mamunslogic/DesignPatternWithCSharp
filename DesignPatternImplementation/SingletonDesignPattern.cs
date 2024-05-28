namespace DesignPatternImplementation
{
    // 1. Make constructor private
    // 2. Create a method to get the instance which will public and static
    // 3. Declare the class as sealed

    public sealed class Singleton
    {
        private static int _counter = 0;
        private static Singleton _instance = null;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();

                _counter++;
            }

            return _instance;
        }

        private Singleton()
        {
            //_counter++;
            //Console.WriteLine("Counter Value " + _counter.ToString());
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintCounter()
        {
            Console.WriteLine("Counter Value:" + _counter.ToString());
        }
    }
}