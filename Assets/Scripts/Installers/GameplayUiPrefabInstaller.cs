﻿using UI.InventoryPanel.Behaviours;
using UI.ShopPanel.Behaviours;
using UI.UnitButtonsPanel.Behaviours;
using Units;
using UnityEngine;
using Zenject;

namespace Installers {}
// 	public sealed class GameplayUiPrefabInstaller : MonoInstaller {
//
// 	// 	//Panels Parent
// 	// 	[SerializeField] private Transform _canvas;
// 	// 	
// 	// 	
// 	// 	//Prefabs
// 	// 	[SerializeField] private ButtonsPanelBehaviour _buttonsPanelBehaviourPrefab;
// 	// 	[SerializeField] private CollectionPanelPanelBehaviour _collectionPanelPanelBehaviourPrefab;
// 	// 	//[SerializeField] private ShopPanelBehaviour _shopPanelBehaviourPrefab;
// 	//
// 	// 	public override void InstallBindings() {
// 	// 		
// 	// 		// //Inventory
// 	// 		// var inventoryPanelInstance = Container.InstantiatePrefabForComponent<CollectionPanelPanelBehaviour>(_collectionPanelPanelBehaviourPrefab, _canvas);
// 	// 		// Container.BindInterfacesAndSelfTo<CollectionPanelPanelBehaviour>().FromInstance(inventoryPanelInstance).AsSingle();
// 	//
// 	// 		//Shop
// 	// 		// var shopPanelInstance = Container.InstantiatePrefabForComponent<ShopPanelBehaviour>(_shopPanelBehaviourPrefab, _canvas);
// 	// 		// Container.BindInterfacesAndSelfTo<ShopPanelBehaviour>().FromInstance(shopPanelInstance).AsSingle();
// 	// 		
// 	// 		// //Main
// 	// 		// var unitButtonsPanelInstance = Container.InstantiatePrefabForComponent<ButtonsPanelBehaviour>(_buttonsPanelBehaviourPrefab, _canvas);
// 	// 		// Container.BindInterfacesAndSelfTo<ButtonsPanelBehaviour>().FromInstance(unitButtonsPanelInstance).AsSingle();
// 	// 	}
// 	// }
// }