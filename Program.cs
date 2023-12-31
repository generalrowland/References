﻿// See https://aka.ms/new-console-template for more information
using References;

Sedan myFirstSedan = new Sedan(0);
IAutomobile myAutomobile = myFirstSedan;

Sedan myOtherSedan = new Sedan(0);

myFirstSedan.IncreaseSpeed();
Console.WriteLine(myFirstSedan.Speed);
Console.WriteLine(myAutomobile.Speed);
Console.WriteLine(myFirstSedan.Equals(myAutomobile));

myOtherSedan.IncreaseSpeed();
Console.WriteLine(myFirstSedan.Speed);
Console.WriteLine(myOtherSedan.Speed);
Console.WriteLine(myFirstSedan.Equals(myAutomobile));

Truck myTruck = new Truck(50, 500, "MyTruck");

// Calls stringify method and describes automobiles.
myFirstSedan.Stringify();
myAutomobile.Stringify();
myOtherSedan.Stringify();
myTruck.Stringify();
