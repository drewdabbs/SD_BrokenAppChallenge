﻿using System.Collections.Generic;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        private List<Pokemon> _pokemonTeam = new List<Pokemon>();
        //add to list (limit pokemon to 6)
        public bool AddPokemonToTeam(Pokemon pokemon)
        {
            _pokemonTeam.Add(pokemon);
            return true;
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }
        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
            pokemon.PokemonNickName = updates.PokemonNickName;
            pokemon.Level = updates.Level;
            pokemon.PokemonType = updates.PokemonType;
            pokemon.SecondaryType = updates.SecondaryType;
            pokemon.MoveOne = updates.MoveOne;
            pokemon.MoveTwo = updates.MoveTwo;
            pokemon.MoveThree = updates.MoveThree;
            pokemon.MoveFour = updates.MoveFour;
        }
        public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            for (int i=0; i < _pokemonTeam.Count; i++)
            {
                if (nickName == _pokemonTeam[i].PokemonNickName)
                {
                    _pokemonTeam[i] = newPokemon;
                }
            }
        }
        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Remove(pokemon);
        }
    }
}
