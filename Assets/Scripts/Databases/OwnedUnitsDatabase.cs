using System;
using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace Databases {
	[CreateAssetMenu(fileName = "OwnedUnitsDatabase", menuName = "Databases/OwnedUnitsDatabase", order = 2)]
	
	[Serializable]
	public sealed class OwnedUnitsDatabase : ScriptableObject {
		
		public List<Unit> OwnedItems = new List<Unit>();

		public void AddItem(Unit unit, EUnitRare rare) {
			OwnedItems.Add(unit);
			foreach (var rareType in unit.UnitRares) {
				if (rare != rareType.Rare)
					continue;
				unit.Rare = rare;
				unit.Damage = rareType.Damage;
				unit.Health = rareType.Health;
				unit.Armor = rareType.Armor;
				unit.MoveSpeed = rareType.MoveSpeed;
			}
		}
	}
}
