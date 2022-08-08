using System.Collections.Generic;
using Extensions;
using UI.OwnedPanel.Behaviours;

namespace UI.OwnedPanel.Views {
	public sealed class OwnedPanelView : UiView {
		public OwnedPanelBehaviour OwnedPanelBehaviour;
		public OwnedCellBehaviour OwnedCellBehaviour;
		
		public List<OwnedCellBehaviour> Cells  = new ();
	}
}