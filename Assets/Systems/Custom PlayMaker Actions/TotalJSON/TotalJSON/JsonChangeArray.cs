using Leguar.TotalJSON;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Remove, Insert or Replace array values in JSON")]
	[ActionCategory("TotalJSON")]
	public class JsonChangeArray : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Json String")]
		public FsmString jsonData;

		public enum Operation { Remove, Insert, Replace }
		public Operation operation;

		[RequiredField]
		[Tooltip("Position")]
		public FsmInt position;

		[RequiredField]
		[Tooltip("Json Field")]
		public FsmString jsonField;

		public enum Field { Bool, Int, Float, String, Color, Vector2, Vector3, Object }
		public Field property;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		public FsmBool boolData;
		[Tooltip("Context sensitive parameter. Depends on Property.")]
		public FsmInt intData;
		[Tooltip("Context sensitive parameter. Depends on Property.")]
		public FsmFloat floatData;
		[Tooltip("Context sensitive parameter. Depends on Property.")]
		public FsmString stringData;
		[Tooltip("Context sensitive parameter. Depends on Property.")]
		public FsmColor colorData;
		[Tooltip("Context sensitive parameter. Depends on Property.")]
		public FsmVector2 vector2Data;
		[Tooltip("Context sensitive parameter. Depends on Property.")]
		public FsmVector3 vector3Data;
		[Tooltip("Context sensitive parameter. Depends on Property.")]
		[UIHint(UIHint.TextArea)]
		public FsmString objectData;

		[ActionSection("Settings")]
		public FsmBool debug;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			JSON jsonObject = JSON.ParseString(jsonData.Value);
			JArray jsonArray = jsonObject.GetJArray(jsonField.Value);

			switch (operation)
			{
				case Operation.Remove:
					if (debug.Value) jsonObject.DebugInEditor("Removing from " + jsonField.Value + " at position " + position.Value);
					jsonArray.RemoveAt(position.Value);
					break;
				case Operation.Insert:
					switch (property)
					{
						case Field.Bool:
							if (debug.Value) jsonObject.DebugInEditor("Inserting " + jsonField.Value + " (" + boolData.Value + ") at position " + position.Value);
							jsonArray.InsertAt(position.Value, boolData.Value);
							break;
						case Field.Int:
							if (debug.Value) jsonObject.DebugInEditor("Inserting " + jsonField.Value + " (" + intData.Value + ") at position " + position.Value);
							jsonArray.InsertAt(position.Value, intData.Value);
							break;
						case Field.Float:
							if (debug.Value) jsonObject.DebugInEditor("Inserting " + jsonField.Value + " (" + floatData.Value + ") at position " + position.Value);
							jsonArray.InsertAt(position.Value, floatData.Value);
							break;
						case Field.String:
							if (debug.Value) jsonObject.DebugInEditor("Inserting " + jsonField.Value + " (" + stringData.Value + ") at position " + position.Value);
							jsonArray.InsertAt(position.Value, stringData.Value);
							break;
						case Field.Color:
							if (debug.Value) jsonObject.DebugInEditor("Inserting " + jsonField.Value + " " + colorData.Value + " at position " + position.Value);
							jsonArray.InsertAt(position.Value, JSON.Serialize(colorData.Value));
							break;
						case Field.Vector2:
							if (debug.Value) jsonObject.DebugInEditor("Inserting " + jsonField.Value + " " + vector2Data.Value + " at position " + position.Value);
							jsonArray.InsertAt(position.Value, JSON.Serialize(vector2Data.Value));
							break;
						case Field.Vector3:
							if (debug.Value) jsonObject.DebugInEditor("Inserting " + jsonField.Value + " " + vector3Data.Value + " at position " + position.Value);
							jsonArray.InsertAt(position.Value, JSON.Serialize(vector3Data.Value));
							break;
						case Field.Object:
							if (debug.Value) jsonObject.DebugInEditor("Inserting " + jsonField.Value + " " + objectData.Value + " at position " + position.Value);
							jsonArray.InsertAt(position.Value, JSON.Serialize(JSON.ParseString(objectData.Value)));
							break;
						default:
							break;
					}
					break;
				case Operation.Replace:
					switch (property)
					{
						case Field.Bool:
							if (debug.Value) jsonObject.DebugInEditor("Replacing " + jsonField.Value + " (" + boolData.Value + ") at position " + position.Value);
							jsonArray.ReplaceAt(position.Value, boolData.Value);
							break;
						case Field.Int:
							if (debug.Value) jsonObject.DebugInEditor("Replacing " + jsonField.Value + " (" + intData.Value + ") at position " + position.Value);
							jsonArray.ReplaceAt(position.Value, intData.Value);
							break;
						case Field.Float:
							if (debug.Value) jsonObject.DebugInEditor("Replacing " + jsonField.Value + " (" + floatData.Value + ") at position " + position.Value);
							jsonArray.ReplaceAt(position.Value, floatData.Value);
							break;
						case Field.String:
							if (debug.Value) jsonObject.DebugInEditor("Replacing " + jsonField.Value + " (" + stringData.Value + ") at position " + position.Value);
							jsonArray.ReplaceAt(position.Value, stringData.Value);
							break;
						case Field.Color:
							if (debug.Value) jsonObject.DebugInEditor("Replacing " + jsonField.Value + " " + colorData.Value + " at position " + position.Value);
							jsonArray.ReplaceAt(position.Value, JSON.Serialize(colorData.Value));
							break;
						case Field.Vector2:
							if (debug.Value) jsonObject.DebugInEditor("Replacing " + jsonField.Value + " " + vector2Data.Value + " at position " + position.Value);
							jsonArray.ReplaceAt(position.Value, JSON.Serialize(vector2Data.Value));
							break;
						case Field.Vector3:
							if (debug.Value) jsonObject.DebugInEditor("Replacing " + jsonField.Value + " " + vector3Data.Value + " at position " + position.Value);
							jsonArray.ReplaceAt(position.Value, JSON.Serialize(vector3Data.Value));
							break;
						case Field.Object:
							if (debug.Value) jsonObject.DebugInEditor("Replacing " + jsonField.Value + " " + objectData.Value + " at position " + position.Value);
							jsonArray.ReplaceAt(position.Value, JSON.Serialize(JSON.ParseString(objectData.Value)));
							break;
						default:
							break;
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
