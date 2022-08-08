using Databases;
using UI.InventoryPanel.Interfaces;
using UnityEngine;

namespace UI.OwnedPanel.Behaviours {
	public sealed class OwnedPanelBehaviour : MonoBehaviour, ICollectionPanel {
		
		[SerializeField] private OwnedCellBehaviour _cellPrefab;
		[SerializeField] private Transform _contentParent;

		public OwnedCellBehaviour CreateCell(Unit unit) {
			var cell = Instantiate(_cellPrefab, _contentParent);
			cell.SetRare(unit.Grade);
			cell.SetCharacterIcon(unit.UnitIcon);
			cell.SetCharacterName(unit.Id.Value);
			cell.SetCharacterLevel(unit.Level.ToString());
			cell.SetCharacterClass(unit.Class.ToString(), unit.ClassIcon);
			return cell;
		}
	}
}