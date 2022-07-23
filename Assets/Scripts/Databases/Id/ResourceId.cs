using System;
using UnityEngine;

namespace Databases {
	[Serializable]
	public struct ResourceId : IEquatable<ResourceId> {
		[SerializeField] private string _value;

		public string Value => _value;
		public ResourceId(string value) => _value = value;

		public bool Equals(ResourceId other) => _value == other._value;

		public override bool Equals(object obj) => obj is ResourceId id && Equals(id);

		public override int GetHashCode() => _value.GetHashCode();

		public static explicit operator ResourceId(string value) => new ResourceId(value);

		public static implicit operator string(ResourceId id) => id._value;

		public static bool operator ==(ResourceId a, ResourceId b) => a._value == b._value;

		public static bool operator !=(ResourceId a, ResourceId b) => a._value != b._value;

		public override string ToString() => _value;
	}
}