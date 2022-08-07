using System.Collections.Generic;
using Databases.Id;
using Enums;
using Interfaces;
using UnityEngine;
using Zenject;

namespace Databases {
	[CreateAssetMenu(fileName = "PlayerDatabase", menuName = "ScriptableObjects/PlayerDatabase", order = 5)]
	public sealed class PlayerDatabase : ScriptableObject {
		public int Level;
		public int Gold;
		public int Gems;
		public int Energy;

		public List<ResourceItem> Resources = new();
		public List<Unit> Units = new();

		// public enum ComponentType {None = 1, };
		// public ComponentType component;

		[SerializeField] private UnitDatabase _unitDatabase;
		[SerializeField] private EUnitType _unitType;
		[SerializeField] private EUnitGrade _unitGrade;

		public void AddUnitFromEditor() {
			foreach (var unit in _unitDatabase.Units) {
				if (unit.Type != _unitType)
					continue;
				AddUnit(unit.Id, _unitGrade);
			}
		}

		private void AddUnit(UnitId unitId, EUnitGrade grade) {
			var unit = _unitDatabase.Get(unitId);
			Units.Add(unit);
			foreach (var rareType in unit.unitGrades) {
				if (grade != rareType.Grade)
					continue;
				unit.Grade = grade;
				unit.Damage = rareType.Damage;
				unit.Health = rareType.Health;
				unit.MoveSpeed = rareType.MoveSpeed;
			}
		}

		public void AddResource(ResourceItem resource, int quantity) {
			for (var i = 0; i < quantity; i++)
				Resources.Add(resource);
		}


		public void ClearUnits() {
			Units.Clear();
		}
		
		public void ClearResources() {
			Resources.Clear();
		}
	}
}