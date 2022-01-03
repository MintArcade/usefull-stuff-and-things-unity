using UnityEngine;

[DisallowMultipleComponent]
public class PoolNoodle : MonoBehaviour
{
	private Transform poolTransform;

	public void Init(Transform _transform)
	{
		poolTransform = _transform;
	}

	public void Return()
	{
		transform.parent = poolTransform;
		gameObject.SetActive(false);
	}
}
