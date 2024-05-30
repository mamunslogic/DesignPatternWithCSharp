using SingletonDesignPattern;

//--------  Singleton in Single Thread ------------
//var firstInstance = Singleton.GetInstance();
//firstInstance.Print("Print from first instance.");

//var secondInstance = Singleton.GetInstance();
//secondInstance.Print("Print from second instance.");



//----------------- Singleton in Thread Safe ------------------
Parallel.Invoke
    (
                () => SingletonThreadSafe.GetInstance().Print("Print from first instance."),
                () => SingletonThreadSafe.GetInstance().Print("Print from second instance.")
    );

SingletonThreadSafe.PrintCounter();
Console.ReadLine();
