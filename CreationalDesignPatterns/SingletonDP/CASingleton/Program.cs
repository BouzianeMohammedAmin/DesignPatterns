
Singleton singleton = Singleton.Instance; 

sealed class Singleton
{
 public static Singleton Instance { get; } = new ();
 //private constructer
 private Singleton(){}
}