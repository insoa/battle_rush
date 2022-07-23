using Databases;
using UI.InventoryPanel.Interfaces;
using UnityEngine;
using Zenject;

namespace UI.OwnedPanel.Behaviours {
	public sealed class OwnedPanelBehaviour : MonoBehaviour, ICollectionPanel {
		
		[SerializeField] private OwnedCellBehaviour _cellPrefab;
		[SerializeField] private Transform _contentParent;

		public void CreateCell(Unit unit) {
			var cell = Instantiate(_cellPrefab, _contentParent);
			Debug.Log(cell);
			cell.SetRare(unit._grade);
			cell.SetCharacterIcon(unit.UnitIcon);
			cell.SetCharacterName(unit.Name);
			cell.SetCharacterLevel(unit.Level.ToString());
			cell.SetCharacterClass(unit.Class.ToString(), unit.ClassIcon);

		}
	}
}