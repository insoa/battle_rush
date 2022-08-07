using Databases;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Zenject;

namespace Editor {
	[CustomEditor(typeof(PlayerDatabase))]
	public sealed class PlayerDatabaseEditorButton : UnityEditor.Editor {
		public override void OnInspectorGUI() {
			DrawDefaultInspector();
			
			var playerDatabaseFunction = (PlayerDatabase)target;
			
			if (GUILayout.Button("Add Unit")) {
				playerDatabaseFunction.AddUnitFromEditor();
			}

			if (GUILayout.Button("Clear Units List")) {
				playerDatabaseFunction.ClearUnits();
			}

			if (GUILayout.Button("Add Resource")) {
				
			}

			if (GUILayout.Button("Clear Resource List")) {
				playerDatabaseFunction.ClearResources();
			}
		}
	}
}