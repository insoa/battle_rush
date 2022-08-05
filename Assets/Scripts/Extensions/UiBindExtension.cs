using UnityEngine;
using Zenject;

namespace Extensions {
	public static class UiBindExtensions {
		public static void BindUiView<TController, TView>(
			this DiContainer container,
			TView viewPrefab,
			Transform parentGetter
		) where TView : MonoBehaviour, IUiView where TController : IUiController {
			container.InstantiatePrefab(viewPrefab, parentGetter);
			viewPrefab.gameObject.SetActive(false);
			container.BindInterfacesAndSelfTo<TController>().AsSingle();
			container.BindInterfacesAndSelfTo<TView>()
				.FromComponentInNewPrefab(viewPrefab)
				.UnderTransform(parentGetter)
				.AsSingle();
		}
	}
}