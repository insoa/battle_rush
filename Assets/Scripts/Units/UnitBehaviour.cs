﻿using Units.Interfaces;
using UnityEngine;

namespace Units {
	public sealed class UnitBehaviour : MonoBehaviour, IUnit {

		public void GetUnitData() {
		}

		public void FindEnemyTarget(UnitBehaviour target) {
		}

		public void MoveToTarget(UnitBehaviour target) {
		}

		public void Attack(float damage) {
		}

		public void Death() {
		}
	}
}