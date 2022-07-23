using System;
using UI.InventoryPanel.Behaviours;
using UI.ShopPanel.Behaviours;
using Zenject;

namespace UI.Controllers {
	// public sealed class GameplayUiController : IInitializable {
	//
	// 	private readonly CollectionPanelPanelBehaviour _collectionPanelPanel;
	// 	//private readonly ShopPanelBehaviour _shopPanelBehaviour;
	// 	private readonly ButtonsPanelBehaviour _buttonsPanelBehaviour;
	//
	// 	public GameplayUiController(ButtonsPanelBehaviour buttonsPanelBehaviour, CollectionPanelPanelBehaviour collectionPanelPanel) {
	// 		_buttonsPanelBehaviour = buttonsPanelBehaviour;
	// 		_collectionPanelPanel = collectionPanelPanel;
	// 	}
	//
	// 	public void Initialize() {
	// 		_buttonsPanelBehaviour.InventoryButton.onClick.AddListener (()  => SetState(EUiType.Inventory));
	// 		_buttonsPanelBehaviour.ShopButton.onClick.AddListener(()  => SetState(EUiType.Shop));
	// 		_collectionPanelPanel.CloseButton.onClick.AddListener(()  => SetState(EUiType.Buttons));
	// 	//	_shopPanelBehaviour.CloseButton.onClick.AddListener(()  => SetState(EUiType.Buttons));
	// 	}
	//
	// 	private void SetState(EUiType type) {
	// 		switch (type) {
	// 			case EUiType.Inventory:
	// 				_collectionPanelPanel.Show();
	// 			//	_shopPanelBehaviour.Hide();
	// 				_buttonsPanelBehaviour.Hide();
	// 				break;
	// 			case EUiType.Shop:
	// 			//	_shopPanelBehaviour.Show();
	// 				_collectionPanelPanel.Hide();
	// 				_buttonsPanelBehaviour.Hide();
	// 				break;
	// 			case EUiType.Buttons:
	// 			//	_shopPanelBehaviour.Hide();
	// 				_collectionPanelPanel.Hide();
	// 				_buttonsPanelBehaviour.Show();
	// 				break;
	// 			default:
	// 				throw new ArgumentOutOfRangeException(nameof(type), type, null);
	// 		}
	// 	}
	// }
}