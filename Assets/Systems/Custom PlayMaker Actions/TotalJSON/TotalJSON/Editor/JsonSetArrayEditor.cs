using UnityEditor;

namespace HutongGames.PlayMakerEditor
{
	[CustomActionEditor(typeof(PlayMaker.Actions.JsonSetArray))]
	public class JsonSetArrayEditor : CustomActionEditor
	{
		private PlayMaker.Actions.JsonSetArray JsonSetArray;

		public override void OnEnable()
		{
			base.OnEnable();
			JsonSetArray = (PlayMaker.Actions.JsonSetArray)target;
		}

		public override bool OnGUI()
		{
			EditorGUI.BeginChangeCheck();
			EditField("jsonData");
			EditField("jsonField");
			EditField("property");

			switch (JsonSetArray.property)
			{
				case PlayMaker.Actions.JsonSetArray.Field.Bool:
					EditField("boolArray", "Bool Array");
					break;
				case PlayMaker.Actions.JsonSetArray.Field.Int:
					EditField("intArray", "Int Array");
					break;
				case PlayMaker.Actions.JsonSetArray.Field.Float:
					EditField("floatArray", "Float Array");
					break;
				case PlayMaker.Actions.JsonSetArray.Field.String:
					EditField("stringArray", "String Array");
					break;
				case PlayMaker.Actions.JsonSetArray.Field.Color:
					EditField("colorArray", "Color Array");
					break;
				case PlayMaker.Actions.JsonSetArray.Field.Vector2:
					EditField("vector2Array", "Vector2 Array");
					break;
				case PlayMaker.Actions.JsonSetArray.Field.Vector3:
					EditField("vector3Array", "Vector3 Array");
					break;
				case PlayMaker.Actions.JsonSetArray.Field.Object:
					EditField("objectArray", "Object Array");
					break;
				default:
					break;
			}

			EditField("debug");

			return EditorGUI.EndChangeCheck();
		}

	}
}
