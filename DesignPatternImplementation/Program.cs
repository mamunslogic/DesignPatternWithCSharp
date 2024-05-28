using DesignPatternImplementation;

//--------  For single thread ------------
//var firstInstance = Singleton.GetInstance();
//firstInstance.Print("Print from first instance.");

//var secondInstance = Singleton.GetInstance();
//secondInstance.Print("Print from second instance.");



//----------------- For multiple thread ------------------
Parallel.Invoke
    (
                () => SingletonThreadSafe.GetInstance().Print("Print from first instance."),
                () => SingletonThreadSafe.GetInstance().Print("Print from second instance.")
    );

SingletonThreadSafe.PrintCounter();
Console.ReadLine();
