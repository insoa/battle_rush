using System;
using System.Collections.Generic;
using Enums;
using Interfaces;
using UnityEngine;
using Zenject;

namespace Databases {
	
	[CreateAssetMenu(fileName = "UnitsDatabase", menuName = "ScriptableObjects/UnitsDatabase", order = 1)]
	public sealed class UnitDatabase : ScriptableObjectInstaller, IUnitDatabase {
	
		public List<Unit> Units = new List<Unit>();

		public override void InstallBindings() {
			Container.BindInterfacesAndSelfTo<UnitDatabase>().AsSingle().NonLazy();
		}

		public Unit GetUnitFromData(int id) {
			return Units[id];
		}
	}

	[Serializable]
	public sealed class UnitRare {
		public EUnitRare Rare;
		public float Damage;
		public float Health;
		public float Armor;
		public float MoveSpeed;
	}

	[Serializable]
	public sealed class Unit {
		public string Name;
		public int Id;
		public int Level;
		public EUnitType Type;
		public EUnitClass Class;
		public GameObject Prefab;
		public Sprite UnitIcon;
		public Sprite ClassIcon;
		
		public EUnitRare Rare;
		public float Damage;
		public float Health;
		public float Armor;
		public float MoveSpeed;

		public List<UnitRare> UnitRares = new List<UnitRare>();
	}
}