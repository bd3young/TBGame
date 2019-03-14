using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.DataLayer
{
    class GameData
    {
		public static Player PlayerData()
		{
			return new Player()
			{
				Id = 1,
				Name = "Henry",
				Age = 26,
				JobTitle = Player.JobTitleName.Theif,
				Race = Character.RaceType.FishMan,
				Health = 100,
				Lives = 3,
				Exp = 0,
				LocationId = 0
			};
		}
        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "You are a pirate that just lost his ship and his crew that has been washed ashore on an island you have never been before. " +
                "Your goal was to find the treasue said to be on a near by island. Your task is to find a ship and crew to get you on your journey again.",
                "You will begin your journey by picking from the diferent locations on the island."
            };
        }
    }
}
