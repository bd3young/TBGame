using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.PresentationLayer
{
	public class GameSessionViewModel
	{

		#region FIELDS

		private Player _player;

		#endregion

		#region PROPERTIES

		public Player Player
		{
			get { return _player; }
			set { _player = value; }
		}

		#endregion

		#region METHODS

		#endregion

		#region CONSTRUCTORS

		public GameSessionViewModel()
		{

		}

		public GameSessionViewModel(Player player)
		{
			_player = player;
		}

		#endregion
	}
}
