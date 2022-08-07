using System;
using System.Collections.Generic;
using Databases.Id;
using Enums;
using Interfaces;
using UnityEngine;
using Zenject;

namespace Databases {
	[CreateAssetMenu(fileName = "UnitsDatabase", menuName = "ScriptableObjects/UnitsDatabase", order = 1)]
	public sealed class UnitDatabase : ScriptableObject, IUnitDatabase, IInitializable {

		public List<Unit> Units = new();
		private readonly Dictionary<UnitId, Unit> _database = new();

		public void Initialize() { // Заполнение Dictionary из списка ScriptableObjects при старте
			foreach (var unit in Units) {
				_database.Add(unit.Id, unit);
				Debug.Log("UnitAdded" + "-" + unit.Id);
			}
		}
		
		public Unit Get(UnitId unitId) { 
			Debug.Log(_database.Count);
			if (!_database.ContainsKey(unitId))
				Debug.Log("[ItemsDatabase]" + $"Can't find item with id {unitId}");
			return _database[unitId];
		}

		public bool Has(UnitId unitId) {
			return _database.ContainsKey(unitId);
		}
	}

	[Serializable]
	public sealed class UnitGrade {
		public EUnitGrade Grade;
		public float Damage;
		public float Health;
		public float MoveSpeed;
	}

	[Serializable]
	public sealed class Unit {
		public UnitId Id;
		public EUnitType Type;
		public EUnitClass Class;
		public GameObject Prefab;
		public Sprite UnitIcon;
		public Sprite ClassIcon;
		public int Level;
		public int Quantity;

		public EUnitGrade Grade;
		public float Damage;
		public float Health;
		public float MoveSpeed;

		public List<UnitGrade> unitGrades = new();
	}
}