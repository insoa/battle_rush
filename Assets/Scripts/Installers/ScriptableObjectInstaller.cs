using Databases;
using UnityEngine;
using Zenject;

namespace Installers {
	[CreateAssetMenu(fileName = "ScriptableObjectInstaller", menuName = "Installers/ScriptableObjectInstaller")]
	public sealed class ScriptableObjectInstaller : ScriptableObjectInstaller<ScriptableObjectInstaller> {
		[SerializeField] private UnitDatabase _unitDatabase;
		[SerializeField] private ResourcesDatabase _resourcesDatabase;
		[SerializeField] private PlayerDatabase _playerDatabase;
		[SerializeField] private ColorsDatabase _colorsDatabase;

		// ReSharper disable Unity.PerformanceAnalysis
		public override void InstallBindings() {
			Container.BindInterfacesAndSelfTo<UnitDatabase>().FromInstance(_unitDatabase).AsCached();
			Container.BindInstance(_resourcesDatabase);
			Container.BindInstance(_playerDatabase);
			Container.BindInstance(_colorsDatabase);
		}
	}
}