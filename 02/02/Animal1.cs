﻿namespace _02
{

    public abstract class Animal
    {
        public string Especie { get; set; }
        public abstract void EmitirSom();
    }
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau Miau");
        }
    }
    public class Porco : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("oinc oinc");
        }
    }
    public class Capivara : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("hijai");
        }
    }
}


