using Databases;
using UI.OwnedPanel.Views;
using UiSystem;
using UnityEngine;
using Zenject;

namespace UI.OwnedPanel {
	public sealed class OwnedPanel : UiController<OwnedPanelView>, IInitializable {
		
		private readonly PlayerDatabase _playerDatabase;

		public OwnedPanel(PlayerDatabase playerDatabase) {
			Debug.Log("OwnedPanel");
			_playerDatabase = playerDatabase;
		}

		public void Initialize() {
			Debug.Log("OwnedPanel");
			foreach (var unit in _playerDatabase.Units) {
				//Debug.Log(unit);
				View.OwnedPanelBehaviour.CreateCell(unit);
			}
		}
	}
}