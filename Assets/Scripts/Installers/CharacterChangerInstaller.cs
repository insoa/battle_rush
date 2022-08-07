using Other;
using UnityEngine;
using Zenject;

namespace Installers {
	public sealed class CharacterChangerInstaller : MonoInstaller {
		[SerializeField] private CharacterChangerBehaviour _characterChangerBehaviour;
		public override void InstallBindings() {
			Container.BindInstance(_characterChangerBehaviour).AsSingle();
		}
	}
}