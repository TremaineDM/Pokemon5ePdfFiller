using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon5ePdfFiller
{
	public static class PokemonUtils
	{
		public static int GetJsonInt(this JObject item, string valueName)
		{
			JToken? TempToken;
			item.TryGetValue(valueName, out TempToken);
			if (TempToken == null)
			{
				return 0;
			}
			return (int)TempToken;
		}

		public static string GetJsonString(this JObject item, string valueName)
		{
			JToken? TempToken;
			item.TryGetValue(valueName, out TempToken);
			if (TempToken == null)
			{
				return "";
			}
			return (string?)TempToken;
		}

		public static List<string>? GetJsonStringList(this JObject item, string valueName)
		{
			JToken? TempToken;
			item.TryGetValue(valueName, out TempToken);
			if (TempToken == null)
			{
				return new List<string>();
			}
			return TempToken.Values<string>().ToList();
		}

		public static T? GetJsonObject<T>(this JObject self, string valueName) where T : new()
		{
			JToken? TempToken;
			self.TryGetValue(valueName, out TempToken);
			if(TempToken == null)
			{
				return new T();
			}
			return TempToken.ToObject<T>();
		}

		public static string GetCurrentHpString(this Pokemon pokemon)
		{
			string hp = pokemon.Hp.Current_hp;
			if(int.Parse(pokemon.Hp.Temp_hp) > 0)
			{
				hp += $"+{pokemon.Hp.Temp_hp}";
			}
			return hp;
		}

		public static void AddInfoToMap(this Pokemon pokemon, ref JObject obj, string valueName, bool extra = false)
		{
			JToken? TempToken;
			obj.TryGetValue(valueName, out TempToken);
			if (TempToken == null)
			{
				return;
			}
			if (extra) 
			{
				pokemon.ExtraStringMap.Add(valueName, TempToken.ToString());
			}
			else
			{
				pokemon.StringMap.Add(valueName, TempToken.ToString());
			}
		}

		public static void AddInfoListToMap(this Pokemon pokemon, ref JObject obj, string valueName, bool extra = false)
		{
			JToken? TempToken;
			obj.TryGetValue(valueName, out TempToken);
			if (TempToken == null)
			{
				return;
			}
			if (extra)
			{
				pokemon.ExtraStringListMap.Add(valueName, TempToken.Values<string>().ToList());
			}
			else
			{
				pokemon.StringListMap.Add(valueName, TempToken.Values<string>().ToList());
			}
		}

		public static List<Pokemon> DeserializeJsonPokemon(string FilePath)
		{
			using StreamReader reader = new(FilePath);
			var json = reader.ReadToEnd();
			reader.Dispose();
			JArray jarray = JArray.Parse(json);

			List<Pokemon> PartyPokemon = new();

			for (int PokemoIndex = 0; PokemoIndex < jarray.Count; PokemoIndex++)
			{
				JObject item = (JObject)jarray[PokemoIndex];
				Pokemon CurrentPokemon = new Pokemon();
				CurrentPokemon.AddInfoToMap(ref item, "level");
				CurrentPokemon.AddInfoToMap(ref item, "loyalty");
				CurrentPokemon.AddInfoToMap(ref item, "armour_class");
				CurrentPokemon.AddInfoToMap(ref item, "proficiency");
				CurrentPokemon.AddInfoToMap(ref item, "experience");
				CurrentPokemon.AddInfoToMap(ref item, "stab");
				CurrentPokemon.AddInfoToMap(ref item, "name");
				CurrentPokemon.AddInfoToMap(ref item, "hit_dice");
				CurrentPokemon.AddInfoToMap(ref item, "nature");
				CurrentPokemon.AddInfoToMap(ref item, "item", true);
				CurrentPokemon.AddInfoToMap(ref item, "size", true);
				CurrentPokemon.AddInfoToMap(ref item, "gender", true);
				CurrentPokemon.AddInfoToMap(ref item, "sprite", true);
				CurrentPokemon.AddInfoToMap(ref item, "nickname", true);

				CurrentPokemon.AddInfoListToMap(ref item, "immunities");
				CurrentPokemon.AddInfoListToMap(ref item, "resistances");
				CurrentPokemon.AddInfoListToMap(ref item, "vulnerabilities");
				CurrentPokemon.AddInfoListToMap(ref item, "type", true);
				CurrentPokemon.AddInfoListToMap(ref item, "skills", true);
				CurrentPokemon.AddInfoListToMap(ref item, "senses", true);
				CurrentPokemon.AddInfoListToMap(ref item, "statuses", true);
				CurrentPokemon.AddInfoListToMap(ref item, "save_profs", true);

				CurrentPokemon.Hp = item.GetJsonObject<Hp>("hp");
				CurrentPokemon.Speeds = item.GetJsonObject<Speeds>("speeds");
				CurrentPokemon.Attributes = item.GetJsonObject<Attributes>("attributes");
				CurrentPokemon.Saving_throws = item.GetJsonObject<Attributes>("saving_throws");
				CurrentPokemon.Moves = item.GetJsonObject<List<Move>>("moves");
				CurrentPokemon.Feats = item.GetJsonObject<List<Ability>>("feats");
				CurrentPokemon.Abilities = item.GetJsonObject<List<Ability>>("abilities");

				PartyPokemon.Add(CurrentPokemon);
			}
			return PartyPokemon;
		}
	}
}