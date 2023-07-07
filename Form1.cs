using iText.Forms;
using iText.IO.Font;
using iText.Kernel.Pdf;
using iText.Licensing.Base;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Runtime;
using System.Text;

namespace Pokemon5ePdfFiller
{
	public partial class Pokemon5ePDFFiller : Form
	{
		public readonly string SaveFileName = "Pokemon5ePdfFiller.txt";
		public readonly string PokemonPdfOriginal = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\..\\assets\\Pokemon_5e_Pokemon_Sheet.pdf";
		public readonly string PokemonPdfModified = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\..\\assets\\Pokemon_6_Pokemon_Sheet.pdf";
		public readonly string TrainerPdfOriginal = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\..\\assets\\Pokemon_5e_Sheet.pdf";

		public readonly string PokemonPdfNew = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\..\\exports\\Pokemon_5e_Pokemon_Sheet.pdf";
		public readonly string TrainerPdfNew = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\..\\exports\\Pokemon_5e_Sheet.pdf";

		public static bool Flatten;

		public Pokemon5ePDFFiller()
		{
			InitializeComponent();

			//FileInfo LicenseInfo = new FileInfo($"{Path.GetDirectoryName(Application.ExecutablePath)}/../../../License/5a83270dd5f1d996cf7654c5dbcdb84a2b15662657a51598dc282bd90bc94ff5.json");
			//LicenseKey.LoadLicenseFile(LicenseInfo);

			if (File.Exists(Application.LocalUserAppDataPath + "/" + SaveFileName))
			{
				FileStream SaveData = new FileStream(Application.LocalUserAppDataPath + "/" + SaveFileName, FileMode.Open);
				byte[] SaveBuffer = new byte[1024];

				SaveData.Read(SaveBuffer);
				string BrowsePath = Encoding.UTF8.GetString(SaveBuffer);
				textBox1.Text = BrowsePath;
				SaveData.Close();
			}
			if(!Debugger.IsAttached) 
			{
				TemplateButton.Visible = false;
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

			label1.Text = "Exporting Trainer Data";
			label1.Refresh();

			PdfUtils.PopulateTrainerFields();

			{
				using FileStream existingTrainerFileStream = new FileStream(TrainerPdfOriginal, FileMode.Open);
				using PdfReader TrainerReader = new PdfReader(existingTrainerFileStream);
				using PdfWriter TrainerWriter = new PdfWriter(TrainerPdfNew);
				using PdfDocument OriginalTrainerDoc = new PdfDocument(TrainerReader);
				using PdfDocument TrainerDoc = new PdfDocument(TrainerWriter);

				PdfPageFormCopier formCopier = new PdfPageFormCopier();
				TrainerDoc.InitializeOutlines();

				OriginalTrainerDoc.CopyPagesTo(1, 1, TrainerDoc, formCopier);
				OriginalTrainerDoc.Close();
				TrainerReader.Close();

				PdfAcroForm TrainerStamper = PdfAcroForm.GetAcroForm(TrainerDoc, false);

				for (int PartyIndex = 1; PartyIndex <= Party.Count; PartyIndex++)
				{
					Pokemon pokemon = Party[PartyIndex - 1];

					TrainerStamper.SetField(PdfUtils.GetTrainerField($"Trainer-Pokemon-name-{PartyIndex}"), pokemon.StringMap["name"]);
					TrainerStamper.SetField(PdfUtils.GetTrainerField($"Trainer-Pokemon-level-{PartyIndex}"), pokemon.StringMap["level"]);
					TrainerStamper.SetField(PdfUtils.GetTrainerField($"Trainer-Pokemon-Current-hp-{PartyIndex}"), pokemon.GetCurrentHpString());
					TrainerStamper.SetField(PdfUtils.GetTrainerField($"Trainer-Pokemon-Max-hp-{PartyIndex}"), pokemon.Hp.Max_hp.ToString());
				}
				if(Flatten) TrainerStamper.FlattenFields();
			}

			{
				using FileStream existingFileStream = new FileStream(PokemonPdfModified, FileMode.Open);
				using PdfReader PokemonReader = new PdfReader(existingFileStream);
				using PdfWriter PokemonWriter = new PdfWriter(PokemonPdfNew);
				using PdfDocument OriginalPokemonDoc = new PdfDocument(PokemonReader);
				using PdfDocument NewPokemonDoc = new PdfDocument(PokemonWriter);

				PdfPageFormCopier PokemonFormCopier = new PdfPageFormCopier();

				OriginalPokemonDoc.CopyPagesTo(1, OriginalPokemonDoc.GetNumberOfPages(), NewPokemonDoc, PokemonFormCopier);
				PdfAcroForm PokemonForm = PdfAcroForm.GetAcroForm(NewPokemonDoc, false);
				PokemonForm.SetGenerateAppearance(true);

				for (int PartyIndex = 1; PartyIndex <= Party.Count; PartyIndex++)
				{
					label1.Text = $"Exporting pokemon {PartyIndex} data";
					label1.Refresh();

					Pokemon pokemon = Party[PartyIndex - 1];
					

					//fill the easy strings and string lists
					foreach (KeyValuePair<string, string> kvp in pokemon.StringMap)
					{
						PokemonForm.SetField($"Pokemon{PartyIndex}-{kvp.Key}", kvp.Value);
					}
					foreach (KeyValuePair<string, List<string>> kvp in pokemon.StringListMap)
					{
						string ConcatList = string.Join(", ", kvp.Value);
						PokemonForm.SetField($"Pokemon{PartyIndex}-{kvp.Key}", ConcatList);
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

					string Nickname = pokemon.ExtraStringMap.ContainsKey("nickname") ? $" / {pokemon.ExtraStringMap["nickname"]}" : "";
					string NameString = $"{pokemon.StringMap["name"]}{Nickname} {GenderSymbol}";

					PokemonForm.SetField($"Pokemon{PartyIndex}-name", NameString);
					PokemonForm.SetField($"Pokemon{PartyIndex}-Max-hp", pokemon.Hp.Max_hp);
					PokemonForm.SetField($"Pokemon{PartyIndex}-Current-hp", pokemon.GetCurrentHpString());
					PokemonForm.SetField($"Pokemon{PartyIndex}-type1", pokemon.ExtraStringListMap["type"][0]);
					PokemonForm.SetField($"Pokemon{PartyIndex}-type2", pokemon.ExtraStringListMap["type"].Count > 1 ? pokemon.ExtraStringListMap["type"][1] : " ");

					PokemonForm.SetField($"Pokemon{PartyIndex}-Str", pokemon.Attributes.STR);
					PokemonForm.SetField($"Pokemon{PartyIndex}-Dex", pokemon.Attributes.DEX);
					PokemonForm.SetField($"Pokemon{PartyIndex}-Con", pokemon.Attributes.CON);
					PokemonForm.SetField($"Pokemon{PartyIndex}-Int", pokemon.Attributes.INT);
					PokemonForm.SetField($"Pokemon{PartyIndex}-Wis", pokemon.Attributes.WIS);
					PokemonForm.SetField($"Pokemon{PartyIndex}-Cha", pokemon.Attributes.CHA);

					foreach (string item in pokemon.ExtraStringListMap["save_profs"])
					{
						if (pokemon.ExtraStringListMap["save_profs"][0] == "-")
						{
							break;
						}
						PokemonForm.SetField($"Pokemon{PartyIndex}-{item}-Prof", "Yes");
					}

					for (int MoveIndex = 0; MoveIndex < pokemon.Moves.Count; MoveIndex++)
					{
						string ConcatList = string.Join("/", pokemon.Moves[MoveIndex].Power);
						string MoveName = $"{pokemon.Moves[MoveIndex].Name} / {pokemon.Moves[MoveIndex].Time}";

						PokemonForm.SetField($"Pokemon{PartyIndex}-Move-{MoveIndex + 1}-name", MoveName);
						PokemonForm.SetField($"Pokemon{PartyIndex}-Move-{MoveIndex + 1}-type", pokemon.Moves[MoveIndex].Type);
						PokemonForm.SetField($"Pokemon{PartyIndex}-Move-{MoveIndex + 1}-range", pokemon.Moves[MoveIndex].Range);
						PokemonForm.SetField($"Pokemon{PartyIndex}-Move-{MoveIndex + 1}-damage", pokemon.Moves[MoveIndex].Damage);
						PokemonForm.SetField($"Pokemon{PartyIndex}-Move-{MoveIndex + 1}-power", ConcatList);
						PokemonForm.SetField($"Pokemon{PartyIndex}-Move-{MoveIndex + 1}-notes", pokemon.Moves[MoveIndex].Description);

						PokemonForm.SetField($"Pokemon{PartyIndex}-Move-{MoveIndex + 1}-PP-Current", pokemon.Moves[MoveIndex].pp.Current_PP);
						PokemonForm.SetField($"Pokemon{PartyIndex}-Move-{MoveIndex + 1}-PP-Max", pokemon.Moves[MoveIndex].pp.Max_PP);

					}

					PokemonForm.SetField($"Pokemon{PartyIndex}-Walk", $"{pokemon.Speeds.Walking} ft");
					PokemonForm.SetField($"Pokemon{PartyIndex}-Swim", $"{pokemon.Speeds.Swimming} ft");
					PokemonForm.SetField($"Pokemon{PartyIndex}-Fly", $"{pokemon.Speeds.Flying} ft");

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
					PokemonForm.SetField($"Pokemon{PartyIndex}-other-notes", OtherNotes);

					//int PokemonIndex = (PartyIndex % 2) + 1;
					//if (PokemonIndex == 1) { PokemonIndex = 2; }
					//else if (PokemonIndex == 2) { PokemonIndex = 1; }
					//int PokeDocIndex = (int)MathF.Ceiling((float)PartyIndex / 2.0f) - 1;

				}
				if(Flatten) PokemonForm.FlattenFields();
			}

			label1.Text = "Finished Exporting";
		}


		private void FlattenCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Flatten = !FlattenCheckBox.Checked;
		}

		private void TemplateButton_Click(object sender, EventArgs e)
		{
			//List<string> PokemonFileNames = new List<string>();
			//List<Pokemon> Party = PokemonUtils.DeserializeJsonPokemon(textBox1.Text);

			//for (int PartyIndex = 1; PartyIndex <= Party.Count; PartyIndex += 2)
			//{

			//	int PokemonIndex = (PartyIndex % 2) + 1;
			//	if (PokemonIndex == 1) { PokemonIndex = 2; }
			//	else if (PokemonIndex == 2) { PokemonIndex = 1; }
			//	int PokeDocIndex = (int)MathF.Ceiling((float)PartyIndex / 2.0f) - 1;

			//	string tempFile = PokemonPdfOriginal.Insert(PokemonPdfNew.Length - 5, PokeDocIndex.ToString());
			//	if (!PokemonFileNames.Contains(tempFile))
			//	{
			//		PokemonFileNames.Add(tempFile);
			//	}

			//	FileStream existingFileStream = new FileStream(PokemonPdfOriginal, FileMode.Open);
			//	FileStream newFileStream = new FileStream(tempFile, FileMode.Create);
			//	var pdfReader = new PdfReader(existingFileStream);
			//	var stamper = new PdfStamper(pdfReader, newFileStream);

			//	stamper.RenamePokemonPdfForms(PokeDocIndex);

			//	stamper.Dispose();
			//	pdfReader.Dispose();
			//	existingFileStream.Dispose();
			//	newFileStream.Dispose();
			//}

			//Document CompletedPokemonDoc = new Document();
			//FileStream PokeDocStream = new FileStream(PokemonPdfModified, FileMode.OpenOrCreate);
			//PdfCopy CompletedPokemonCopy = new PdfCopy(CompletedPokemonDoc, PokeDocStream);

			//CompletedPokemonDoc.Open();
			//foreach (string PokeFileName in PokemonFileNames)
			//{
			//	PdfReader reader = new PdfReader(PokeFileName);
			//	reader.ConsolidateNamedDestinations();

			//	PdfImportedPage Page = CompletedPokemonCopy.GetImportedPage(reader, 1);
			//	CompletedPokemonCopy.AddPage(Page);

			//	reader.Dispose();
			//}

			//CompletedPokemonCopy.Dispose();
			//PokeDocStream.Dispose();
			//CompletedPokemonDoc.Dispose();
			
			//label1.Text = "Template Created";
		}
	}
}