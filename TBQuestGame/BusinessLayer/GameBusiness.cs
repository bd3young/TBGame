using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;
using TBQuestGame.DataLayer;
using TBQuestGame.PresentationLayer;

namespace TBQuestGame.BusinessLayer
{
	public class GameBusiness
	{
		GameSessionViewModel _gameSessionViewModel;
		Player _player = new Player();
        List<string> _messages;

		public GameBusiness()
		{
			InitializeDataSet();
			InstantiateAndShowView();
		}

		private void InstantiateAndShowView()
		{
			_gameSessionViewModel = new GameSessionViewModel(_player, _messages);
			GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

			gameSessionView.DataContext = _gameSessionViewModel;

			gameSessionView.Show();
		}

		private void InitializeDataSet()
		{
			_player = GameData.PlayerData();
            _messages = GameData.InitialMessages();
		}
	}
}
