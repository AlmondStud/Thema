using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;

namespace Almond {
	[CustomEditor(typeof(ThemaImage), true)]
	[CanEditMultipleObjects]
	public class ThemaImageEditor : ImageEditor {
		private SerializedProperty m_bgColorType;

		protected override void OnEnable() {
			base.OnEnable();
			m_bgColorType = serializedObject.FindProperty("bgColorType");
		}
		public override void OnInspectorGUI() {
			base.OnInspectorGUI();
			var themaSlider = serializedObject.targetObject as ThemaSlider;

			EditorGUILayout.LabelField("Thema");
			EditorGUILayout.BeginVertical("Box");
			EditorGUI.BeginChangeCheck();
			EditorGUILayout.PropertyField(m_bgColorType);
			if(EditorGUI.EndChangeCheck()) {
				themaSlider.bgColorType = (ThemaColorType)m_bgColorType.enumValueIndex;
			}
			EditorGUILayout.EndVertical();
			serializedObject.ApplyModifiedProperties();
		}
	}
}