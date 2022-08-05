using System;
using System.Collections.Generic;
using Databases.Id;
using Enums;
using Interfaces;
using UnityEngine;

namespace Databases {
	[CreateAssetMenu(fileName = "UnitsDatabase", menuName = "ScriptableObjects/UnitsDatabase", order = 1)]
	public sealed class UnitDatabase : ScriptableObject, IUnitDatabase {
		
		[SerializeField] private Unit[] _units;
		private readonly Dictionary<UnitId, Unit> _database = new();

		public IEnumerable<Unit> All => _units;

		public UnitDatabase(UnitData data) {
			foreach (var unit in data.List)
				_database.Add(unit.Id, unit);
			_units = data.List;
		}

		public Unit Get(UnitId unitId) {
			if (!_database.ContainsKey(unitId))
				Debug.Log("[ItemsDatabase]" + $"Can't find item with id {unitId}");
			return _database[unitId];
		}

		public bool Has(UnitId unitId) => _database.ContainsKey(unitId);
	}

	[Serializable]
	public class UnitData : ADataList<Unit> {
		public UnitData(Unit[] list) : base(list) { }
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
		public string Name;
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

		public List<UnitGrade> UnitRares = new();
	}
}