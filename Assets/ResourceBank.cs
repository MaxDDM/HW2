using System.Collections.Generic;
using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    public Dictionary<Resource, ObservableInt> _resources = new Dictionary<Resource, ObservableInt>();

    private void Awake()
    {
        _resources[Resource.Humans] = new ObservableInt(0);
        _resources[Resource.Food] = new ObservableInt(0);
        _resources[Resource.Wood] = new ObservableInt(0);
        _resources[Resource.Stone] = new ObservableInt(0);
        _resources[Resource.Gold] = new ObservableInt(0);
    }

    public void ChangeResource(Resource r, int v)
    {
        _resources[r].Value += v;
    }

    public int GetResource(Resource r)
    {
        return _resources[r].Value;
    }
}
