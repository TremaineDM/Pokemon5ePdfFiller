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

		private static void AddTrainerField(string value, string key)
		{
			TrainerField[key] = value;
		}

		private static void AddPokemonField(string value, string key)
		{
			PokemonField[key] = value;
		}

		public static void RenameTrainerFields(ref PdfForm form)
		{
			form.RenameField("Text-rvrF8qSgi8", "Trainer-Pokemon-name-1");
			form.RenameField("Text-NS4y9JF1gn", "Trainer-Pokemon-name-2");
			form.RenameField("Text-YRudlVwfJl", "Trainer-Pokemon-name-3");
			form.RenameField("Text-BdctFnk4tw", "Trainer-Pokemon-name-4");
			form.RenameField("Text-JzMd8Plx7y", "Trainer-Pokemon-name-5");
			form.RenameField("Text-AP3JcvNdf-", "Trainer-Pokemon-name-6");
			
			form.RenameField("Text-Jrhi4V_05t", "Trainer-Pokemon-level-1");
			form.RenameField("Text-XFl6uULCIH", "Trainer-Pokemon-level-2");
			form.RenameField("Text-_xpZJditFT", "Trainer-Pokemon-level-3");
			form.RenameField("Text-tmXlQJLNpL", "Trainer-Pokemon-level-4");
			form.RenameField("Text-BDG7yRdhnI", "Trainer-Pokemon-level-5");
			form.RenameField("Text-S5viVd7zCK", "Trainer-Pokemon-level-6");
			
			form.RenameField("Text-580EpjoXz_", "Trainer-Pokemon-Current-hp-1");
			form.RenameField("Text-altErkTqhV", "Trainer-Pokemon-Current-hp-2");
			form.RenameField("Text-J2_NgqI3xo", "Trainer-Pokemon-Current-hp-3");
			form.RenameField("Text-C1yrDzDmYV", "Trainer-Pokemon-Current-hp-4");
			form.RenameField("Text-e8Nz_NJ5-F", "Trainer-Pokemon-Current-hp-5");
			form.RenameField("Text-464EAXs_Md", "Trainer-Pokemon-Current-hp-6");
			
			form.RenameField("Text-UQmupWPuzl", "Trainer-Pokemon-Max-hp-1");
			form.RenameField("Text-TsOC70vRpW", "Trainer-Pokemon-Max-hp-2");
			form.RenameField("Text-EfWq3iHIOK", "Trainer-Pokemon-Max-hp-3");
			form.RenameField("Text-8uyODRzqus", "Trainer-Pokemon-Max-hp-4");
			form.RenameField("Text-4d6-qSK69Q", "Trainer-Pokemon-Max-hp-5");
			form.RenameField("Text-vwT8fZkFOk", "Trainer-Pokemon-Max-hp-6");
		}

		public static void RenamePokemonFields(ref PdfForm form)
		{
			{ 
				form.RenameField("Text-LGlmIY8DHa", "Pokemon1-Current-hp");
				form.RenameField("Text-rdHyxmgBD5", "Pokemon1-Max-hp");

				form.RenameField("Text-LZZ0-kmAvC", "Pokemon1-name");
				form.RenameField("Text-9uWz-EFCeh", "Pokemon1-level");
				form.RenameField("Text-6R8LLYjDe0", "Pokemon1-experience");

				form.RenameField("Text-pMsMoJog03", "Pokemon1-type1");
				form.RenameField("Text-lJyIpskbUu", "Pokemon1-type2");
				form.RenameField("Text-Se_joWC-Km", "Pokemon1-nature");

				form.RenameField("Text-yxiUwiUCyP", "Pokemon1-Str");
				form.RenameField("Text-h1gkHZDYQi", "Pokemon1-Dex");
				form.RenameField("Text-RHFSTppWOe", "Pokemon1-Con");
				form.RenameField("Text-VjW-QzXHUR", "Pokemon1-Int");
				form.RenameField("Text-wH40PlJ-Jz", "Pokemon1-Wis");
				form.RenameField("Text-XjDWe1V5rW", "Pokemon1-Cha");
				form.RenameField("CheckBox-eSir0fzSwV", "Pokemon1-Strength-Prof");
				form.RenameField("CheckBox-TP1PAErm2J", "Pokemon1-Dexterity-Prof");
				form.RenameField("CheckBox-0OXkXPELj_", "Pokemon1-Constitution-Prof");
				form.RenameField("CheckBox-VPcYjSt1E6", "Pokemon1-Intelligence-Prof");
				form.RenameField("CheckBox-oPbKbkcWal", "Pokemon1-Wisdom-Prof");
				form.RenameField("CheckBox-a2BepX7Kh1", "Pokemon1-Charisma-Prof");

				form.RenameField("Text-6OCOCLb3M8", "Pokemon1-loyalty");
				form.RenameField("Text-L31x3s10O4", "Pokemon1-armour_class");
				form.RenameField("Text-saxHXmYCX-", "Pokemon1-proficiency");
				form.RenameField("Text-56IjPo1L_T", "Pokemon1-stab");
				form.RenameField("Text-eqQDhVP7Kb", "Pokemon1-hit_dice");

				form.RenameField("Text-OAefvH9vDA", "Pokemon1-Move-1-name");
				form.RenameField("Text-S1PBlIv8Ac", "Pokemon1-Move-1-power");
				form.RenameField("Text-MZlTIGSxz0", "Pokemon1-Move-1-type");
				form.RenameField("Text-dxetUU_fOK", "Pokemon1-Move-1-range");
				form.RenameField("Text-EOS6U6HaKU", "Pokemon1-Move-1-damage");
				form.RenameField("Text-mh5iIiSwHt", "Pokemon1-Move-1-PP-Current");
				form.RenameField("Text-yx-m8Sl9yo", "Pokemon1-Move-1-PP-Max");
				form.RenameField("Paragraph-uesQnqJEjG", "Pokemon1-Move-1-notes");

				form.RenameField("Text-ZwvrMR7e0O", "Pokemon1-Move-2-name");
				form.RenameField("Text-4cZA6mJFbB", "Pokemon1-Move-2-power");
				form.RenameField("Text-aGPqIG3sr1", "Pokemon1-Move-2-type");
				form.RenameField("Text-Stv1YkSYF_", "Pokemon1-Move-2-range");
				form.RenameField("Text-K4uGtLqcLZ", "Pokemon1-Move-2-damage");
				form.RenameField("Text-g_cPaNdVs-", "Pokemon1-Move-2-PP-Current");
				form.RenameField("Text-y9j5LqdQ8e", "Pokemon1-Move-2-PP-Max");
				form.RenameField("Paragraph-xt45wAknEY", "Pokemon1-Move-2-notes");

				form.RenameField("Text-OlM_hsM1du", "Pokemon1-Move-3-name");
				form.RenameField("Text-9bRdcDDXgQ", "Pokemon1-Move-3-power");
				form.RenameField("Text-w7GS477OKq", "Pokemon1-Move-3-type");
				form.RenameField("Text-8kCT9uVEXT", "Pokemon1-Move-3-range");
				form.RenameField("Text-xdO2-jXTf7", "Pokemon1-Move-3-damage");
				form.RenameField("Text-1vIU7YwR2R", "Pokemon1-Move-3-PP-Current");
				form.RenameField("Text-mvwpvvMmBZ", "Pokemon1-Move-3-PP-Max");
				form.RenameField("Paragraph-AHwcDmb09N", "Pokemon1-Move-3-notes");

				form.RenameField("Text--qmqTLe-7Z", "Pokemon1-Move-4-name");
				form.RenameField("Text-wZjzyxy6so", "Pokemon1-Move-4-power");
				form.RenameField("Text-8BJKuzqgNr", "Pokemon1-Move-4-type");
				form.RenameField("Text-CvG9XfrkfJ", "Pokemon1-Move-4-range");
				form.RenameField("Text-3WstaOzjAq", "Pokemon1-Move-4-damage");
				form.RenameField("Text-hvMfR1qyD1", "Pokemon1-Move-4-PP-Current");
				form.RenameField("Text-nIjwmqLEA1", "Pokemon1-Move-4-PP-Max");
				form.RenameField("Paragraph-NJNJbTdmZB", "Pokemon1-Move-4-notes");

				form.RenameField("Paragraph-awtwanCk6Y", "Pokemon1-other-notes");

				form.RenameField("Text-cY8jzQ5JIm", "Pokemon1-Walk");
				form.RenameField("Text-NqScLnb6JG", "Pokemon1-Swim");
				form.RenameField("Text-h2ftCLIz8P", "Pokemon1-Fly");

				form.RenameField("Paragraph-riGMxjo7X3", "Pokemon1-vulnerabilities");
				form.RenameField("Paragraph-dkFfFLSbFe", "Pokemon1-resistances");
				form.RenameField("Paragraph-DWA2-Fn0yB", "Pokemon1-immunities");
			}

			{
				form.RenameField("Text-hl2F1acBgx", "Pokemon2-Current-hp");
				form.RenameField("Text-GFulEYxI46", "Pokemon2-Max-hp");

				form.RenameField("Text-k3NS1AWd2X", "Pokemon2-name");
				form.RenameField("Text-yCpbtgCpm0", "Pokemon2-level");
				form.RenameField("Text-fd7X3C6ECf", "Pokemon2-experience");

				form.RenameField("Text-LIwwZ6Vrzt", "Pokemon2-type1");
				form.RenameField("Text-REaT73xCjj", "Pokemon2-type2");
				form.RenameField("Text-8Xmk_KH_1c", "Pokemon2-nature");

				form.RenameField("Text-yX-BdRYj8B", "Pokemon2-Str");
				form.RenameField("Text-d7-ObH6SMg", "Pokemon2-Dex");
				form.RenameField("Text-5qsvVFBpnr", "Pokemon2-Con");
				form.RenameField("Text-SBC9wytESb", "Pokemon2-Int");
				form.RenameField("Text-1bJ59rEVtm", "Pokemon2-Wis");
				form.RenameField("Text-Z8AXGy-s8n", "Pokemon2-Cha");
				form.RenameField("CheckBox-EPoa4wdLSM", "Pokemon2-Strength-Prof");
				form.RenameField("CheckBox-7-e3iwC0Ij", "Pokemon2-Dexterity-Prof");
				form.RenameField("CheckBox-iFiEjbFk4C", "Pokemon2-Constitution-Prof");
				form.RenameField("CheckBox-MjAPjnirTc", "Pokemon2-Intelligence-Prof");
				form.RenameField("CheckBox--OPvlbZpr8", "Pokemon2-Wisdom-Prof");
				form.RenameField("CheckBox-k1WnLpZ67o", "Pokemon2-Charisma-Prof");

				form.RenameField("Text-xQOB7xGXif", "Pokemon2-loyalty");
				form.RenameField("Text-QXpXeyHVSd", "Pokemon2-armour_class");
				form.RenameField("Text-GDtuHbKQae", "Pokemon2-proficiency");
				form.RenameField("Text-rRt4G4OHkS", "Pokemon2-stab");
				form.RenameField("Text-UaZcRNK_Pn", "Pokemon2-hit_dice");

				form.RenameField("Text-GefHmWeH_c", "Pokemon2-Move-1-name");
				form.RenameField("Text-GW8RNGienm", "Pokemon2-Move-1-power");
				form.RenameField("Text-oSLRn3lupc", "Pokemon2-Move-1-type");
				form.RenameField("Text-_30nJGCOS6", "Pokemon2-Move-1-range");
				form.RenameField("Text-_lVcI5z9_R", "Pokemon2-Move-1-damage");
				form.RenameField("Text-2S9bvJO0-V", "Pokemon2-Move-1-PP-Current");
				form.RenameField("Text-eL6WMvwR60", "Pokemon2-Move-1-PP-Max");
				form.RenameField("Paragraph-7--ypPxcg9", "Pokemon2-Move-1-notes");

				form.RenameField("Text-THFLJBmAku", "Pokemon2-Move-2-name");
				form.RenameField("Text-0L-H2aFbAH", "Pokemon2-Move-2-power");
				form.RenameField("Text-TBm6wHOCXH", "Pokemon2-Move-2-type");
				form.RenameField("Text-aL3BzePYPS", "Pokemon2-Move-2-range");
				form.RenameField("Text-IWIcq_Q_bv", "Pokemon2-Move-2-damage");
				form.RenameField("Text-eLV2RftHWa", "Pokemon2-Move-2-PP-Current");
				form.RenameField("Text-XUbKsAgsM9", "Pokemon2-Move-2-PP-Max");
				form.RenameField("Paragraph-CECbbQ7tz0", "Pokemon2-Move-2-notes");

				form.RenameField("Text-abezWd4HtM", "Pokemon2-Move-3-name");
				form.RenameField("Text-E_Vs2z3LBw", "Pokemon2-Move-3-power");
				form.RenameField("Text-9t0CLEFccN", "Pokemon2-Move-3-type");
				form.RenameField("Text-670biihQPH", "Pokemon2-Move-3-range");
				form.RenameField("Text-0tlOtA5ceG", "Pokemon2-Move-3-damage");
				form.RenameField("Text-QIqrtRzDi0", "Pokemon2-Move-3-PP-Current");
				form.RenameField("Text-mwT79JoRZ5", "Pokemon2-Move-3-PP-Max");
				form.RenameField("Paragraph-_OXKVKZwSL", "Pokemon2-Move-3-notes");

				form.RenameField("Text-1cgD8HD2Xt", "Pokemon2-Move-4-name");
				form.RenameField("Text-TdhtWW8S0x", "Pokemon2-Move-4-power");
				form.RenameField("Text-ohMvDsdyKA", "Pokemon2-Move-4-type");
				form.RenameField("Text-g2nU6ihiNH", "Pokemon2-Move-4-range");
				form.RenameField("Text-xnxvygt7UY", "Pokemon2-Move-4-damage");
				form.RenameField("Text-r75x_elP-4", "Pokemon2-Move-4-PP-Current");
				form.RenameField("Text-va7mNxx2yr", "Pokemon2-Move-4-PP-Max");
				form.RenameField("Paragraph-o19JoSvyAB", "Pokemon2-Move-4-notes");

				form.RenameField("Paragraph-0-1J7P2BDN", "Pokemon2-other-notes");

				form.RenameField("Text-YmshgwyqYZ", "Pokemon2-Walk");
				form.RenameField("Text-BTtBxy4-9u", "Pokemon2-Swim");
				form.RenameField("Text-qn7GZBGM6P", "Pokemon2-Fly");

				form.RenameField("Paragraph-SLzJNCwZnF", "Pokemon2-vulnerabilities");
				form.RenameField("Paragraph-0fT0E8eCp9", "Pokemon2-resistances");
				form.RenameField("Paragraph-4BGX9LhJQ8", "Pokemon2-immunities");
			}
		}
	}
}
