using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Extensions {
	
	public static class UiRxExtension {
		public static IDisposable OnClickSubscribeDisposable(this Button self, Action callback)
			=> self.OnClickAsObservable().Subscribe(x => callback());

		public static IDisposable OnClickSubscribeDisposable<T>(this Button self, Action<T> callback, T value)
			=> self.OnClickAsObservable().Subscribe(x => callback(value));

		public static IDisposable OnValueChangeSubscribeDisposable(this Slider self, Action callback)
			=> self.OnValueChangedAsObservable().Subscribe(x => callback());

		public static Image FillAmountSlider(
			this Image self,
			float value,
			EFillAmountDirection direction = EFillAmountDirection.LeftToRight
		) {
			var anchorMin = Vector2.zero;
			var anchorMax = Vector2.one;

			if (self != null && self.type == Image.Type.Filled)
				self.fillAmount = value;
			else {
				var axis = direction == EFillAmountDirection.LeftToRight || direction == EFillAmountDirection.RightToLeft ? 0 : 1;

				if (direction == EFillAmountDirection.RightToLeft || direction == EFillAmountDirection.TopToBottom)
					anchorMin[axis] = value;
				else
					anchorMax[axis] = value;
			}

			self.rectTransform.anchorMin = anchorMin;
			self.rectTransform.anchorMax = anchorMax;

			return self;
		}

		public enum EFillAmountDirection {
			LeftToRight,
			BottomToTop,
			RightToLeft,
			TopToBottom
		}
	}
}