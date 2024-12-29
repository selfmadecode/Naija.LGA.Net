// See https://aka.ms/new-console-template for more information
using System;
using Naija;

internal class Program
{
    private static void Main(string[] args)
    {
        var states = Nigeria.GetStatesWithLgas();

        Console.WriteLine(states.Count());

        var state = Nigeria.GetStateWithLgas(36);
        var imo = Nigeria.GetStateWithLgas("ImO");

        Console.WriteLine(state.Name);
        Console.WriteLine(imo.Name);
        Console.WriteLine("Hello, World!");
    }
}