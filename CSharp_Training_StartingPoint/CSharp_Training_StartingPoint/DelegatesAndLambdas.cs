﻿namespace CSharp_Training;

public class DelegatesAndLambdas
{
    /* TODO 16
     * Create a simple delegate (void)
     * Method with parameter (the created delegate) that invokes it
     * Action instead of custom delegate
     * Multicast delegate
     * Examples already present for the usage cases
     */

}

public static class DelegatesDemos
{
   /* public static void DemoCall()
    {
        DelegatesAndLambdas demo = new();

        demo.DoCallback(demo.DemoCallback);
        demo.DoCallbackAction(demo.DemoCallback);
    }

    public static void Delegate() // old syntax
    {
        DelegatesAndLambdas demo = new();

        demo.DoCallback(delegate { Console.WriteLine("hello there"); });
        demo.DoCallbackAction(delegate { Console.WriteLine("general kenobi"); });
    }

    public static void Lambda()
    {
        DelegatesAndLambdas demo = new();

        demo.DoCallback(() =>
        {
            Console.WriteLine("Hello World!");
        });

        demo.DoCallbackAction(() => Console.WriteLine("Hello!"));
    }

    public static void MulticastDelegate()
    {
        DelegatesAndLambdas demo = new();

        demo.MulticastDelegate(
            () => Console.WriteLine("Hello from the first delegate"), 
            () => Console.WriteLine("Hello from the second delegate"));
    }*/
}
