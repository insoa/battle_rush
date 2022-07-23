using UI.OwnedPanel.Controllers;
using Zenject;

namespace Installers {
	public sealed class OwnedPanelControllerInstaller : MonoInstaller {
		
		// ReSharper disable Unity.PerformanceAnalysis
		public override void InstallBindings() {
			Container.BindInterfacesAndSelfTo<OwnedPanelController>().AsSingle();
		}
	}
}