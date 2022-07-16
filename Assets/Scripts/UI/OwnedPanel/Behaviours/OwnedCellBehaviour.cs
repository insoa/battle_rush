using System;
using Databases;
using Enums;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.OwnedPanel.Behaviours {
	public sealed class OwnedCellBehaviour : MonoBehaviour {

		[SerializeField] private ColorsDatabase _colorsDatabase;
		
		[SerializeField] private Image _characterImage;
		[SerializeField] private Image _classImage;
		[SerializeField] private Image _rareBackground;
		[SerializeField] private Image _rareFrameLight;
		[SerializeField] private TextMeshProUGUI _characterName;
		[SerializeField] private TextMeshProUGUI _characterLevel;
		[SerializeField] private TextMeshProUGUI _characterClass;

		private void Start() {
			Debug.Log(_colorsDatabase);
		}

		public void SetRare(EUnitRare type) {
			
			var colorList = _colorsDatabase.RareColors;
			switch (type) {
				case EUnitRare.Common:
					foreach (var element in colorList) {
						if (type != element.Rare)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitRare.Uncommon:
					foreach (var element in colorList) {
						if (type != element.Rare)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitRare.Rare:
					foreach (var element in colorList) {
						if (type != element.Rare)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitRare.Mythical:
					foreach (var element in colorList) {
						if (type != element.Rare)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitRare.Legendary:
					foreach (var element in colorList) {
						if (type != element.Rare)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitRare.Ancient:
					foreach (var element in colorList) {
						if (type != element.Rare)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitRare.Immortal:
					foreach (var element in colorList) {
						if (type != element.Rare)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}
		}

		public void SetCharacterIcon(Sprite icon) {
			_characterImage.sprite = icon;
		}

		public void SetCharacterName(string name) => _characterName.text = name;
		
		public void SetCharacterLevel(string level) => _characterLevel.text = level + " Lvl.";

		public void SetCharacterClass(string name, Sprite icon) {
			_characterClass.text = name;
			_classImage.sprite = icon;
		}
	}
}