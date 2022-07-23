using System;
using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace Databases {
	[CreateAssetMenu(fileName = "ColorsDatabase", menuName = "Databases/ColorsDatabase", order = 2)]
	public sealed class ColorsDatabase : ScriptableObject {
		public List<RareColor> RareColors = new();
	}

	[Serializable]
	public sealed class RareColor {
		public EUnitGrade _grade;
		public Color Color;
	}
}