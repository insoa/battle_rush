using System;
using UnityEngine;

public sealed class ResolutionManager : MonoBehaviour {
	private int width;
	private int height;
	private void Start() {
		width = Screen.width;
		height = Screen.height;
		ChangeResolution();
	}

	private void ChangeResolution() {
		var newWidth = width / 2;
		var newHeight = height / 2;

		Screen.SetResolution(newWidth, newHeight, true);
		Debug.Log(newHeight + "X" + newWidth);
	}
}