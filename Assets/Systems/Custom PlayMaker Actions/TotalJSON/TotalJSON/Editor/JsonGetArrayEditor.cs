using UnityEditor;

namespace HutongGames.PlayMakerEditor
{
    [CustomActionEditor(typeof(PlayMaker.Actions.JsonGetArray))]
    public class JsonGetArrayEditor : CustomActionEditor
    {
		private PlayMaker.Actions.JsonGetArray JsonGetArray;

		public override void OnEnable()
		{
			base.OnEnable();
			JsonGetArray = (PlayMaker.Actions.JsonGetArray)target;
		}

		public override bool OnGUI()
		{
			EditorGUI.BeginChangeCheck();
			EditField("jsonData");
			EditField("jsonField");
			EditField("property");

			switch (JsonGetArray.property)
			{
				case PlayMaker.Actions.JsonGetArray.Field.Bool:
					EditField("boolArray", "Bool Array");
					break;
				case PlayMaker.Actions.JsonGetArray.Field.Int:
					EditField("intArray", "Int Array");
					break;
				case PlayMaker.Actions.JsonGetArray.Field.Float:
					EditField("floatArray", "Float Array");
					break;
				case PlayMaker.Actions.JsonGetArray.Field.String:
					EditField("stringArray", "String Array");
					break;
				case PlayMaker.Actions.JsonGetArray.Field.Color:
					EditField("colorArray", "Color Array");
					break;
				case PlayMaker.Actions.JsonGetArray.Field.Vector2:
					EditField("vector2Array", "Vector2 Array");
					break;
				case PlayMaker.Actions.JsonGetArray.Field.Vector3:
					EditField("vector3Array", "Vector3 Array");
					break;
				case PlayMaker.Actions.JsonGetArray.Field.Object:
					EditField("objectArray", "Object Array");
					break;
				default:
					break;
			}

			return EditorGUI.EndChangeCheck();
		}
	}
}
