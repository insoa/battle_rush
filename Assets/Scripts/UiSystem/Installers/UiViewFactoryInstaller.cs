using Zenject;

namespace UiSystem.Installers {
	public sealed class UiViewFactoryInstaller : MonoInstaller {
		// ReSharper disable Unity.PerformanceAnalysis
		public override void InstallBindings() {
			Container.BindInterfacesAndSelfTo<UiViewFactory>().AsSingle();
		}
	}
}