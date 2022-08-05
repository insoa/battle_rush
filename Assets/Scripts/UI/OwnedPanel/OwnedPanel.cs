using Databases;
using Extensions;
using UI.OwnedPanel.Views;
using UnityEngine;
using Zenject;

namespace UI.OwnedPanel {
	public sealed class OwnedPanel : UiController<OwnedPanelView>, IInitializable {

		private readonly PlayerDatabase _playerDatabase;

		public OwnedPanel(PlayerDatabase playerDatabase) {
			_playerDatabase = playerDatabase;
		}

		public void Initialize() {
			Debug.Log(View);
			foreach (var unit in _playerDatabase.Units) {
				View.OwnedPanelBehaviour.CreateCell(unit);
			}
		}
	}
}