using Extensions.Interfaces;
using UnityEngine;
using Zenject;

namespace Extensions {
	public static class UiBindExtension {
		public static void BindUiView<TController, TView>(
			this DiContainer container,
			TView viewPrefab,
			Transform parent
		) where TView : MonoBehaviour, IUiView where TController : IUiController {
			container.InstantiatePrefab(viewPrefab);
			viewPrefab.gameObject.SetActive(false);
			container.BindInterfacesAndSelfTo<TController>().AsSingle();
			container.BindInterfacesAndSelfTo<TView>()
				.FromComponentInNewPrefab(viewPrefab)
				.UnderTransform(parent)
				.AsSingle();
		}
	}
}