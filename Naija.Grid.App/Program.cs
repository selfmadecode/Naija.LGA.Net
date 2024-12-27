// See https://aka.ms/new-console-template for more information
using Naija;
using Naija.LGA.Net;

var states = NaijaLGA.GetStates();

Console.WriteLine(states.Count());

var state = NaijaLGA.GetState(36);
var imo = NaijaLGA.GetState("Imo");

Console.WriteLine(state.Name);
Console.WriteLine(imo.Name);
Console.WriteLine("Hello, World!");
