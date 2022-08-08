using UnityEngine;

namespace Extensions.Interfaces {
	public interface IUiView {
		void Destroy();
		void SetOrder(int index);
		void SetParent(Transform parent);
		void Hide();
		void Show();
	}
}