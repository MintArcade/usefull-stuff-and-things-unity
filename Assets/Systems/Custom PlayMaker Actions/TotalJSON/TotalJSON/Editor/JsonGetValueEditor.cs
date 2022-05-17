using UnityEditor;

namespace HutongGames.PlayMakerEditor
{
    [CustomActionEditor(typeof(PlayMaker.Actions.JsonGetValue))]
    public class JsonGetValueEditor : CustomActionEditor
    {
        private PlayMaker.Actions.JsonGetValue JsonGetValue;

        public override void OnEnable()
        {
            base.OnEnable();
            JsonGetValue = (PlayMaker.Actions.JsonGetValue)target;
        }

        public override bool OnGUI()
        {
            EditorGUI.BeginChangeCheck();
            EditField("jsonData");
            EditField("jsonField");
            EditField("property");

			switch (JsonGetValue.property)
			{
				case PlayMaker.Actions.JsonGetValue.Field.Bool:
					EditField("boolData", "Bool");
					break;
				case PlayMaker.Actions.JsonGetValue.Field.Int:
					EditField("intData", "Int");
					break;
				case PlayMaker.Actions.JsonGetValue.Field.Float:
					EditField("floatData", "Float");
					break;
				case PlayMaker.Actions.JsonGetValue.Field.String:
					EditField("stringData", "String");
					break;
				case PlayMaker.Actions.JsonGetValue.Field.Color:
					EditField("colorData", "Color");
					break;
				case PlayMaker.Actions.JsonGetValue.Field.Vector2:
					EditField("vector2Data", "Vector2");
					break;
				case PlayMaker.Actions.JsonGetValue.Field.Vector3:
					EditField("vector3Data", "Vector3");
					break;
				case PlayMaker.Actions.JsonGetValue.Field.Quaternion:
					EditField("quaternionData", "Quaternion");
					break;
				case PlayMaker.Actions.JsonGetValue.Field.Object:
					EditField("objectData", "Object");
					break;
				default:
					break;
			}

            return EditorGUI.EndChangeCheck();
        }
    }
}
