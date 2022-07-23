using UiSystem.Intefaces;
using UnityEngine;

namespace UiSystem {
	
	public abstract class UiView : MonoBehaviour, IUiView {
		
		void IUiView.Show() {
			transform.SetAsLastSibling();
			gameObject.SetActive(true);
			OnShow();
		}

		protected virtual void OnShow() { }

		void IUiView.Hide() {
			gameObject.SetActive(false);
			OnHide();
		}

		protected virtual void OnHide() { }

		void IUiView.SetParent(Transform parent) {
			transform.SetParent(parent, false);
		}
		void IUiView.SetOrder(int index) {
			var parent = transform.parent;
			if (parent == null)
				return;
			var childCount = parent.childCount - 1;
			transform.SetSiblingIndex(childCount - index);
		}

		void IUiView.Destroy() {
			Destroy(gameObject);
		}
	}
}