using IronPdf.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon5ePdfFiller
{
	public static class PdfUtils
	{
		private static Dictionary<string, string> TrainerField = new Dictionary<string, string>();
		private static Dictionary<string, string> PokemonField = new Dictionary<string, string>();

		public static string GetTrainerField(string key)
		{
			return TrainerField[key];
		}

		public static string GetPokemonField(string key)
		{
			return PokemonField[key];
		}

		private static void AddTrainerField(string value, string key)
		{
			TrainerField[key] = value;
		}

		private static void AddPokemonField(string value, string key)
		{
			PokemonField[key] = value;
		}

		public static void PopulateTrainerFields()
		{
			AddTrainerField("Text-rvrF8qSgi8", "Trainer-Pokemon-name-1");
			AddTrainerField("Text-NS4y9JF1gn", "Trainer-Pokemon-name-2");
			AddTrainerField("Text-YRudlVwfJl", "Trainer-Pokemon-name-3");
			AddTrainerField("Text-BdctFnk4tw", "Trainer-Pokemon-name-4");
			AddTrainerField("Text-JzMd8Plx7y", "Trainer-Pokemon-name-5");
			AddTrainerField("Text-AP3JcvNdf-", "Trainer-Pokemon-name-6");
			
			AddTrainerField("Text-Jrhi4V_05t", "Trainer-Pokemon-level-1");
			AddTrainerField("Text-XFl6uULCIH", "Trainer-Pokemon-level-2");
			AddTrainerField("Text-_xpZJditFT", "Trainer-Pokemon-level-3");
			AddTrainerField("Text-tmXlQJLNpL", "Trainer-Pokemon-level-4");
			AddTrainerField("Text-BDG7yRdhnI", "Trainer-Pokemon-level-5");
			AddTrainerField("Text-S5viVd7zCK", "Trainer-Pokemon-level-6");
			
			AddTrainerField("Text-580EpjoXz_", "Trainer-Pokemon-Current-hp-1");
			AddTrainerField("Text-altErkTqhV", "Trainer-Pokemon-Current-hp-2");
			AddTrainerField("Text-J2_NgqI3xo", "Trainer-Pokemon-Current-hp-3");
			AddTrainerField("Text-C1yrDzDmYV", "Trainer-Pokemon-Current-hp-4");
			AddTrainerField("Text-e8Nz_NJ5-F", "Trainer-Pokemon-Current-hp-5");
			AddTrainerField("Text-464EAXs_Md", "Trainer-Pokemon-Current-hp-6");
			
			AddTrainerField("Text-UQmupWPuzl", "Trainer-Pokemon-Max-hp-1");
			AddTrainerField("Text-TsOC70vRpW", "Trainer-Pokemon-Max-hp-2");
			AddTrainerField("Text-EfWq3iHIOK", "Trainer-Pokemon-Max-hp-3");
			AddTrainerField("Text-8uyODRzqus", "Trainer-Pokemon-Max-hp-4");
			AddTrainerField("Text-4d6-qSK69Q", "Trainer-Pokemon-Max-hp-5");
			AddTrainerField("Text-vwT8fZkFOk", "Trainer-Pokemon-Max-hp-6");
		}

		public static void PopulatePokemonFields()
		{
			{ 
				AddPokemonField("Text-LGlmIY8DHa", "Pokemon1-Current-hp");
				AddPokemonField("Text-rdHyxmgBD5", "Pokemon1-Max-hp");

				AddPokemonField("Text-LZZ0-kmAvC", "Pokemon1-name");
				AddPokemonField("Text-9uWz-EFCeh", "Pokemon1-level");
				AddPokemonField("Text-6R8LLYjDe0", "Pokemon1-experience");

				AddPokemonField("Text-pMsMoJog03", "Pokemon1-type1");
				AddPokemonField("Text-lJyIpskbUu", "Pokemon1-type2");
				AddPokemonField("Text-Se_joWC-Km", "Pokemon1-nature");

				AddPokemonField("Text-yxiUwiUCyP", "Pokemon1-Str");
				AddPokemonField("Text-h1gkHZDYQi", "Pokemon1-Dex");
				AddPokemonField("Text-RHFSTppWOe", "Pokemon1-Con");
				AddPokemonField("Text-VjW-QzXHUR", "Pokemon1-Int");
				AddPokemonField("Text-wH40PlJ-Jz", "Pokemon1-Wis");
				AddPokemonField("Text-XjDWe1V5rW", "Pokemon1-Cha");
				AddPokemonField("CheckBox-eSir0fzSwV", "Pokemon1-Strength-Prof");
				AddPokemonField("CheckBox-TP1PAErm2J", "Pokemon1-Dexterity-Prof");
				AddPokemonField("CheckBox-0OXkXPELj_", "Pokemon1-Constitution-Prof");
				AddPokemonField("CheckBox-VPcYjSt1E6", "Pokemon1-Intelligence-Prof");
				AddPokemonField("CheckBox-oPbKbkcWal", "Pokemon1-Wisdom-Prof");
				AddPokemonField("CheckBox-a2BepX7Kh1", "Pokemon1-Charisma-Prof");

				AddPokemonField("Text-6OCOCLb3M8", "Pokemon1-loyalty");
				AddPokemonField("Text-L31x3s10O4", "Pokemon1-armour_class");
				AddPokemonField("Text-saxHXmYCX-", "Pokemon1-proficiency");
				AddPokemonField("Text-56IjPo1L_T", "Pokemon1-stab");
				AddPokemonField("Text-eqQDhVP7Kb", "Pokemon1-hit_dice");

				AddPokemonField("Text-OAefvH9vDA", "Pokemon1-Move-1-name");
				AddPokemonField("Text-S1PBlIv8Ac", "Pokemon1-Move-1-power");
				AddPokemonField("Text-MZlTIGSxz0", "Pokemon1-Move-1-type");
				AddPokemonField("Text-dxetUU_fOK", "Pokemon1-Move-1-range");
				AddPokemonField("Text-EOS6U6HaKU", "Pokemon1-Move-1-damage");
				AddPokemonField("Text-mh5iIiSwHt", "Pokemon1-Move-1-PP-Current");
				AddPokemonField("Text-yx-m8Sl9yo", "Pokemon1-Move-1-PP-Max");
				AddPokemonField("Paragraph-uesQnqJEjG", "Pokemon1-Move-1-notes");

				AddPokemonField("Text-ZwvrMR7e0O", "Pokemon1-Move-2-name");
				AddPokemonField("Text-4cZA6mJFbB", "Pokemon1-Move-2-power");
				AddPokemonField("Text-aGPqIG3sr1", "Pokemon1-Move-2-type");
				AddPokemonField("Text-Stv1YkSYF_", "Pokemon1-Move-2-range");
				AddPokemonField("Text-K4uGtLqcLZ", "Pokemon1-Move-2-damage");
				AddPokemonField("Text-g_cPaNdVs-", "Pokemon1-Move-2-PP-Current");
				AddPokemonField("Text-y9j5LqdQ8e", "Pokemon1-Move-2-PP-Max");
				AddPokemonField("Paragraph-xt45wAknEY", "Pokemon1-Move-2-notes");

				AddPokemonField("Text-OlM_hsM1du", "Pokemon1-Move-3-name");
				AddPokemonField("Text-9bRdcDDXgQ", "Pokemon1-Move-3-power");
				AddPokemonField("Text-w7GS477OKq", "Pokemon1-Move-3-type");
				AddPokemonField("Text-8kCT9uVEXT", "Pokemon1-Move-3-range");
				AddPokemonField("Text-xdO2-jXTf7", "Pokemon1-Move-3-damage");
				AddPokemonField("Text-1vIU7YwR2R", "Pokemon1-Move-3-PP-Current");
				AddPokemonField("Text-mvwpvvMmBZ", "Pokemon1-Move-3-PP-Max");
				AddPokemonField("Paragraph-AHwcDmb09N", "Pokemon1-Move-3-notes");

				AddPokemonField("Text--qmqTLe-7Z", "Pokemon1-Move-4-name");
				AddPokemonField("Text-wZjzyxy6so", "Pokemon1-Move-4-power");
				AddPokemonField("Text-8BJKuzqgNr", "Pokemon1-Move-4-type");
				AddPokemonField("Text-CvG9XfrkfJ", "Pokemon1-Move-4-range");
				AddPokemonField("Text-3WstaOzjAq", "Pokemon1-Move-4-damage");
				AddPokemonField("Text-hvMfR1qyD1", "Pokemon1-Move-4-PP-Current");
				AddPokemonField("Text-nIjwmqLEA1", "Pokemon1-Move-4-PP-Max");
				AddPokemonField("Paragraph-NJNJbTdmZB", "Pokemon1-Move-4-notes");

				AddPokemonField("Paragraph-awtwanCk6Y", "Pokemon1-other-notes");

				AddPokemonField("Text-cY8jzQ5JIm", "Pokemon1-Walk");
				AddPokemonField("Text-NqScLnb6JG", "Pokemon1-Swim");
				AddPokemonField("Text-h2ftCLIz8P", "Pokemon1-Fly");

				AddPokemonField("Paragraph-riGMxjo7X3", "Pokemon1-vulnerabilities");
				AddPokemonField("Paragraph-dkFfFLSbFe", "Pokemon1-resistances");
				AddPokemonField("Paragraph-DWA2-Fn0yB", "Pokemon1-immunities");
			}

			{
				AddPokemonField("Text-hl2F1acBgx", "Pokemon2-Current-hp");
				AddPokemonField("Text-GFulEYxI46", "Pokemon2-Max-hp");

				AddPokemonField("Text-k3NS1AWd2X", "Pokemon2-name");
				AddPokemonField("Text-yCpbtgCpm0", "Pokemon2-level");
				AddPokemonField("Text-fd7X3C6ECf", "Pokemon2-experience");

				AddPokemonField("Text-LIwwZ6Vrzt", "Pokemon2-type1");
				AddPokemonField("Text-REaT73xCjj", "Pokemon2-type2");
				AddPokemonField("Text-8Xmk_KH_1c", "Pokemon2-nature");

				AddPokemonField("Text-yX-BdRYj8B", "Pokemon2-Str");
				AddPokemonField("Text-d7-ObH6SMg", "Pokemon2-Dex");
				AddPokemonField("Text-5qsvVFBpnr", "Pokemon2-Con");
				AddPokemonField("Text-SBC9wytESb", "Pokemon2-Int");
				AddPokemonField("Text-1bJ59rEVtm", "Pokemon2-Wis");
				AddPokemonField("Text-Z8AXGy-s8n", "Pokemon2-Cha");
				AddPokemonField("CheckBox-EPoa4wdLSM", "Pokemon2-Strength-Prof");
				AddPokemonField("CheckBox-7-e3iwC0Ij", "Pokemon2-Dexterity-Prof");
				AddPokemonField("CheckBox-iFiEjbFk4C", "Pokemon2-Constitution-Prof");
				AddPokemonField("CheckBox-MjAPjnirTc", "Pokemon2-Intelligence-Prof");
				AddPokemonField("CheckBox--OPvlbZpr8", "Pokemon2-Wisdom-Prof");
				AddPokemonField("CheckBox-k1WnLpZ67o", "Pokemon2-Charisma-Prof");

				AddPokemonField("Text-xQOB7xGXif", "Pokemon2-loyalty");
				AddPokemonField("Text-QXpXeyHVSd", "Pokemon2-armour_class");
				AddPokemonField("Text-GDtuHbKQae", "Pokemon2-proficiency");
				AddPokemonField("Text-rRt4G4OHkS", "Pokemon2-stab");
				AddPokemonField("Text-UaZcRNK_Pn", "Pokemon2-hit_dice");

				AddPokemonField("Text-GefHmWeH_c", "Pokemon2-Move-1-name");
				AddPokemonField("Text-GW8RNGienm", "Pokemon2-Move-1-power");
				AddPokemonField("Text-oSLRn3lupc", "Pokemon2-Move-1-type");
				AddPokemonField("Text-_30nJGCOS6", "Pokemon2-Move-1-range");
				AddPokemonField("Text-_lVcI5z9_R", "Pokemon2-Move-1-damage");
				AddPokemonField("Text-2S9bvJO0-V", "Pokemon2-Move-1-PP-Current");
				AddPokemonField("Text-eL6WMvwR60", "Pokemon2-Move-1-PP-Max");
				AddPokemonField("Paragraph-7--ypPxcg9", "Pokemon2-Move-1-notes");

				AddPokemonField("Text-THFLJBmAku", "Pokemon2-Move-2-name");
				AddPokemonField("Text-0L-H2aFbAH", "Pokemon2-Move-2-power");
				AddPokemonField("Text-TBm6wHOCXH", "Pokemon2-Move-2-type");
				AddPokemonField("Text-aL3BzePYPS", "Pokemon2-Move-2-range");
				AddPokemonField("Text-IWIcq_Q_bv", "Pokemon2-Move-2-damage");
				AddPokemonField("Text-eLV2RftHWa", "Pokemon2-Move-2-PP-Current");
				AddPokemonField("Text-XUbKsAgsM9", "Pokemon2-Move-2-PP-Max");
				AddPokemonField("Paragraph-CECbbQ7tz0", "Pokemon2-Move-2-notes");

				AddPokemonField("Text-abezWd4HtM", "Pokemon2-Move-3-name");
				AddPokemonField("Text-E_Vs2z3LBw", "Pokemon2-Move-3-power");
				AddPokemonField("Text-9t0CLEFccN", "Pokemon2-Move-3-type");
				AddPokemonField("Text-670biihQPH", "Pokemon2-Move-3-range");
				AddPokemonField("Text-0tlOtA5ceG", "Pokemon2-Move-3-damage");
				AddPokemonField("Text-QIqrtRzDi0", "Pokemon2-Move-3-PP-Current");
				AddPokemonField("Text-mwT79JoRZ5", "Pokemon2-Move-3-PP-Max");
				AddPokemonField("Paragraph-_OXKVKZwSL", "Pokemon2-Move-3-notes");

				AddPokemonField("Text-1cgD8HD2Xt", "Pokemon2-Move-4-name");
				AddPokemonField("Text-TdhtWW8S0x", "Pokemon2-Move-4-power");
				AddPokemonField("Text-ohMvDsdyKA", "Pokemon2-Move-4-type");
				AddPokemonField("Text-g2nU6ihiNH", "Pokemon2-Move-4-range");
				AddPokemonField("Text-xnxvygt7UY", "Pokemon2-Move-4-damage");
				AddPokemonField("Text-r75x_elP-4", "Pokemon2-Move-4-PP-Current");
				AddPokemonField("Text-va7mNxx2yr", "Pokemon2-Move-4-PP-Max");
				AddPokemonField("Paragraph-o19JoSvyAB", "Pokemon2-Move-4-notes");

				AddPokemonField("Paragraph-0-1J7P2BDN", "Pokemon2-other-notes");

				AddPokemonField("Text-YmshgwyqYZ", "Pokemon2-Walk");
				AddPokemonField("Text-BTtBxy4-9u", "Pokemon2-Swim");
				AddPokemonField("Text-qn7GZBGM6P", "Pokemon2-Fly");

				AddPokemonField("Paragraph-SLzJNCwZnF", "Pokemon2-vulnerabilities");
				AddPokemonField("Paragraph-0fT0E8eCp9", "Pokemon2-resistances");
				AddPokemonField("Paragraph-4BGX9LhJQ8", "Pokemon2-immunities");
			}
		}
	}
}
