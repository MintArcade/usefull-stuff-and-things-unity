using Leguar.TotalJSON;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get key value of JSON")]
	[ActionCategory("TotalJSON")]
	public class JsonGetValue : FsmStateAction
	{
		[RequiredField]
		//[UIHint(UIHint.Variable)]
		[UIHint(UIHint.TextArea)]
		[Tooltip("Json String")]
		public FsmString jsonData;

		[RequiredField]
		[Tooltip("Json Field")]
		public FsmString jsonField;

		public enum Field { Bool, Int, Float, String, Color, Vector2, Vector3, Quaternion, Object }
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

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			JSON jSON = JSON.ParseString(jsonData.Value);
			jSON.SetProtected();

			switch (property)
			{
				case Field.Bool:
					boolData.Value = jSON.GetBool(jsonField.Value);
					break;
				case Field.Int:
					intData.Value = jSON.GetInt(jsonField.Value);
					break;
				case Field.Float:
					floatData.Value = jSON.GetFloat(jsonField.Value);
					break;
				case Field.String:
					stringData.Value = jSON.GetString(jsonField.Value);
					break;
				case Field.Color:
					//colorData.Value = jSON.GetJSON(jsonField.Value).Deserialize<Color>();
					Color _color;
					ColorUtility.TryParseHtmlString("#"+jSON.GetString(jsonField.Value), out _color);
					colorData.Value = _color;
					break;
				case Field.Vector2:
					vector2Data.Value = jSON.GetJSON(jsonField.Value).Deserialize<Vector2>();
					break;
				case Field.Vector3:
					vector3Data.Value = jSON.GetJSON(jsonField.Value).Deserialize<Vector3>();
					break;
				case Field.Quaternion:
					quaternionData.Value = jSON.GetJSON(jsonField.Value).Deserialize<Quaternion>();
					break;
				case Field.Object:
					objectData.Value = jSON.GetJSON(jsonField.Value).CreateString();
					break;
				default:
					break;
			}

			Finish();
		}

#if UNITY_EDITOR
		public override string AutoName()
		{
			switch (property)
			{
				case Field.Bool:
					return ActionHelpers.AutoName(jsonField.Value, boolData.Value.ToString());
				case Field.Int:
					return ActionHelpers.AutoName(jsonField.Value, intData.Value.ToString());
				case Field.Float:
					return ActionHelpers.AutoName(jsonField.Value, floatData.Value.ToString());
				case Field.String:
					return ActionHelpers.AutoName(jsonField.Value, stringData.Value);
				case Field.Color:
					return ActionHelpers.AutoName(jsonField.Value, colorData.Value.ToString());
				case Field.Vector2:
					return ActionHelpers.AutoName(jsonField.Value, vector2Data.Value.ToString());
				case Field.Vector3:
					return ActionHelpers.AutoName(jsonField.Value, vector3Data.Value.ToString());
				case Field.Quaternion:
					return ActionHelpers.AutoName(jsonField.Value, quaternionData.Value.ToString());
				case Field.Object:
					return ActionHelpers.AutoName(jsonField.Value, objectData.Value.ToString());
				default:
					break;
			}
			return ActionHelpers.AutoName("Field", jsonData, jsonField);
		}
#endif
	}

}
