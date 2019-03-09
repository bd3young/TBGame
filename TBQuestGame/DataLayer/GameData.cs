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
    }
}
