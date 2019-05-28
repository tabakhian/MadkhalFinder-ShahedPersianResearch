using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShahedPersianResearchAlgorithmGUI.Models
{
	public class Poet
	{
		public Poet()
		{
			Beats = new List<Beat>();
			Madkhals = new List<Madkhal>();
			Pages = new List<Page>();
			IsAnalysed = false;
		}

		
		public System.Collections.Generic.List<Models.Beat> Beats { get; set; }
		public int Number { get; set; }
		public string Name { get; set; }

		public bool IsAnalysed { get; set; }
		public System.Collections.Generic.List<Models.Madkhal> Madkhals { get; set; }

		public System.Collections.Generic.List<Models.Page> Pages { get; set; }

		public void Analyse(string searchLetter)
		{
			for (int p = 0; p < Pages.Count(); p++)
			{

				System.Collections.Generic.List<string> lstBeats = Pages[p].Text.Split('\n').ToList();
				lstBeats.RemoveAll(current => string.IsNullOrEmpty(current.Trim()));

				for (int i = 0; i < lstBeats.Count(); i++)
				{
					int intBeatNumber = -1;
					int searchnumberIndex = 0;
					System.Collections.Generic.List<string> lstBeatsForSearch = new List<string>();
					lstBeatsForSearch.AddRange(lstBeats);
					while (!(Regex.Match(lstBeatsForSearch[i + searchnumberIndex], @"\d+").Success))
					{
						if (i + searchnumberIndex + 1 >= lstBeatsForSearch.Count())
						{
							if (p+1 >= Pages.Count())
							{
								break;
							}
							else
							{
								System.Collections.Generic.List<string> nextPagelstBeats = Pages[p + 1].Text.Split('\n').ToList();
								nextPagelstBeats.RemoveAll(current => string.IsNullOrEmpty(current.Trim()));
								lstBeatsForSearch.AddRange(nextPagelstBeats);
								searchnumberIndex++;
							}
						}
						else
						{
							searchnumberIndex++;
						}
					}

					string number = Regex.Match(lstBeatsForSearch[i + searchnumberIndex], @"\d+").Value;
					int intBeateFindedNumber;
					if (Int32.TryParse(number, out intBeateFindedNumber))
					{
						intBeatNumber = intBeateFindedNumber - searchnumberIndex;
					}


					string strbeat = lstBeats[i].Replace("\t", "    ");
					var beatparts = strbeat.Split(new[] { "    " }, StringSplitOptions.None).ToList();
					if (beatparts.Count < 2)
					{
						continue;
					}
					Models.Beat oBeat = new Models.Beat()
					{
						FirstPart = beatparts[0].TrimStart().TrimEnd(),
						SecondPart = beatparts[1].TrimStart().TrimEnd(),
						Number = intBeatNumber,
						PageNumber = Pages[p].Number,
					};

					var firstpartSearchList = oBeat.FirstPart.Split(' ').Where(cuurent => cuurent.Replace("  ", " ").Replace(" ", "").StartsWith(searchLetter.Trim())).ToList();
					var secondpartSearchList = oBeat.SecondPart.Split(' ').Where(cuurent => cuurent.Replace("  ", " ").Replace(" ", "").StartsWith(searchLetter.Trim())).ToList();

					if (firstpartSearchList.Any())
					{
						foreach (var item in firstpartSearchList)
						{
							Models.Madkhal oMadkhal =
								new Madkhal()
								{
									Text = item.Replace("  ", " ").Replace(" ", ""),
									PoetPartContext = oBeat.FirstPart,
									PoetNumber = this.Number,
									BeatNumber = oBeat.Number,
									PageNumber = oBeat.PageNumber,
								};
							this.Madkhals.Add(oMadkhal);
						}
					}
					if (secondpartSearchList.Any())
					{
						foreach (var item in secondpartSearchList)
						{
							Models.Madkhal oMadkhal =
								new Madkhal()
								{
									Text = item.Replace("  ", " ").Replace(" ", ""),
									PoetPartContext = oBeat.SecondPart,
									PoetNumber = this.Number,
									BeatNumber = oBeat.Number,
									PageNumber = oBeat.PageNumber,
								};
							this.Madkhals.Add(oMadkhal);
						}
					}

				}

			}
			
			IsAnalysed = true;
		}

		public int FindBeatNumber(string strPageText)
		{
			int intBeatNumber = -1;

			System.Collections.Generic.List<string> lstBeats = strPageText.Split('\n').ToList();

			for (int i = 0; i < lstBeats.Count() ; i++)
			{
				int searchnumberIndex = 0;
				while (!(Regex.Match(lstBeats[i + searchnumberIndex], @"\d+").Success))
				{
					searchnumberIndex++;
				}

				string number = Regex.Match(lstBeats[i + searchnumberIndex], @"\d+").Value;
				int intBeateFindedNumber;
				if (!Int32.TryParse(number, out intBeateFindedNumber))
				{
					return (intBeatNumber);
				}
				return (intBeateFindedNumber + searchnumberIndex);
			}
			
			return (intBeatNumber);
		}
	}
}
