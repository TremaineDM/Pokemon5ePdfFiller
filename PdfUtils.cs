using iText.Forms;
using iText.Forms.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

		public static void RenameTrainerFields(this PdfAcroForm AcroForm)
		{
			AcroForm.RenameField("Text-rvrF8qSgi8", "Trainer-Pokemon-name-1");
			AcroForm.RenameField("Text-NS4y9JF1gn", "Trainer-Pokemon-name-2");
			AcroForm.RenameField("Text-YRudlVwfJl", "Trainer-Pokemon-name-3");
			AcroForm.RenameField("Text-BdctFnk4tw", "Trainer-Pokemon-name-4");
			AcroForm.RenameField("Text-JzMd8Plx7y", "Trainer-Pokemon-name-5");
			AcroForm.RenameField("Text-AP3JcvNdf-", "Trainer-Pokemon-name-6");

			AcroForm.RenameField("Text-Jrhi4V_05t", "Trainer-Pokemon-level-1");
			AcroForm.RenameField("Text-XFl6uULCIH", "Trainer-Pokemon-level-2");
			AcroForm.RenameField("Text-_xpZJditFT", "Trainer-Pokemon-level-3");
			AcroForm.RenameField("Text-tmXlQJLNpL", "Trainer-Pokemon-level-4");
			AcroForm.RenameField("Text-BDG7yRdhnI", "Trainer-Pokemon-level-5");
			AcroForm.RenameField("Text-S5viVd7zCK", "Trainer-Pokemon-level-6");

			AcroForm.RenameField("Text-580EpjoXz_", "Trainer-Pokemon-Current-hp-1");
			AcroForm.RenameField("Text-altErkTqhV", "Trainer-Pokemon-Current-hp-2");
			AcroForm.RenameField("Text-J2_NgqI3xo", "Trainer-Pokemon-Current-hp-3");
			AcroForm.RenameField("Text-C1yrDzDmYV", "Trainer-Pokemon-Current-hp-4");
			AcroForm.RenameField("Text-e8Nz_NJ5-F", "Trainer-Pokemon-Current-hp-5");
			AcroForm.RenameField("Text-464EAXs_Md", "Trainer-Pokemon-Current-hp-6");

			AcroForm.RenameField("Text-UQmupWPuzl", "Trainer-Pokemon-Max-hp-1");
			AcroForm.RenameField("Text-TsOC70vRpW", "Trainer-Pokemon-Max-hp-2");
			AcroForm.RenameField("Text-EfWq3iHIOK", "Trainer-Pokemon-Max-hp-3");
			AcroForm.RenameField("Text-8uyODRzqus", "Trainer-Pokemon-Max-hp-4");
			AcroForm.RenameField("Text-4d6-qSK69Q", "Trainer-Pokemon-Max-hp-5");
			AcroForm.RenameField("Text-vwT8fZkFOk", "Trainer-Pokemon-Max-hp-6");
		}

		public static void RenamePokemonPdfForms(this PdfAcroForm AcroForm, int Index)
		{
			{
				AcroForm.RenameField("Text-LGlmIY8DHa", $"Pokemon{Index * 2 + 1}-Current-hp");
				AcroForm.RenameField("Text-rdHyxmgBD5", $"Pokemon{Index * 2 + 1}-Max-hp");

				AcroForm.RenameField("Text-LZZ0-kmAvC", $"Pokemon{Index * 2 + 1}-name");
				AcroForm.RenameField("Text-9uWz-EFCeh", $"Pokemon{Index * 2 + 1}-level");
				AcroForm.RenameField("Text-6R8LLYjDe0", $"Pokemon{Index * 2 + 1}-experience");

				AcroForm.RenameField("Text-pMsMoJog03", $"Pokemon{Index * 2 + 1}-type1");
				AcroForm.RenameField("Text-lJyIpskbUu", $"Pokemon{Index * 2 + 1}-type2");
				AcroForm.RenameField("Text-Se_joWC-Km", $"Pokemon{Index * 2 + 1}-nature");

				AcroForm.RenameField("Text-yxiUwiUCyP", $"Pokemon{Index * 2 + 1}-Str");
				AcroForm.RenameField("Text-h1gkHZDYQi", $"Pokemon{Index * 2 + 1}-Dex");
				AcroForm.RenameField("Text-RHFSTppWOe", $"Pokemon{Index * 2 + 1}-Con");
				AcroForm.RenameField("Text-VjW-QzXHUR", $"Pokemon{Index * 2 + 1}-Int");
				AcroForm.RenameField("Text-wH40PlJ-Jz", $"Pokemon{Index * 2 + 1}-Wis");
				AcroForm.RenameField("Text-XjDWe1V5rW", $"Pokemon{Index * 2 + 1}-Cha");
				AcroForm.RenameField("CheckBox-eSir0fzSwV", $"Pokemon{Index * 2 + 1}-Strength-Prof");
				AcroForm.RenameField("CheckBox-TP1PAErm2J", $"Pokemon{Index * 2 + 1}-Dexterity-Prof");
				AcroForm.RenameField("CheckBox-0OXkXPELj_", $"Pokemon{Index * 2 + 1}-Constitution-Prof");
				AcroForm.RenameField("CheckBox-VPcYjSt1E6", $"Pokemon{Index * 2 + 1}-Intelligence-Prof");
				AcroForm.RenameField("CheckBox-oPbKbkcWal", $"Pokemon{Index * 2 + 1}-Wisdom-Prof");
				AcroForm.RenameField("CheckBox-a2BepX7Kh1", $"Pokemon{Index * 2 + 1}-Charisma-Prof");

				AcroForm.RenameField("Text-6OCOCLb3M8", $"Pokemon{Index * 2 + 1}-loyalty");
				AcroForm.RenameField("Text-L31x3s10O4", $"Pokemon{Index * 2 + 1}-armour_class");
				AcroForm.RenameField("Text-saxHXmYCX-", $"Pokemon{Index * 2 + 1}-proficiency");
				AcroForm.RenameField("Text-56IjPo1L_T", $"Pokemon{Index * 2 + 1}-stab");
				AcroForm.RenameField("Text-eqQDhVP7Kb", $"Pokemon{Index * 2 + 1}-hit_dice");

				AcroForm.RenameField("Text-OAefvH9vDA", $"Pokemon{Index * 2 + 1}-Move-1-name");
				AcroForm.RenameField("Text-S1PBlIv8Ac", $"Pokemon{Index * 2 + 1}-Move-1-power");
				AcroForm.RenameField("Text-MZlTIGSxz0", $"Pokemon{Index * 2 + 1}-Move-1-type");
				AcroForm.RenameField("Text-dxetUU_fOK", $"Pokemon{Index * 2 + 1}-Move-1-range");
				AcroForm.RenameField("Text-EOS6U6HaKU", $"Pokemon{Index * 2 + 1}-Move-1-damage");
				AcroForm.RenameField("Text-mh5iIiSwHt", $"Pokemon{Index * 2 + 1}-Move-1-PP-Current");
				AcroForm.RenameField("Text-yx-m8Sl9yo", $"Pokemon{Index * 2 + 1}-Move-1-PP-Max");
				AcroForm.RenameField("Paragraph-uesQnqJEjG", $"Pokemon{Index * 2 + 1}-Move-1-notes");

				AcroForm.RenameField("Text-ZwvrMR7e0O", $"Pokemon{Index * 2 + 1}-Move-2-name");
				AcroForm.RenameField("Text-4cZA6mJFbB", $"Pokemon{Index * 2 + 1}-Move-2-power");
				AcroForm.RenameField("Text-aGPqIG3sr1", $"Pokemon{Index * 2 + 1}-Move-2-type");
				AcroForm.RenameField("Text-Stv1YkSYF_", $"Pokemon{Index * 2 + 1}-Move-2-range");
				AcroForm.RenameField("Text-K4uGtLqcLZ", $"Pokemon{Index * 2 + 1}-Move-2-damage");
				AcroForm.RenameField("Text-g_cPaNdVs-", $"Pokemon{Index * 2 + 1}-Move-2-PP-Current");
				AcroForm.RenameField("Text-y9j5LqdQ8e", $"Pokemon{Index * 2 + 1}-Move-2-PP-Max");
				AcroForm.RenameField("Paragraph-xt45wAknEY", $"Pokemon{Index * 2 + 1}-Move-2-notes");

				AcroForm.RenameField("Text-OlM_hsM1du", $"Pokemon{Index * 2 + 1}-Move-3-name");
				AcroForm.RenameField("Text-9bRdcDDXgQ", $"Pokemon{Index * 2 + 1}-Move-3-power");
				AcroForm.RenameField("Text-w7GS477OKq", $"Pokemon{Index * 2 + 1}-Move-3-type");
				AcroForm.RenameField("Text-8kCT9uVEXT", $"Pokemon{Index * 2 + 1}-Move-3-range");
				AcroForm.RenameField("Text-xdO2-jXTf7", $"Pokemon{Index * 2 + 1}-Move-3-damage");
				AcroForm.RenameField("Text-1vIU7YwR2R", $"Pokemon{Index * 2 + 1}-Move-3-PP-Current");
				AcroForm.RenameField("Text-mvwpvvMmBZ", $"Pokemon{Index * 2 + 1}-Move-3-PP-Max");
				AcroForm.RenameField("Paragraph-AHwcDmb09N", $"Pokemon{Index * 2 + 1}-Move-3-notes");

				AcroForm.RenameField("Text--qmqTLe-7Z", $"Pokemon{Index * 2 + 1}-Move-4-name");
				AcroForm.RenameField("Text-wZjzyxy6so", $"Pokemon{Index * 2 + 1}-Move-4-power");
				AcroForm.RenameField("Text-8BJKuzqgNr", $"Pokemon{Index * 2 + 1}-Move-4-type");
				AcroForm.RenameField("Text-CvG9XfrkfJ", $"Pokemon{Index * 2 + 1}-Move-4-range");
				AcroForm.RenameField("Text-3WstaOzjAq", $"Pokemon{Index * 2 + 1}-Move-4-damage");
				AcroForm.RenameField("Text-hvMfR1qyD1", $"Pokemon{Index * 2 + 1}-Move-4-PP-Current");
				AcroForm.RenameField("Text-nIjwmqLEA1", $"Pokemon{Index * 2 + 1}-Move-4-PP-Max");
				AcroForm.RenameField("Paragraph-NJNJbTdmZB", $"Pokemon{Index * 2 + 1}-Move-4-notes");

				AcroForm.RenameField("Paragraph-awtwanCk6Y", $"Pokemon{Index * 2 + 1}-other-notes");

				AcroForm.RenameField("Text-cY8jzQ5JIm", $"Pokemon{Index * 2 + 1}-Walk");
				AcroForm.RenameField("Text-NqScLnb6JG", $"Pokemon{Index * 2 + 1}-Swim");
				AcroForm.RenameField("Text-h2ftCLIz8P", $"Pokemon{Index * 2 + 1}-Fly");

				AcroForm.RenameField("Paragraph-riGMxjo7X3", $"Pokemon{Index * 2 + 1}-vulnerabilities");
				AcroForm.RenameField("Paragraph-dkFfFLSbFe", $"Pokemon{Index * 2 + 1}-resistances");
				AcroForm.RenameField("Paragraph-DWA2-Fn0yB", $"Pokemon{Index * 2 + 1}-immunities");
			}

			{
				AcroForm.RenameField("Text-hl2F1acBgx", $"Pokemon{Index * 2 + 2}-Current-hp");
				AcroForm.RenameField("Text-GFulEYxI46", $"Pokemon{Index * 2 + 2}-Max-hp");

				AcroForm.RenameField("Text-k3NS1AWd2X", $"Pokemon{Index * 2 + 2}-name");
				AcroForm.RenameField("Text-yCpbtgCpm0", $"Pokemon{Index * 2 + 2}-level");
				AcroForm.RenameField("Text-fd7X3C6ECf", $"Pokemon{Index * 2 + 2}-experience");

				AcroForm.RenameField("Text-LIwwZ6Vrzt", $"Pokemon{Index * 2 + 2}-type1");
				AcroForm.RenameField("Text-REaT73xCjj", $"Pokemon{Index * 2 + 2}-type2");
				AcroForm.RenameField("Text-8Xmk_KH_1c", $"Pokemon{Index * 2 + 2}-nature");

				AcroForm.RenameField("Text-yX-BdRYj8B", $"Pokemon{Index * 2 + 2}-Str");
				AcroForm.RenameField("Text-d7-ObH6SMg", $"Pokemon{Index * 2 + 2}-Dex");
				AcroForm.RenameField("Text-5qsvVFBpnr", $"Pokemon{Index * 2 + 2}-Con");
				AcroForm.RenameField("Text-SBC9wytESb", $"Pokemon{Index * 2 + 2}-Int");
				AcroForm.RenameField("Text-1bJ59rEVtm", $"Pokemon{Index * 2 + 2}-Wis");
				AcroForm.RenameField("Text-Z8AXGy-s8n", $"Pokemon{Index * 2 + 2}-Cha");
				AcroForm.RenameField("CheckBox-EPoa4wdLSM", $"Pokemon{Index * 2 + 2}-Strength-Prof");
				AcroForm.RenameField("CheckBox-7-e3iwC0Ij", $"Pokemon{Index * 2 + 2}-Dexterity-Prof");
				AcroForm.RenameField("CheckBox-iFiEjbFk4C", $"Pokemon{Index * 2 + 2}-Constitution-Prof");
				AcroForm.RenameField("CheckBox-MjAPjnirTc", $"Pokemon{Index * 2 + 2}-Intelligence-Prof");
				AcroForm.RenameField("CheckBox--OPvlbZpr8", $"Pokemon{Index * 2 + 2}-Wisdom-Prof");
				AcroForm.RenameField("CheckBox-k1WnLpZ67o", $"Pokemon{Index * 2 + 2}-Charisma-Prof");

				AcroForm.RenameField("Text-xQOB7xGXif", $"Pokemon{Index * 2 + 2}-loyalty");
				AcroForm.RenameField("Text-QXpXeyHVSd", $"Pokemon{Index * 2 + 2}-armour_class");
				AcroForm.RenameField("Text-GDtuHbKQae", $"Pokemon{Index * 2 + 2}-proficiency");
				AcroForm.RenameField("Text-rRt4G4OHkS", $"Pokemon{Index * 2 + 2}-stab");
				AcroForm.RenameField("Text-UaZcRNK_Pn", $"Pokemon{Index * 2 + 2}-hit_dice");

				AcroForm.RenameField("Text-GefHmWeH_c", $"Pokemon{Index * 2 + 2}-Move-1-name");
				AcroForm.RenameField("Text-GW8RNGienm", $"Pokemon{Index * 2 + 2}-Move-1-power");
				AcroForm.RenameField("Text-oSLRn3lupc", $"Pokemon{Index * 2 + 2}-Move-1-type");
				AcroForm.RenameField("Text-_30nJGCOS6", $"Pokemon{Index * 2 + 2}-Move-1-range");
				AcroForm.RenameField("Text-_lVcI5z9_R", $"Pokemon{Index * 2 + 2}-Move-1-damage");
				AcroForm.RenameField("Text-2S9bvJO0-V", $"Pokemon{Index * 2 + 2}-Move-1-PP-Current");
				AcroForm.RenameField("Text-eL6WMvwR60", $"Pokemon{Index * 2 + 2}-Move-1-PP-Max");
				AcroForm.RenameField("Paragraph-7--ypPxcg9", $"Pokemon{Index * 2 + 2}-Move-1-notes");

				AcroForm.RenameField("Text-THFLJBmAku", $"Pokemon{Index * 2 + 2}-Move-2-name");
				AcroForm.RenameField("Text-0L-H2aFbAH", $"Pokemon{Index * 2 + 2}-Move-2-power");
				AcroForm.RenameField("Text-TBm6wHOCXH", $"Pokemon{Index * 2 + 2}-Move-2-type");
				AcroForm.RenameField("Text-aL3BzePYPS", $"Pokemon{Index * 2 + 2}-Move-2-range");
				AcroForm.RenameField("Text-IWIcq_Q_bv", $"Pokemon{Index * 2 + 2}-Move-2-damage");
				AcroForm.RenameField("Text-eLV2RftHWa", $"Pokemon{Index * 2 + 2}-Move-2-PP-Current");
				AcroForm.RenameField("Text-XUbKsAgsM9", $"Pokemon{Index * 2 + 2}-Move-2-PP-Max");
				AcroForm.RenameField("Paragraph-CECbbQ7tz0", $"Pokemon{Index * 2 + 2}-Move-2-notes");

				AcroForm.RenameField("Text-abezWd4HtM", $"Pokemon{Index * 2 + 2}-Move-3-name");
				AcroForm.RenameField("Text-E_Vs2z3LBw", $"Pokemon{Index * 2 + 2}-Move-3-power");
				AcroForm.RenameField("Text-9t0CLEFccN", $"Pokemon{Index * 2 + 2}-Move-3-type");
				AcroForm.RenameField("Text-670biihQPH", $"Pokemon{Index * 2 + 2}-Move-3-range");
				AcroForm.RenameField("Text-0tlOtA5ceG", $"Pokemon{Index * 2 + 2}-Move-3-damage");
				AcroForm.RenameField("Text-QIqrtRzDi0", $"Pokemon{Index * 2 + 2}-Move-3-PP-Current");
				AcroForm.RenameField("Text-mwT79JoRZ5", $"Pokemon{Index * 2 + 2}-Move-3-PP-Max");
				AcroForm.RenameField("Paragraph-_OXKVKZwSL", $"Pokemon{Index * 2 + 2}-Move-3-notes");

				AcroForm.RenameField("Text-1cgD8HD2Xt", $"Pokemon{Index * 2 + 2}-Move-4-name");
				AcroForm.RenameField("Text-TdhtWW8S0x", $"Pokemon{Index * 2 + 2}-Move-4-power");
				AcroForm.RenameField("Text-ohMvDsdyKA", $"Pokemon{Index * 2 + 2}-Move-4-type");
				AcroForm.RenameField("Text-g2nU6ihiNH", $"Pokemon{Index * 2 + 2}-Move-4-range");
				AcroForm.RenameField("Text-xnxvygt7UY", $"Pokemon{Index * 2 + 2}-Move-4-damage");
				AcroForm.RenameField("Text-r75x_elP-4", $"Pokemon{Index * 2 + 2}-Move-4-PP-Current");
				AcroForm.RenameField("Text-va7mNxx2yr", $"Pokemon{Index * 2 + 2}-Move-4-PP-Max");
				AcroForm.RenameField("Paragraph-o19JoSvyAB", $"Pokemon{Index * 2 + 2}-Move-4-notes");

				AcroForm.RenameField("Paragraph-0-1J7P2BDN", $"Pokemon{Index * 2 + 2}-other-notes");

				AcroForm.RenameField("Text-YmshgwyqYZ", $"Pokemon{Index * 2 + 2}-Walk");
				AcroForm.RenameField("Text-BTtBxy4-9u", $"Pokemon{Index * 2 + 2}-Swim");
				AcroForm.RenameField("Text-qn7GZBGM6P", $"Pokemon{Index * 2 + 2}-Fly");

				AcroForm.RenameField("Paragraph-SLzJNCwZnF", $"Pokemon{Index * 2 + 2}-vulnerabilities");
				AcroForm.RenameField("Paragraph-0fT0E8eCp9", $"Pokemon{Index * 2 + 2}-resistances");
				AcroForm.RenameField("Paragraph-4BGX9LhJQ8", $"Pokemon{Index * 2 + 2}-immunities");
			}
		}

		public static void SetField(this PdfAcroForm AcroForm, string FieldName, string value)
		{
			PdfFormField FoundField = AcroForm.GetField(FieldName);

			if(FoundField == null)
			{
				MessageBox.Show($"Field: \"{FieldName}\" not found in form");
			} else
			{
				try
				{
					FoundField.SetValue(value);
				}
				catch (NullReferenceException e)
				{
					Console.WriteLine($"Field: \"{FieldName}\" not set");
				}
			}

			if(Pokemon5ePDFFiller.Flatten)
			{
				AcroForm.PartialFormFlattening(FieldName);
			}
		}
	}
}
