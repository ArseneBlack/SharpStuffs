using System;

namespace Xamarin
{
	class MainClass
	{
		enum Jours
		{
			Lundi = 5, // lundi vaut 5
			Mardi, // mardi vaut 6
			Mercredi = 9, // mercredi vaut 9
			Jeudi = 10, // jeudi vaut 10
			Vendredi, // vendredi vaut 11
			Samedi, // samedi vaut 12
			Dimanche = 20 // dimanche vaut 20
		}

		public static void Main (string[] args)
		{
			Jours ein;
			ein = Jours.Dimanche;
			string phrase = "Mon prénom est \"Nicolas\" ";
			string fichier = @"c:\repertoire\fichier\fichier.css";
			string NewLine = "\n";
			Console.WriteLine (phrase);
			Console.WriteLine (fichier);
			Console.WriteLine ("Me gustaria" + Environment.NewLine + "Ser" + Environment.NewLine + "Pilot");

			Console.ReadLine ();
		}
	}
}
