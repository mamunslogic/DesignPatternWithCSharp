namespace SingletonDesignPattern
{
    //-------------- Singleton in thread safe ----------------------------
    // 1. Make thread safe - using Lock
    // 2. Make thread safe - using Double-Check Locking
    // 3. Make thread safe - using Eager Loading or Non-Lazy
    // 4. Make thread safe - using Lazy Loading or Deferred Loading means using Lazy<T>

    public sealed class SingletonThreadSafe
    {
        private static int _counter = 0;
        //private static SingletonThreadSafe _instance = null;
        //private static readonly object instanceLock = new();

        //private static readonly SingletonThreadSafe _instance = new();

        private static readonly Lazy<SingletonThreadSafe> _instance = new(() => new SingletonThreadSafe());

        public static SingletonThreadSafe GetInstance()
        {
            // -------------- Thread safe using lock ---------------
            //lock (instanceLock)
            //{
            //    if (_instance == null)
            //    {
            //        _instance = new SingletonThreadSafe();
            //        _counter++;
            //    }
            //}


            // -------------- Thread safe using double check lock ---------------
            //if (_instance == null)
            //{
            //    lock (instanceLock)
            //    {
            //        if (_instance == null)
            //        {
            //            _instance = new SingletonThreadSafe();
            //            _counter++;
            //        }
            //    }
            //}

            return _instance.Value;
        }

        private SingletonThreadSafe()
        {
            _counter++;
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