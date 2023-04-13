﻿using System;

//Esercizio 1 : classi astratte
//Dobbiamo realizzare un programma che rappresenti il regno animale.
//Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
//Vogliamo che gli animali abbiano i seguenti metodi
//void Dormi() (mostra a video “Zzz”)
//void Verso() (mostra a video il verso fatto dall'animale specifico)
//void Mangia() (mostra a video quello che mangia : erba, carne, ...?)
//Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
//Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.
//Esercizio 2 : interfacce Alcuni degli animali che abbiamo creato volano, altri nuotano.
//Gli animali che volano hanno il seguente metodo :
//void Vola() (mostra a video “Sto volando!!!”)
//Gli animali che nuotano hanno il seguente metodo :
//void Nuota() (mostra a video “Sto nuotando!!!”)
//Scrivere un programma avente 2 metodi :
//void FaiVolare(IVolante animale)
//void FaiNuotare(INuotante animale)
//Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
//Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.



namespace csharp_abstract_animals
{
	public  abstract class Animale
	{
        public void Dormi()
        {
            Console.WriteLine("Zzz Zzz ...");
        }

        public abstract void Verso();
        public abstract void Mangia();
    }


    public class Cane : Animale
    {
        public override void Mangia()
        {
            Console.WriteLine("Mangia croccantini");
        }

        public override void Verso()
        {
            Console.WriteLine("Abbaia");
        }
    }

    public class Passerotto : Animale, IVolante
    {
        public override void Mangia()
        {
            Console.WriteLine("Mangia semi");
        }

        public override void Verso()
        {
            Console.WriteLine("Cinguettio");
        }

        public void Vola()
        {
            Console.WriteLine("Sto Volando!");
        }
    }
}

