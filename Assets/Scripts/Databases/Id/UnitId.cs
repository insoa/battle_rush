using System;
using UnityEngine;

namespace Databases.Id {
	[Serializable]
	public struct UnitId : IEquatable<UnitId> {
		[SerializeField] private string _value;

		public string Value => _value;
		public UnitId(string value) => _value = value;

		public bool Equals(UnitId other) => _value == other._value;

		public override bool Equals(object obj) => obj is UnitId id && Equals(id);

		public override int GetHashCode() => _value.GetHashCode();

		public static explicit operator UnitId(string value) => new UnitId(value);

		public static implicit operator string(UnitId id) => id._value;

		public static bool operator ==(UnitId a, UnitId b) => a._value == b._value;

		public static bool operator !=(UnitId a, UnitId b) => a._value != b._value;

		public override string ToString() => _value;
	}
}