using System;
using Databases;
using Enums;
using Other;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.ShopPanel.Behaviours {
	public sealed class ShopCellBehaviour : MonoBehaviour {
		
		public Button Button;
	
		private EUnitType _unitType;
		private EUnitClass _classType;

		[SerializeField] private Image _selector;
		[SerializeField] private Image _unitImage;
		
		[SerializeField] private Image _lightFrame;
		[SerializeField] private Image _heavyFrame;
		[SerializeField] private Image _middleFrame;
		
		public void SetUnitType(EUnitType type) => _unitType = type;
		public void SetUnitClass(EUnitClass type) => _classType = type;
		public void SetUnitIcon(Sprite icon) => _unitImage.sprite = icon;
		public void SetSelected(bool isSelected) => _selector.gameObject.SetActive(isSelected);

		public void SetClassFrame(EUnitClass type) {
			switch(type) {
				case EUnitClass.Heavy:
					_heavyFrame.gameObject.SetActive(true);
					break;
				case EUnitClass.Light:
					_lightFrame.gameObject.SetActive(true);
					break;
				case EUnitClass.Middle:
					_middleFrame.gameObject.SetActive(true);
					break;
				default:
					_lightFrame.gameObject.SetActive(false);
					_middleFrame.gameObject.SetActive(false);
					_heavyFrame.gameObject.SetActive(false);
					Debug.Log(_classType + " Is NULL" % Colorize.Red);
					break;
			}
		}
	}
}