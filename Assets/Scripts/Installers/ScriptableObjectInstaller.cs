using Databases;
using UnityEngine;
using Zenject;

namespace Installers {
	
	[CreateAssetMenu(fileName = "ScriptableObjectInstaller", menuName = "Installers/ScriptableObjectInstaller")]
	public sealed class ScriptableObjectInstaller : ScriptableObjectInstaller<ScriptableObjectInstaller> {

		[SerializeField] private ColorsDatabase _colorsDatabase;
		[SerializeField] private UnitDatabase _unitDatabase;
		[SerializeField] private OwnedUnitsDatabase _ownedUnitsDatabase;
		public override void InstallBindings() {
			Container.BindInstance(_colorsDatabase);
			Container.BindInstance(_unitDatabase);
			Container.BindInstance(_ownedUnitsDatabase);
		}
	}
}