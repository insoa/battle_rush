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

		public void SetRare(EUnitGrade type) {
			
			var colorList = _colorsDatabase.RareColors; //изменить
			switch (type) {
				case EUnitGrade.Common:
					foreach (var element in colorList) {
						if (type != element._grade)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitGrade.Uncommon:
					foreach (var element in colorList) {
						if (type != element._grade)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitGrade.Rare:
					foreach (var element in colorList) {
						if (type != element._grade)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitGrade.Mythical:
					foreach (var element in colorList) {
						if (type != element._grade)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitGrade.Legendary:
					foreach (var element in colorList) {
						if (type != element._grade)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitGrade.Ancient:
					foreach (var element in colorList) {
						if (type != element._grade)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				case EUnitGrade.Immortal:
					foreach (var element in colorList) {
						if (type != element._grade)
							continue;
						_rareBackground.color = element.Color;
						_rareFrameLight.color = element.Color;
					}
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}
		}

		public void SetCharacterIcon(Sprite icon) => _characterImage.sprite = icon;

		public void SetCharacterName(string name) => _characterName.text = name;
		
		public void SetCharacterLevel(string level) => _characterLevel.text = level + " Lvl.";

		public void SetCharacterClass(string name, Sprite icon) {
			_characterClass.text = name;
			_classImage.sprite = icon;
		}
	}
}