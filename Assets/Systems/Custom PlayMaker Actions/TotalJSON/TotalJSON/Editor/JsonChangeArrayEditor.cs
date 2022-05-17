using UnityEditor;

namespace HutongGames.PlayMakerEditor
{
	[CustomActionEditor(typeof(PlayMaker.Actions.JsonChangeArray))]
	public class JsonChangeArrayEditor : CustomActionEditor
	{

		private PlayMaker.Actions.JsonChangeArray jsonChangeArray;

		public override void OnEnable()
		{
			base.OnEnable();
			jsonChangeArray = (PlayMaker.Actions.JsonChangeArray)target;
		}

		public override bool OnGUI()
		{
			EditorGUI.BeginChangeCheck();
			EditField("jsonData");
			EditField("jsonField");
			EditField("position");

			EditField("operation");


			switch (jsonChangeArray.operation)
			{
				case PlayMaker.Actions.JsonChangeArray.Operation.Remove:
					break;
				case PlayMaker.Actions.JsonChangeArray.Operation.Insert:
					EditField("property");
					ShowProperties();
					break;
				case PlayMaker.Actions.JsonChangeArray.Operation.Replace:
					EditField("property");
					ShowProperties();
					break;
				default:
					break;
			}

			EditField("debug");
			return EditorGUI.EndChangeCheck();
		}

		void ShowProperties()
		{
			switch (jsonChangeArray.property)
			{
				case PlayMaker.Actions.JsonChangeArray.Field.Bool:
					EditField("boolData", "Bool");
					break;
				case PlayMaker.Actions.JsonChangeArray.Field.Int:
					EditField("intData", "Int");
					break;
				case PlayMaker.Actions.JsonChangeArray.Field.Float:
					EditField("floatData", "Float");
					break;
				case PlayMaker.Actions.JsonChangeArray.Field.String:
					EditField("stringData", "String");
					break;
				case PlayMaker.Actions.JsonChangeArray.Field.Color:
					EditField("colorData", "Color");
					break;
				case PlayMaker.Actions.JsonChangeArray.Field.Vector2:
					EditField("vector2Data", "Vector2");
					break;
				case PlayMaker.Actions.JsonChangeArray.Field.Vector3:
					EditField("vector3Data", "Vector3");
					break;
				case PlayMaker.Actions.JsonChangeArray.Field.Object:
					EditField("objectData", "Object");
					break;
				default:
					break;
			}
		}
	}
}
