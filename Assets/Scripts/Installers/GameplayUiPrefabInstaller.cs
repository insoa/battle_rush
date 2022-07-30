using UI.OwnedPanel;
using UI.OwnedPanel.Views;
using UiSystem.Extentions;
using UnityEngine;
using Zenject;

namespace Installers {
	public sealed class GameplayUiPrefabInstaller : MonoInstaller {
		[SerializeField] private OwnedPanelView _ownedPanelView;

		public override void InstallBindings() {
			Container.BindUiView<OwnedPanel, OwnedPanelView>(_ownedPanelView);
		}
	}
}