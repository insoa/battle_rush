using System;
using System.Collections.Generic;
using Databases;
using Enums;
using Interfaces;
using UI.InventoryPanel.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.InventoryPanel.Behaviours {
	// public sealed class CollectionPanelPanelBehaviour : MonoBehaviour, IUiPanel, ICollectionPanel {
	// 	
	// 	[Inject] private readonly UnitDatabase _unitDatabase;
	//
	// 	[SerializeField] private InventoryCellBehaviour _cellPrefab;
	// 	[SerializeField] private Transform _contentParent;
	// 	[SerializeField] private List<InventoryCellBehaviour> _inventoryCellBehaviours = new List<InventoryCellBehaviour>();
	// 	
	// 	public Button CloseButton;
	//
	// 	public void CreateCell(Unit unit) {
	// 		var cell = Instantiate(_cellPrefab, _contentParent);
	// 		foreach (var u in _unitDatabase.Units) {
	// 			if (unit.Id != unit.Id)
	// 				continue;
	// 			cell.ButtonType = unit.Type;
	// 			cell.UnitImage.sprite = unit.UnitIcon;
	// 			_inventoryCellBehaviours.Add(cell);
	// 		}
	// 	}
	//
	// 	public void Show() => gameObject.SetActive(true);
	// 	
	// 	public void Hide() => gameObject.SetActive(false);
	// }
}