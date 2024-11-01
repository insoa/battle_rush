﻿using Databases;
using UnityEditor;
using UnityEngine;

namespace Editor {
	[CustomEditor(typeof(UnitDatabase))]
	public sealed class UnitDatabaseEditorButton : UnityEditor.Editor {
		public override void OnInspectorGUI() {
			DrawDefaultInspector();

			var function = (UnitDatabase)target;
			
			if (GUILayout.Button("Initialize Dictionary")) {
				function.Initialize();
			}
			
			if (GUILayout.Button("Clear Dictionary")) {
				function.Clear();
			}
		}
	}
}
