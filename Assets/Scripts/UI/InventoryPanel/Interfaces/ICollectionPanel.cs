using Databases;
using Enums;
using UI.OwnedPanel.Behaviours;
using UnityEngine;

namespace UI.InventoryPanel.Interfaces {
	public interface ICollectionPanel {
		OwnedCellBehaviour CreateCell(Unit unit);
	}
}