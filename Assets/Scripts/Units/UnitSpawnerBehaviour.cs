using Databases;
using Enums;
using UI.InventoryPanel.Behaviours;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace Units {
	// public sealed class UnitSpawnerBehaviour : MonoBehaviour {
	// 	
	// 	[Inject] private readonly CollectionPanelPanelBehaviour _collectionPanelPanel;
	// 	[Inject] private readonly ButtonsPanelBehaviour _buttonsPanelBehaviour;
	// 	[Inject] private readonly UnitDatabase _unitDatabase;
	//
	// 	[SerializeField] private float spawnFrequency;
	//
	// 	private GameObject _selectedUnit;
	// 	private float _nextCast;
	//
	// 	public static UnitSpawnerBehaviour Instance;
	// 	private void Awake() => Instance = this;
	//
	// 	private void FixedUpdate() => CastRayToMousePoint();
	//
	// 	private void Update() {
	// 		if (Input.touchCount <= 0)
	// 			return;
	// 		Touch touch = Input.GetTouch(0);
	// 		if (touch.phase == TouchPhase.Began) {
	// 			CastRayToTouchPoint(touch);
	// 		}
	// 	}
	//
	// 	public void SelectUnitFromData(EUnitType type) {
	// 		_collectionPanelPanel.Hide();
	// 		_buttonsPanelBehaviour.Show();
	// 		foreach (var unit in _unitDatabase.Units) {
	// 			if (type != unit.Type)
	// 				continue;
	// 			_selectedUnit = unit.Prefab;
	// 			Debug.Log(_selectedUnit.name);
	// 		}
	// 	}
	//
	// 	private void CastRayToMousePoint() {
	// 		if (_selectedUnit == null)
	// 			return;
	// 		if (Camera.main == null)
	// 			return;
	// 		var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	// 		if (!Physics.Raycast(ray, out var hit))
	// 			return;
	// 		if (EventSystem.current.IsPointerOverGameObject())
	// 			return;
	// 		if (!Input.GetMouseButton(0) || !(Time.time > _nextCast))
	// 			return;
	// 		_nextCast = Time.time + 1f / spawnFrequency;
	// 		if (!hit.collider.CompareTag("Ground"))
	// 			return;
	// 		var spawnPoint = new Vector3(hit.point.x, hit.point.y, hit.point.z);
	// 		SpawnUnitToHitPoint(spawnPoint);
	// 	}
	// 	
	// 	private void CastRayToTouchPoint(Touch touch) {
	// 		if (_selectedUnit == null)
	// 			return;
	// 		if (Camera.main == null)
	// 			return;
	// 		var ray = Camera.main.ScreenPointToRay(touch.position);
	// 		if (!Physics.Raycast(ray, out var hit))
	// 			return;
	// 		if (EventSystem.current.IsPointerOverGameObject())
	// 			return;
	// 		if (!(Time.time > _nextCast))
	// 			return;
	// 		_nextCast = Time.time + 1f / spawnFrequency;
	// 		if (!hit.collider.CompareTag("Ground"))
	// 			return;
	// 		var spawnPoint = new Vector3(hit.point.x, hit.point.y, hit.point.z);
	// 		SpawnUnitToHitPoint(spawnPoint);
	// 	}
	//
	// 	private void SpawnUnitToHitPoint(Vector3 spawnPoint) {
	// 		Instantiate(_selectedUnit, spawnPoint, Quaternion.identity);
	// 	}
	// }
}