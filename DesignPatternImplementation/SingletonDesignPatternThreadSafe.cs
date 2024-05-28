namespace DesignPatternImplementation
{
    // 1. Make thread safe - using Lock
    // 2. Make thread safe - using Double-Check Locking

    public sealed class SingletonThreadSafe
    {
        private static int _counter = 0;
        private static SingletonThreadSafe _instance = null;

        private static readonly object instanceLock = new();

        public static SingletonThreadSafe GetInstance()
        {
            //lock (instanceLock)
            //{
            //    if (_instance == null)
            //    {
            //        _instance = new SingletonThreadSafe();
            //        _counter++;
            //    }
            //}

            if (_instance == null)
            {
                lock (instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonThreadSafe();
                        _counter++;
                    }
                }
            }

            return _instance;
        }

        private SingletonThreadSafe()
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