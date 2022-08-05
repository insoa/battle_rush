using Extensions;
using UI.OwnedPanel.Views;
using UnityEngine;
using Zenject;

namespace UI.OwnedPanel {
	public sealed class OwnedPanel : IUiController, IInitializable{
		
		public void Initialize() {
			Debug.Log("Inittialize Owned Panel");
		}
	}
}