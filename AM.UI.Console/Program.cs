using AM.ApplicationCore.Domain;

// --- II. Instanciation (ex. 7) : objet créé avec le constructeur par défaut, puis propriétés ---
var plane1 = new Plane();
plane1.PlaneId = 1;
plane1.PlaneType = PlaneType.Boeing;
plane1.Capacity = 180;
plane1.ManufactureDate = new DateTime(2019, 5, 12);
Console.WriteLine("Ex.7 — avion (constructeur implicite + propriétés):");
Console.WriteLine(plane1);
Console.WriteLine();

// --- II. Instanciation (ex. 9) : constructeur à 3 paramètres supprimé (ex. 8) → initialiseur d'objet ---
// Observation : le constructeur par défaut (généré) suffit ; l’initialiseur d’objet assigne les propriétés sans constructeur dédié.
var plane3 = new Plane
{
    PlaneId = 3,
    PlaneType = PlaneType.Airbus,
    Capacity = 220,
    ManufactureDate = new DateTime(2021, 1, 15)
};
Console.WriteLine("Ex.9 — avion (initialiseur d'objet, constructeur personnalisé supprimé comme demandé):");
Console.WriteLine(plane3);
Console.WriteLine();

// --- III.10 — Polymorphisme par signature (CheckProfile) ---
var p = new Passenger
{
    FirstName = "Jean",
    LastName = "Dupont",
    EmailAddress = "jean.dupont@mail.test"
};
Console.WriteLine("Ex.10 — CheckProfile:");
Console.WriteLine($"  (a) nom + prénom: {p.CheckProfile("Dupont", "Jean")}");
Console.WriteLine($"  (b) + email explicite: {p.CheckProfile("Dupont", "Jean", "jean.dupont@mail.test")}");
string? noEmail = null;
Console.WriteLine($"  (c) paramètre email optionnel (null): {p.CheckProfile("Dupont", "Jean", noEmail)}");
Console.WriteLine();

// --- III.11 — Polymorphisme par héritage (PassengerType) ---
Console.WriteLine("Ex.11 — PassengerType:");
var passenger = new Passenger();
var staff = new Staff();
var traveller = new Traveller();

passenger.PassengerType();
staff.PassengerType();
traveller.PassengerType();
