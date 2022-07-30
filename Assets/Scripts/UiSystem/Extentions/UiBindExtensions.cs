using System;
using UiSystem.Interfaces;
using UiSystem.Signals;
using UnityEngine;
using Zenject;

namespace UiSystem.Extentions {
	public static class UiBindExtensions {
		public static void BindUiView<TController, TView>(
			this DiContainer container,
			TView viewPrefab
		)
			where TView : MonoBehaviour, IUiView
			where TController : IUiController {
			//container.BindUiView<TController, TView>(viewPrefab);
		}

		public static void BindUiView<TController, TView>(
			this DiContainer container,
			TView viewPrefab,
			Func<InjectContext, Transform> parentGetter
		)
			where TView : MonoBehaviour, IUiView
			where TController : IUiController {
			viewPrefab.gameObject.SetActive(false);
			container.BindInterfacesAndSelfTo<TController>().AsSingle();
			container.BindInterfacesAndSelfTo<TView>()
				.FromComponentInNewPrefab(viewPrefab)
				.UnderTransform(parentGetter)
				.AsSingle()
				.OnInstantiated((context, o) => { context.Container.Resolve<IUiViewFactory>().Process((IUiView) o); });
		}

		// private static Transform ParentGetter(InjectContext context)
		// 	=> context.Container.Resolve<ICanvasProvider>().Canvas.transform;

		public static void BindUiSignals(this DiContainer container, EWindowLayer windowLayer) {
			container.DeclareSignal<SignalOpenWindow>().WithId(windowLayer);
			container.DeclareSignal<SignalOpenRootWindow>().WithId(windowLayer);
			container.DeclareSignal<SignalBackWindow>().WithId(windowLayer);
			container.DeclareSignal<SignalActiveWindow>().WithId(windowLayer).OptionalSubscriber();
			container.DeclareSignal<SignalFocusWindow>().WithId(windowLayer).OptionalSubscriber();
			container.DeclareSignal<SignalCloseWindow>().WithId(windowLayer).OptionalSubscriber();
		}

		public static void BindWindowsController<T>(this DiContainer container, EWindowLayer windowLayer)
			where T : IWindowsController, IInitializable {
			container.BindInitializableExecutionOrder<T>(-1000);
			container.BindInterfacesTo<T>().AsSingle().WithArguments(windowLayer).NonLazy();
			var windowState = new WindowState();
			container.BindInterfacesTo<WindowState>().FromInstance(windowState).AsSingle();
			container.Bind<WindowState>().FromInstance(windowState).WhenInjectedInto<T>();
		}
	}
}