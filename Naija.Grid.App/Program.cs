﻿// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        var states = Nigeria.GetStatesWithLgas();

        Console.WriteLine(states.Count());

        var state = Nigeria.GetStateWithLgas(37);
        var imo = Nigeria.GetStateWithLgas("ImO");

        var statesWithoutLgas = Nigeria.GetStatesWithoutLgas();

        foreach (var statesWithoutLga in statesWithoutLgas)
        {
            Console.WriteLine($"State: {statesWithoutLga.Name} - Capital:{statesWithoutLga.Capital}");
        }


        Console.WriteLine(state.Name);
        Console.WriteLine(imo.Name);
        Console.WriteLine("Hello, World!");

        var statesWithPriority = Nigeria.GetStatesWithLgas(20);
        Console.WriteLine(statesWithPriority.First().Name);
    }
}
