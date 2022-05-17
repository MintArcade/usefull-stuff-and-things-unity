using Leguar.TotalJSON;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get array values from JSON")]
	[ActionCategory("TotalJSON")]
	public class JsonGetArray : FsmStateAction
	{

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Json String")]
		public FsmString jsonData;

		[RequiredField]
		[Tooltip("Json Field")]
		public FsmString jsonField;

		public enum Field { Bool, Int, Float, String, Color, Vector2, Vector3, Object }
		public Field property;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		[ArrayEditor(VariableType.Bool)]
		[UIHint(UIHint.FsmArray)]
		public FsmArray boolArray;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		[ArrayEditor(VariableType.Int)]
		[UIHint(UIHint.FsmArray)]
		public FsmArray intArray;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		[ArrayEditor(VariableType.Float)]
		[UIHint(UIHint.FsmArray)]
		public FsmArray floatArray;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		[ArrayEditor(VariableType.String)]
		[UIHint(UIHint.FsmArray)]
		public FsmArray stringArray;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		[ArrayEditor(VariableType.Color)]
		[UIHint(UIHint.FsmArray)]
		public FsmArray colorArray;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		[ArrayEditor(VariableType.Vector2)]
		[UIHint(UIHint.FsmArray)]
		public FsmArray vector2Array;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		[ArrayEditor(VariableType.Vector3)]
		[UIHint(UIHint.FsmArray)]
		public FsmArray vector3Array;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		[ArrayEditor(VariableType.String)]
		[UIHint(UIHint.FsmArray)]
		public FsmArray objectArray;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			JSON jSON = JSON.ParseString(jsonData.Value);
			jSON.SetProtected();
			JArray jsonArray = jSON.GetJArray(jsonField.Value);

			switch (property)
			{
				case Field.Bool:
					bool[] aBool = jsonArray.AsBoolArray();
					boolArray.Resize(aBool.Length);
					for (int i = 0; i < aBool.Length; i++)
					{
						boolArray.Values[i] = aBool[i];
					}
					boolArray.SaveChanges();
					break;
				case Field.Int:
					int[] aInt = jsonArray.AsIntArray();
					intArray.Resize(aInt.Length);
					for (int i = 0; i < aInt.Length; i++)
					{
						intArray.Values[i] = aInt[i];
					}
					intArray.SaveChanges();
					break;
				case Field.Float:
					float[] aFloat = jsonArray.AsFloatArray();
					floatArray.Resize(aFloat.Length);
					for (int i = 0; i < aFloat.Length; i++)
					{
						floatArray.Values[i] = aFloat[i];
					}
					floatArray.SaveChanges();
					break;
				case Field.String:
					string[] aString = jsonArray.AsStringArray();
					stringArray.Resize(aString.Length);
					for (int i = 0; i < aString.Length; i++)
					{
						stringArray.Values[i] = aString[i];
					}
					stringArray.SaveChanges();
					break;
				case Field.Color:
					JSON[] aColor = jsonArray.AsJSONArray();
					colorArray.Resize(aColor.Length);
					for (int i = 0; i < aColor.Length; i++)
					{
						colorArray.Values[i] = aColor[i].Deserialize<Color>();
					}
					break;
				case Field.Vector2:
					JSON[] aVector2 = jsonArray.AsJSONArray();
					vector2Array.Resize(aVector2.Length);
					for (int i = 0; i < aVector2.Length; i++)
					{
						vector2Array.Values[i] = aVector2[i].Deserialize<Vector2>();
					}
					break;
				case Field.Vector3:
					JSON[] aVector3 = jsonArray.AsJSONArray();
					vector3Array.Resize(aVector3.Length);
					for (int i = 0; i < aVector3.Length; i++)
					{
						vector3Array.Values[i] = aVector3[i].Deserialize<Vector3>();
					}
					break;
				case Field.Object:
					JSON[] aObject = jsonArray.AsJSONArray();

					objectArray.Resize(aObject.Length);
					for (int i = 0; i < aObject.Length; i++)
					{
						objectArray.Values[i] = aObject[i].CreateString();
					}

					objectArray.SaveChanges();
					break;
				default:
					break;
			}

			

			Finish();
		}


	}

}
