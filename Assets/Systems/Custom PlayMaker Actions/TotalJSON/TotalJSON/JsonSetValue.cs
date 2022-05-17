using Leguar.TotalJSON;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Add or replace key value pair in JSON")]
	[ActionCategory("TotalJSON")]
	public class JsonSetValue : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Json String")]
		public FsmString jsonData;

		[RequiredField]
		[Tooltip("Json Field")]
		public FsmString jsonField;

		public enum Field { Bool, Int, Float, String, Color, Vector2, Vector3, Quaternion, Object}
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
		public FsmQuaternion quaternionData;
		[Tooltip("Context sensitive parameter. Depends on Property.")]
		[UIHint(UIHint.TextArea)]
		public FsmString objectData;

		[ActionSection("Settings")]
		public FsmBool debug;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			JSON jsonObject;
			if (jsonData.Value.Length>0)
			{
				jsonObject = JSON.ParseString(jsonData.Value);
			}
			else
			{
				jsonObject = new JSON();
			}
			
			switch (property)
			{
				case Field.Bool:
					if (debug.Value) jsonObject.DebugInEditor(jsonField.Value + "=" + boolData.Value);
					jsonObject.AddOrReplace(jsonField.Value, boolData.Value);
					break;
				case Field.Int:
					if (debug.Value) jsonObject.DebugInEditor(jsonField.Value + "=" + intData.Value);
					jsonObject.AddOrReplace(jsonField.Value, intData.Value);
					break;
				case Field.Float:
					if (debug.Value) jsonObject.DebugInEditor(jsonField.Value + "=" + floatData.Value);
					jsonObject.AddOrReplace(jsonField.Value, floatData.Value);
					break;
				case Field.String:
					if (debug.Value) jsonObject.DebugInEditor(jsonField.Value + "=" + stringData.Value);
					jsonObject.AddOrReplace(jsonField.Value, stringData.Value);
					break;
				case Field.Color:
					if (debug.Value) jsonObject.DebugInEditor(jsonField.Value + "=" + colorData.Value);
					jsonObject.AddOrReplace(jsonField.Value, "#" + ColorUtility.ToHtmlStringRGB(colorData.Value));
					break;
				case Field.Vector2:
					if (debug.Value) jsonObject.DebugInEditor(jsonField.Value + "=" + vector2Data.Value);
					jsonObject.AddOrReplace(jsonField.Value, JSON.Serialize(vector2Data.Value));
					break;
				case Field.Vector3:
					if (debug.Value) jsonObject.DebugInEditor(jsonField.Value + "=" + vector3Data.Value);
					jsonObject.AddOrReplace(jsonField.Value, JSON.Serialize(vector3Data.Value));
					break;
				case Field.Quaternion:
					if (debug.Value) jsonObject.DebugInEditor(jsonField.Value + "=" + quaternionData.Value);
					jsonObject.AddOrReplace(jsonField.Value, JSON.Serialize(quaternionData.Value));
					break;
				case Field.Object:
					if (debug.Value) jsonObject.DebugInEditor(jsonField.Value + "=" + objectData.Value);
					jsonObject.AddOrReplace(jsonField.Value, JSON.Serialize(JSON.ParseString(objectData.Value)));
					break;
				default:
					break;
			}
			jsonData.Value = jsonObject.CreateString();

			Finish();
		}


	}

}
