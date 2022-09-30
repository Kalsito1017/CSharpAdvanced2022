using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {


        private string name;
        private int badges;
        private List<Pokemon> pokemons;
        public string Name { get { return name; } set { name = value; } }
        public int Badges { get { return badges; } set { badges = value; } }
        public List<Pokemon> Pokemon { get { return pokemons; } set { pokemons = value; } }

        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemon = new List<Pokemon>();
        }
    }
}
