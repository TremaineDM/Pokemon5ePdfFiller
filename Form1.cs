using IronPdf.Forms;
using iTextSharp.text.pdf;
using System.IO;
using System.Runtime;
using System.Text;

namespace Pokemon5ePdfFiller
{
	public partial class Pokemon5ePDFFiller : Form
	{
		public readonly string SaveFileName = "Pokemon5ePdfFiller.txt";
		public readonly string PokemonPdfOriginal = Application.ExecutablePath + "../../../../../assets/Pokemon_5e_Pokemon_Sheet.pdf";
		public readonly string TrainerPdfOriginal = Application.ExecutablePath + "../../../../../assets/Pokemon_5e_Sheet.pdf";


		public Pokemon5ePDFFiller()
		{
			InitializeComponent();

			if (File.Exists(Application.LocalUserAppDataPath + "/" + SaveFileName))
			{
				FileStream SaveData = new FileStream(Application.LocalUserAppDataPath + "/" + SaveFileName, FileMode.Open);
				byte[] SaveBuffer = new byte[1024];

				SaveData.Read(SaveBuffer);
				string BrowsePath = Encoding.UTF8.GetString(SaveBuffer);
				textBox1.Text = BrowsePath;
				SaveData.Close();
			}
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox1.Text = openFileDialog1.FileName;
			}
		}

		private void CreatePdf_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Path to Json file is empty");
				return;
			}
			if (!File.Exists(textBox1.Text))
			{
				MessageBox.Show($"{textBox1.Text} doesn't exist");
				return;
			}

			using (FileStream SaveData = new FileStream(Application.LocalUserAppDataPath + "/" + SaveFileName, FileMode.OpenOrCreate))
			{
				SaveData.Write(Encoding.UTF8.GetBytes(textBox1.Text));
			}

			List<Pokemon> Party = PokemonUtils.DeserializeJsonPokemon(textBox1.Text);
			
			label1.Text = "Exporting...";
			label1.Refresh();

			//using (PdfDocument TrainerDoc = PdfDocument.FromFile(TrainerPdfOriginal))
			//{
			//	if (TrainerDoc == null)
			//	{
			//		MessageBox.Show("Something went wrong with the pdf docs");
			//		return;
			//	}

			//	PdfForm TrainerForm = TrainerDoc.Form;
			//	PdfUtils.RenameTrainerFields(ref TrainerForm);

			//	for (int PartyIndex = 1; PartyIndex <= Party.Count; PartyIndex++)
			//	{
			//		Pokemon pokemon = Party[PartyIndex - 1];

			//		TrainerForm.GetFieldByName($"Trainer-Pokemon-Name-{PartyIndex}").Value = pokemon.StringMap["name"];
			//		TrainerForm.GetFieldByName($"Trainer-Pokemon-Level-{PartyIndex}").Value = pokemon.StringMap["level"];
			//		TrainerForm.GetFieldByName($"Trainer-Pokemon-Current-hp-{PartyIndex}").Value = pokemon.GetCurrentHpString();
			//		TrainerForm.GetFieldByName($"Trainer-Pokemon-Max-hp-{PartyIndex}").Value = pokemon.Hp.Max_hp.ToString();
			//	}
			//	TrainerDoc.SaveAs(Application.ExecutablePath + "../../../../../assets/PTrainerCopy.pdf");
			//	TrainerDoc.Dispose();
			//}
			using (var existingFileStream = new FileStream(TrainerPdfOriginal, FileMode.Open))
			using (var newFileStream = new FileStream(Application.ExecutablePath + "../../../../../assets/PTrainerCopy.pdf", FileMode.Create))
			{
				// Open existing PDF
				var pdfReader = new PdfReader(existingFileStream);

				// PdfStamper, which will create
				var stamper = new PdfStamper(pdfReader, newFileStream);

				AcroFields TrainerForm = stamper.AcroFields;

				for (int PartyIndex = 1; PartyIndex <= Party.Count; PartyIndex++)
				{
					Pokemon pokemon = Party[PartyIndex - 1];

					TrainerForm.SetField($"Trainer-Pokemon-Name-{PartyIndex}", pokemon.StringMap["name"]);
					stamper.PartialFormFlattening($"Trainer-Pokemon-Name-{PartyIndex}");
					TrainerForm.SetField($"Trainer-Pokemon-Level-{PartyIndex}", pokemon.StringMap["level"]);
					stamper.PartialFormFlattening($"Trainer-Pokemon-Level-{PartyIndex}");
					TrainerForm.SetField($"Trainer-Pokemon-Current-hp-{PartyIndex}", pokemon.GetCurrentHpString());
					stamper.PartialFormFlattening($"Trainer-Pokemon-Current-hp-{PartyIndex}");
					TrainerForm.SetField($"Trainer-Pokemon-Max-hp-{PartyIndex}", pokemon.Hp.Max_hp.ToString());
					stamper.PartialFormFlattening($"Trainer-Pokemon-Max-hp-{PartyIndex}");
				}

				// You can also specify fields to be flattened, which
				// leaves the rest of the form still be editable/usable

				stamper.Close();
				pdfReader.Close();
			}

			GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
			System.GC.Collect(0, GCCollectionMode.Forced, true, true);
			System.GC.WaitForPendingFinalizers();
			System.GC.Collect(0, GCCollectionMode.Forced, true, true);

			GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
			System.GC.Collect(1, GCCollectionMode.Forced, true, true);
			System.GC.WaitForPendingFinalizers();
			System.GC.Collect(1, GCCollectionMode.Forced, true, true);

			GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
			System.GC.Collect(2, GCCollectionMode.Forced, true, true);
			System.GC.WaitForPendingFinalizers();
			System.GC.Collect(2, GCCollectionMode.Forced, true, true);


			return;
			IronPdf.PdfDocument[] PokemonDocs = new IronPdf.PdfDocument[3];
			using (IronPdf.PdfDocument PokemonDocOriginal = IronPdf.PdfDocument.FromFile(PokemonPdfOriginal))
			{
				if (PokemonDocOriginal == null)
				{
					MessageBox.Show("Something went wrong with the pdf docs");
					return;
				}

				PokemonDocs[0] = new IronPdf.PdfDocument(PokemonPdfOriginal);
				PokemonDocs[1] = new IronPdf.PdfDocument(PokemonPdfOriginal);
				PokemonDocs[2] = new IronPdf.PdfDocument(PokemonPdfOriginal);
			}

			for (int i = 0; i < PokemonDocs.Length; i++)
			{
				PdfForm form = PokemonDocs[i].Form;
				PdfUtils.RenamePokemonFields(ref form);
			}

			for (int PartyIndex = 1; PartyIndex <= Party.Count; PartyIndex++)
			{
				label1.Text = $"Exporting pokemon {PartyIndex} data";
				label1.Refresh();

				Pokemon pokemon = Party[PartyIndex - 1];

				int PokemonIndex = (PartyIndex % 2) + 1;
				int PokeDocIndex = (int)MathF.Ceiling((float)PartyIndex / 2.0f) - 1;

				//fill the easy strings and string lists
				foreach (KeyValuePair<string, string> kvp in pokemon.StringMap)
				{
					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-{kvp.Key}").Value = kvp.Value;
				}
				foreach (KeyValuePair<string, List<string>> kvp in pokemon.StringListMap)
				{
					string ConcatList = string.Join(", ", kvp.Value);
					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-{kvp.Key}").Value = ConcatList;
				}

				string GenderSymbol = "";
				switch (pokemon.ExtraStringMap["gender"])
				{
					case "M":
						GenderSymbol = "♂";
						break;
					case "F":
						GenderSymbol = "♀";
						break;
					default:
						break;
				}

				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Max-hp").Value = pokemon.Hp.Max_hp;
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Current-hp").Value = pokemon.GetCurrentHpString();
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-name").Value += pokemon.ExtraStringMap.ContainsKey("nickname") ? $" / {pokemon.ExtraStringMap["nickname"]}" : "";
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-name").Value += GenderSymbol;
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-type1").Value = pokemon.ExtraStringListMap["type"][0];
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-type2").Value = pokemon.ExtraStringListMap["type"].Count > 1 ? pokemon.ExtraStringListMap["type"][1] : " ";

				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Str").Value = pokemon.Attributes.STR;
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Dex").Value = pokemon.Attributes.DEX;
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Con").Value = pokemon.Attributes.CON;
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Int").Value = pokemon.Attributes.INT;
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Wis").Value = pokemon.Attributes.WIS;
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Cha").Value = pokemon.Attributes.CHA;

				foreach (string item in pokemon.ExtraStringListMap["save_profs"])
				{
					if (pokemon.ExtraStringListMap["save_profs"][0] == "-")
					{
						break;
					}
					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-{item}-Prof").Value = "On";
				}

				for (int MoveIndex = 0; MoveIndex < pokemon.Moves.Count; MoveIndex++)
				{

					string ConcatList = string.Join("/", pokemon.Moves[MoveIndex].Power);
					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Move-{MoveIndex + 1}-name").Value = pokemon.Moves[MoveIndex].Name;
					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Move-{MoveIndex + 1}-name").Value += $" / {pokemon.Moves[MoveIndex].Time}";
					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Move-{MoveIndex + 1}-type").Value = pokemon.Moves[MoveIndex].Type;
					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Move-{MoveIndex + 1}-range").Value = pokemon.Moves[MoveIndex].Range;
					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Move-{MoveIndex + 1}-damage").Value = pokemon.Moves[MoveIndex].Damage;
					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Move-{MoveIndex + 1}-power").Value = ConcatList;

					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Move-{MoveIndex + 1}-PP-Current").Value = pokemon.Moves[MoveIndex].pp.Current_PP;
					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Move-{MoveIndex + 1}-PP-Max").Value = pokemon.Moves[MoveIndex].pp.Max_PP;

					PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Move-{MoveIndex + 1}-notes").Value = pokemon.Moves[MoveIndex].Description;
				}

				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Walk").Value = $"{pokemon.Speeds.Walking} ft";
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Swim").Value = $"{pokemon.Speeds.Swimming} ft";
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-Fly").Value = $"{pokemon.Speeds.Flying} ft";

				string OtherNotes = "";
				foreach (Ability ability in pokemon.Abilities)
				{
					OtherNotes += $"{ability.Name}: {ability.Description} - ";
				}
				foreach (Ability feat in pokemon.Feats)
				{
					OtherNotes += $"{feat.Name}: {feat.Description} - ";
				}
				if (pokemon.ExtraStringMap.ContainsKey("skills"))
				{
					OtherNotes += $"Skills: {string.Join(",", pokemon.ExtraStringMap["skills"])} - ";
				}
				if (pokemon.ExtraStringMap.ContainsKey("item"))
				{
					OtherNotes += $"Item: {pokemon.ExtraStringMap["item"]}";
				}
				PokemonDocs[PokeDocIndex].Form.GetFieldByName($"Pokemon{PokemonIndex}-other-notes").Value = OtherNotes;
			}

			using (IronPdf.PdfDocument PokemonSheetsDoc = IronPdf.PdfDocument.Merge(PokemonDocs))
			{
				PokemonSheetsDoc.SaveAs(Application.ExecutablePath + "../../../../../assets/PPokemonCopy.pdf");
			}

			foreach (IronPdf.PdfDocument PokeDoc in PokemonDocs)
			{
				PokeDoc.Dispose();
			}

			label1.Text = "Finished Exporting";
		}
	}
}