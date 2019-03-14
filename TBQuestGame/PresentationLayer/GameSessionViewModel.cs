using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;
using System.Collections.ObjectModel;

namespace TBQuestGame.PresentationLayer
{
	public class GameSessionViewModel
	{

		#region FIELDS

		private Player _player;
        private List<string> _messages;

        #endregion

        #region PROPERTIES

        public Player Player
		{
			get { return _player; }
			set { _player = value; }
		}

        public string MessageDisplay
        {
            get { return string.Join("\n\n", _messages); }
        }

        #endregion

        #region METHODS

        #endregion

        #region CONSTRUCTORS

        public GameSessionViewModel()
		{

		}

		public GameSessionViewModel(
            Player player,
            List<string> initialMessages)
		{
			_player = player;
            _messages = initialMessages;
		}

		#endregion
	}
}
