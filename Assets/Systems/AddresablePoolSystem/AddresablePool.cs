using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddresablePool : MonoBehaviour
{
	private Dictionary<string, GameObject> pool;
	private Dictionary<string, Transform> pools;

	[SerializeField] private int amount;
	[SerializeField] private AssetReference[] assetReference;

	private bool isReady;

	public static AddresablePool current;
	private void Awake()
	{
		if (current) Destroy(gameObject);
		current = this;
		pool = new Dictionary<string, GameObject>();
		pools = new Dictionary<string, Transform>();
		isReady = true;
	}

	private async void Start()
	{
		if (assetReference.Length > 0)
		{
			isReady = false;
			foreach (var item in assetReference)
			{
				await CreateNewPool(item, amount);
				//_ = CreateNewPool(item, amount);
			}
			isReady = true;
		}
	}

	// Take a noodle
	public async Task<GameObject> Get(string _name)
	{
		while (!isReady) await Task.Delay(1);

		GameObject g = null;

		// If pool data do not exist
		if (!pool.ContainsKey(_name)) await CreateNewPool(_name);

		// If there is no noodles in the pool, create one
#if UNITY_2021_2_OR_NEWER
		if (pools.GetValueOrDefault(_name).transform.childCount == 0) AddMoreNoodles(_name);
#else
		Transform t;
		pools.TryGetValue(_name, out t);
		if (t.childCount == 0) AddMoreNoodles(_name);
#endif

#if UNITY_2021_2_OR_NEWER
		g = pools.GetValueOrDefault(_name).transform.GetChild(0).gameObject;
#else
		pools.TryGetValue(_name, out t);
		g = t.transform.GetChild(0).gameObject;
#endif

		//await Task.Yield();
		g.SetActive(true);

		return g;
	}

	private async Task CreateNewPool(AssetReference assetReference, int amount)
	{
		AsyncOperationHandle<GameObject> goHandle = assetReference.LoadAssetAsync<GameObject>();
		//await Task.Delay(1);
		await goHandle.Task;
		GameObject noodle = goHandle.Result;

		string _name = assetReference.Asset.name;

		GameObject p = new GameObject(_name);

#if UNITY_2021_2_OR_NEWER
		pool.TryAdd(_name, noodle);
		pools.TryAdd(_name, p.transform);
#else
		pool.Add(_name, noodle);
		pools.Add(_name, p.transform);
#endif

		p.transform.parent = transform;

		for (int i = 0; i < amount; i++)
		{
			GameObject g = Instantiate(noodle, p.transform);
			g.AddComponent<PoolNoodle>();
			g.GetComponent<PoolNoodle>().Init(p.transform);
			g.SetActive(false);
		}
	}

	private async Task CreateNewPool(string _name)
	{
		isReady = false;
		AsyncOperationHandle<GameObject> goHandle = Addressables.LoadAssetAsync<GameObject>(_name);
		await goHandle.Task;

#if UNITY_2021_2_OR_NEWER
		if (goHandle.Task.IsCompletedSuccessfully)
		{
			GameObject noodle = goHandle.Result;
			GameObject p = new GameObject(_name);

			pool.TryAdd(_name, noodle);
			pools.TryAdd(_name, p.transform);

			p.transform.parent = transform;
			AddMoreNoodles(_name);
		}
#else
		if (goHandle.Task.IsCompleted)
		{
			GameObject noodle = goHandle.Result;
			GameObject p = new GameObject(_name);

			pool.Add(_name, noodle);
			pools.Add(_name, p.transform);

			p.transform.parent = transform;
			AddMoreNoodles(_name);
		}
#endif

		isReady = true;
	}

	private void AddMoreNoodles(string _name)
	{
		foreach (Transform item in transform)
		{
			if (string.Compare(item.gameObject.name, _name) == 0)
			{
#if UNITY_2021_2_OR_NEWER
				GameObject n = pool.GetValueOrDefault(_name);
#else
				GameObject n;
				pool.TryGetValue(_name, out n);
#endif
				GameObject g = Instantiate(n, item.transform);
				g.AddComponent<PoolNoodle>();
				g.GetComponent<PoolNoodle>().Init(item.transform);
				g.SetActive(false);
			}
		}
	}
}
