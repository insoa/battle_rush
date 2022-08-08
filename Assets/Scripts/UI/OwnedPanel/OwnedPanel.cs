using System;
using Databases;
using Extensions;
using UI.OwnedPanel.Views;
using UniRx;
using Zenject;

namespace UI.OwnedPanel {
	public sealed class OwnedPanel : UiController<OwnedPanelView>, IInitializable, IDisposable {

		private readonly PlayerDatabase _playerDatabase;
		private readonly CompositeDisposable _disposable = new();


		public OwnedPanel(PlayerDatabase playerDatabase) {
			_playerDatabase = playerDatabase;
		}

		public void Initialize() {
			foreach (var unit in _playerDatabase.Units) { 
				var newCell = View.OwnedPanelBehaviour.CreateCell(unit);
				View.Cells.Add(newCell);
			}

			foreach (var cell in View.Cells) {
				//cell.Button.OnClickSubscribeDisposable();
			}
		}
		
		
		
		public void Dispose() => _disposable?.Dispose();
	}
}