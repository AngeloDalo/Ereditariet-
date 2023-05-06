using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            Studente studente1 = new Studente("angelo", "dalo", "5d");
            Insegnante insegnante1 = new Insegnante("angelo2", "dalo2", "1d");
        }
    }
    class Persona
    {
        public string nome;
        public string cognome;
        public Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }
        public void Saluta()
        {
            Console.WriteLine("sono una persona");
        }
    }
    class Insegnante: Persona
    {
        public string materia;
        public Insegnante(string nome, string cognome, string materia): base(nome, cognome)
        {
            this.materia = materia;
        }
        public void Insegna()
        {

        }
    }

    class Studente: Persona
    {
        public string classe;

        public Studente (string nome, string cognome, string classe): base (nome, cognome)
        {
            this.classe = classe;   
        }
        public void Studia()
        {

        }
    }
}



