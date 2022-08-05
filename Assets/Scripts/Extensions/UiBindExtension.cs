using System;
using UnityEngine;
using Zenject;

namespace Extensions {
	public static class UiBindExtensions {
		public static void BindUiView<TController, TView>(this DiContainer container, TView viewPrefab)
			where TView : MonoBehaviour, IUiView where TController : IUiController {
			container.BindUiView<TController, TView>(viewPrefab, ParentGetter);
		}

		public static void BindUiView<TController, TView>(
			this DiContainer container,
			TView viewPrefab,
			Func<InjectContext, Transform> parentGetter
		) where TView : MonoBehaviour, IUiView where TController : IUiController {
			viewPrefab.gameObject.SetActive(false);
			container.BindInterfacesAndSelfTo<TController>().AsSingle();
			container.BindInterfacesAndSelfTo<TView>()
				.FromComponentInNewPrefab(viewPrefab)
				.UnderTransform(parentGetter)
				.AsSingle();
			//.OnInstantiated((context, o) => { context.Container.Resolve<IUiViewFactory>().Process((IUiView)o); });
		}

		private static Transform ParentGetter(InjectContext context)
			=> context.Container.Resolve<Canvas>().transform;
	}
}