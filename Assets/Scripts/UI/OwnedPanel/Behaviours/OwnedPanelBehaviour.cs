using System;
using Databases;
using Enums;
using UI.InventoryPanel.Interfaces;
using UnityEngine;
using Zenject;

namespace UI.OwnedPanel.Behaviours {
	public sealed class OwnedPanelBehaviour : MonoBehaviour, ICollectionPanel {
		[Inject] private OwnedUnitsDatabase _ownedUnitsDatabase;
		[Inject] private UnitDatabase _unitDatabase;
		

		[SerializeField] private OwnedCellBehaviour _cellPrefab;
		[SerializeField] private Transform _contentParent;

		private void Start() {
			for (int i = 0; i < _ownedUnitsDatabase.OwnedItems.Count; i++) {
				CreateCell(_ownedUnitsDatabase.OwnedItems[i]);
			}
		}

		public void CreateCell(Unit unit) {
			var cell = Instantiate(_cellPrefab, _contentParent);
			Debug.Log(cell);
			cell.SetRare(unit.Rare);
			cell.SetCharacterIcon(unit.UnitIcon);
			cell.SetCharacterName(unit.Name);
			cell.SetCharacterLevel(unit.Level.ToString());
			cell.SetCharacterClass(unit.Class.ToString(), unit.ClassIcon);
		}
	}
}