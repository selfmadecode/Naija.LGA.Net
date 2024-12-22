// See https://aka.ms/new-console-template for more information
using Naija.Grid.Net;

var states = NaijaGridService.GetStates();

Console.WriteLine(states.Count());

var state = NaijaGridService.GetState(36);
var imo = NaijaGridService.GetState("Imo");

Console.WriteLine(state.Name);
Console.WriteLine(imo.Name);
Console.WriteLine("Hello, World!");
