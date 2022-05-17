using Leguar.TotalJSON;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Create array of values in JSON")]
	[ActionCategory("TotalJSON")]
	public class JsonSetArray : FsmStateAction
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

		[ActionSection("Settings")]
		public FsmBool debug;

		JArray jsonArray;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			JSON jsonObject;
			if (jsonData.Value.Length > 0)
			{
				jsonObject = JSON.ParseString(jsonData.Value);
			}
			else
			{
				jsonObject = new JSON();
			}

			if (debug.Value) jsonObject.DebugInEditor("Add " + jsonField.Value + " array");

			switch (property)
			{
				case Field.Bool:
					if (jsonObject.ContainsKey(jsonField.Value))
					{
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					else
					{
						jsonObject.AddOrReplace(jsonField.Value, new bool[0]);
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}

					foreach (var item in boolArray.Values)
					{
						jsonArray.Add(item);
					}
					break;
				case Field.Int:
					if (jsonObject.ContainsKey(jsonField.Value))
					{
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					else
					{
						jsonObject.AddOrReplace(jsonField.Value, new int[0]);
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}

					foreach (var item in intArray.Values)
					{
						jsonArray.Add(item);
					}
					break;
				case Field.Float:
					if (jsonObject.ContainsKey(jsonField.Value))
					{
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					else
					{
						jsonObject.AddOrReplace(jsonField.Value, new float[0]);
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}

					foreach (var item in floatArray.Values)
					{
						jsonArray.Add(item);
					}
					break;
				case Field.String:
					if (jsonObject.ContainsKey(jsonField.Value))
					{
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					else
					{
						jsonObject.AddOrReplace(jsonField.Value, new string[0]);
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}

					foreach (var item in stringArray.Values)
					{
						jsonArray.Add(item);
					}
					break;
				case Field.Color:
					if (jsonObject.ContainsKey(jsonField.Value))
					{
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					else
					{
						jsonObject.AddOrReplace(jsonField.Value, new JSON[0]);
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					foreach (var item in colorArray.Values)
					{
						jsonArray.Add(JSON.Serialize(item));
					}
					break;
				case Field.Vector2:
					if (jsonObject.ContainsKey(jsonField.Value))
					{
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					else
					{
						jsonObject.AddOrReplace(jsonField.Value, new JSON[0]);
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					foreach (var item in vector2Array.Values)
					{
						jsonArray.Add(JSON.Serialize(item));
					}
					break;
				case Field.Vector3:
					if (jsonObject.ContainsKey(jsonField.Value))
					{
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					else
					{
						jsonObject.AddOrReplace(jsonField.Value, new JSON[0]);
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					foreach (var item in vector3Array.Values)
					{
						jsonArray.Add(JSON.Serialize(item));
					}
					break;
				case Field.Object:
					if (jsonObject.ContainsKey(jsonField.Value))
					{
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					else
					{
						jsonObject.AddOrReplace(jsonField.Value, new JSON[0]);
						jsonArray = jsonObject.GetJArray(jsonField.Value);
					}
					foreach (var item in objectArray.Values)
					{
						jsonArray.Add(JSON.Serialize(JSON.ParseString(item.ToString())));
					}
					break;
				default:
					break;
			}

			jsonData.Value = jsonObject.CreateString();
			Finish();
		}


	}

}
