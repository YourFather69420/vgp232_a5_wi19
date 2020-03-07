using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment5.Data
{
    [XmlRoot("Pokedex")]
    public class Pokedex
    {
        [XmlArray("Pokemons")]
        [XmlArrayItem("Pokemon")]
        public List<Pokemon> Pokemons { get; set; }

        public Pokedex()
        {
            Pokemons = new List<Pokemon>();
        }

       public Pokemon GetPokemonByIndex(int index)
        {
            foreach (var item in Pokemons)
            {
                if(item.Index==index)
                {
                    return item;
                }
            }
            return null;
            //throw new NotImplementedException();
        }

       public Pokemon GetPokemonByName(string name)
        {
            foreach (var item in Pokemons)
            {
                if(item.Name==name)
                {
                    return item;
                }
            }
            return null;
            //throw new NotImplementedException();
        }

        public List<Pokemon> GetPokemonsOfType(string type)
        {
            List<Pokemon> newList = new List<Pokemon>();
            foreach (var item in Pokemons)
            {
                if(item.Type1==type||item.Type2==type)
                {
                    newList.Add(item);
                }
            }
            return newList;
            // Note to check both Type1 and Type2
            //throw new NotImplementedException();
        }

        public Pokemon GetHighestHPPokemon()
        {
            Pokemon highesthp = new Pokemon();
            foreach (var item in Pokemons)
            {
                if (highesthp.HP < item.HP)
                {
                    highesthp = item;
                }
            }
            return highesthp;
        }

       public Pokemon GetHighestAttackPokemon()
        {
            Pokemon highestattack = new Pokemon();
            foreach (var item in Pokemons)
            {
                if (highestattack.Attack<item.Attack)
                {
                    highestattack= item;
                }
            }
            return highestattack;
            //throw new NotImplementedException();
        }

        Pokemon GetHighestDefensePokemon()
        {
            Pokemon highestdefense = new Pokemon();
            foreach (var item in Pokemons)
            {
                if (highestdefense.Defense < item.Defense)
                {
                    highestdefense = item;
                }
            }
            return highestdefense;
            //throw new NotImplementedException();
        }

        Pokemon GetHighestMaxCPPokemon()
        {
            Pokemon highestcp = new Pokemon();
            foreach (var item in Pokemons)
            {
                if (highestcp.MaxCP < item.MaxCP)
                {
                    highestcp = item;
                }
            }
            return highestcp;
            //throw new NotImplementedException();
        }

    }
}
