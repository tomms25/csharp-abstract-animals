// See https://aka.ms/new-console-template for more information
using csharp_abstract_animals;

Console.WriteLine("Hello, World!");



List<Animale> animali = new List<Animale>();




var cane1 = new Cane();
animali.Add(cane1);

var passerotto1 = new Passerotto();
animali.Add(passerotto1);

var aquila1 = new Aquila();
animali.Add(aquila1);

var delfino1 = new Delfino();
animali.Add(delfino1);

var anatra = new Anatra();
animali.Add(anatra);

foreach (var animale in animali)
{
    Console.WriteLine(animale);
    animale.Dormi();
    animale.Verso();
    animale.Mangia();
    Console.WriteLine();
}

FaiVolare(aquila1);

FaiNuotare(delfino1);

FaiVolare(anatra);

FaiNuotare(anatra);




static void FaiVolare(IVolante animal)
{
    animal.Vola();
}

static void FaiNuotare(INuotante animal)
{
    animal.Nuota();
}



