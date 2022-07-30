using UnityEngine;

namespace UiSystem.Interfaces {
	public interface IUiView {
		void Show();
		void Hide();
		void SetParent(Transform parent);
		void SetOrder(int index);
		void Destroy();
	}
}