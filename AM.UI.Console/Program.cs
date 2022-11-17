// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using Infrastructure;
using System;

Console.WriteLine("Hello, World!");
Plane p = new Plane();
p.Capacity = 100;
//p.ManufactureDate= DateTime.Now; 
p.ManufactureDate = new DateTime(2010, 5, 23);
p.PlaneType = PlaneType.Airbus;

Console.WriteLine(p);

//Plane p2 = new Plane(PlaneType.Airbus, 100, DateTime.Now);
Plane p3 = new Plane()
{
    Capacity = 100,
    ManufactureDate = DateTime.Now,
    PlaneType = PlaneType.Boeing,
};

Console.WriteLine(p3);
//tester la methode CheckProfile
FullName fullname = new FullName();
Passenger p1 = new Passenger()
{
   FullName = new FullName {  FirstName = "Ahmed",
    LastName = "Souissi"},
    EmailAdress = "ahmed.souissi@gmail.com"
};
bool b1 = p1.CheckProfile("Ahmed", "Souissi");
bool b2 = p1.CheckProfile("Ahmed", "Souissi", "ahmed.souissi@gmail.comA");
Console.WriteLine("Instruction1 " + b1 + " Instruction2 " + b2);

//tester la methode PassengerType
Traveller t1 = new Traveller()
{
    FullName = new FullName
    {  FirstName = "Aziz",
    LastName = "Mabrouk" }
};

Staff s1 = new Staff()
{
    FullName = new FullName { FirstName = "Walid",
    LastName = "Maalej" }
};

p1.PassengerType();
t1.PassengerType();
s1.PassengerType();

ServiceFlight sf = new ServiceFlight();
sf.Flights=TestData.listFlights;
Console.WriteLine("**********partie services *****");
Console.WriteLine("get flight dates");
foreach (var f in sf.GetFlightDates("Paris")) 
Console.WriteLine(f);
Console.WriteLine("GetFlight");
sf.GetFlights("FlightDate", "01/06/2022 20:10:10");


Console.WriteLine("show flight Details ");
sf.FlightDetailDel(TestData.BoingPlane);


Console.WriteLine("show flight number ");
Console.WriteLine(sf.ProgrammedFlightNumber(new DateTime(2022, 01, 31)));


Console.WriteLine("duration average  ");
Console.WriteLine(sf.durationAvregDel("Madrid"));


Console.WriteLine("order Duration Flights  ");
foreach (Flight f in sf.OrderedDurationFlights())
    Console.WriteLine(f);

sf.DestinationGroupFlight();
/*Console.WriteLine("SeniorTravellers");
foreach (Traveller t in sf.SeniorTravellers(TestData.flight1))
    Console.WriteLine(t);*/



Console.WriteLine("passenger extention");
TestData.traveller1.UpperFullName();
Console.WriteLine(TestData.traveller1);


///**/
//Console.WriteLine("Insertion dans la base de données ");
AMContext ctx = new AMContext  ();
///*Insertion des données*/
////ctx.Planes.Add(TestData.BoingPlane);
////ctx.Planes.Add(TestData.Airbusplane);

////ctx.Flights.Add(TestData.flight1);
////ctx.Flights.Add(TestData.flight2);
////ctx.Flights.Add(TestData.flight3);
///*Persistance*/
//ctx.SaveChanges();
//Console.WriteLine("Insertion avec succés");


//Affichage des données spécifique
foreach (Flight f in ctx.Flights)
    Console.WriteLine("Destination: " + f.Destination + "Plane Capacity: " + f.Plane.Capacity);