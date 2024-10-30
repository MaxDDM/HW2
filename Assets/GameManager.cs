using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ResourceBank _resourceBank = new ResourceBank();
    private void Awake()
    {
        _resourceBank.ChangeResource(Resource.Humans, 10);
        _resourceBank.ChangeResource(Resource.Food, 5);
        _resourceBank.ChangeResource(Resource.Wood, 5);
    }
}
