using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace Databases {
	[CreateAssetMenu(fileName = "PlayerDatabase", menuName = "ScriptableObjects/PlayerDatabase", order = 5)]
	public sealed class PlayerDatabase : ScriptableObject {
		public int Level;
		public int Gold;
		public int Gems;
		public int Energy;

		public List<ResourceItem> Resources = new();
		public List<Unit> Units = new();

		public void AddUnit(Unit unit, EUnitGrade grade) {
			Units.Add(unit);
			foreach (var rareType in unit.UnitRares) {
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
	}
}