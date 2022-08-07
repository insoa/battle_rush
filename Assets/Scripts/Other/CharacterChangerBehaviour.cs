using System.Collections.Generic;
using Enums;
using UnityEngine;

namespace Other {
	public sealed class CharacterChangerBehaviour : MonoBehaviour {
		[SerializeField] private List<Character> CharacterPrefabs = new();

		public void SetCharacter(EUnitType type) {
			foreach (var character in CharacterPrefabs)
				character.gameObject.SetActive(false);
			
			foreach (var t in CharacterPrefabs) {
				if (type != t.UnitType)
					continue;
				t.gameObject.SetActive(true);
				t.GetComponent<Animator>().Play("Idle");
			}
		}
	}
}