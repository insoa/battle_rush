using UnityEngine;

namespace UiSystem.Intefaces {
	public interface IUiView {
		void Show();
		void Hide();
		void SetParent(Transform parent);
		void SetOrder(int index);
		void Destroy();
	}
}