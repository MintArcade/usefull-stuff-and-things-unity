using UnityEditor;

namespace HutongGames.PlayMakerEditor
{
	[CustomActionEditor(typeof(PlayMaker.Actions.JsonSetValue))]
	public class JsonSetValueEditor : CustomActionEditor
	{
		private PlayMaker.Actions.JsonSetValue jsonSetValue;

		public override void OnEnable()
		{
			base.OnEnable();
			jsonSetValue = (PlayMaker.Actions.JsonSetValue)target;
		}

		public override bool OnGUI()
		{
			EditorGUI.BeginChangeCheck();
			EditField("jsonData");
			EditField("jsonField");
			EditField("property");

			switch (jsonSetValue.property)
			{
				case PlayMaker.Actions.JsonSetValue.Field.Bool:
					EditField("boolData", "Bool");
					break;
				case PlayMaker.Actions.JsonSetValue.Field.Int:
					EditField("intData", "Int");
					break;
				case PlayMaker.Actions.JsonSetValue.Field.Float:
					EditField("floatData", "Float");
					break;
				case PlayMaker.Actions.JsonSetValue.Field.String:
					EditField("stringData", "String");
					break;
				case PlayMaker.Actions.JsonSetValue.Field.Color:
					EditField("colorData", "Color");
					break;
				case PlayMaker.Actions.JsonSetValue.Field.Vector2:
					EditField("vector2Data", "Vector2");
					break;
				case PlayMaker.Actions.JsonSetValue.Field.Vector3:
					EditField("vector3Data", "Vector3");
					break;
				case PlayMaker.Actions.JsonSetValue.Field.Quaternion:
					EditField("quaternionData", "Quaternion");
					break;
				case PlayMaker.Actions.JsonSetValue.Field.Object:
					EditField("objectData", "Object");
					break;
				default:
					break;
			}

			EditField("debug");

			return EditorGUI.EndChangeCheck();
		}
	}
}
