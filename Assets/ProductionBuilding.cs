using System.Collections;
using UnityEngine;

public class ProductionBuilding : MonoBehaviour
{
    public ResourceBank resourceBank;

    private float _productionTime = 3;

    public void humanButtonOnClick()
    {
        StartCoroutine("WaitAfterClick");
        resourceBank.ChangeResource(Resource.Humans, 1);
    }

    public void foodButtonOnClick()
    {
        StartCoroutine("WaitAfterClick");
        resourceBank.ChangeResource(Resource.Food, 1);
    }

    public void woodButtonOnClick()
    {
        StartCoroutine("WaitAfterClick");
        resourceBank.ChangeResource(Resource.Wood, 1);
    }

    public void stoneButtonOnClick()
    {
        StartCoroutine("WaitAfterClick");
        resourceBank.ChangeResource(Resource.Stone, 1);
    }

    public void goldButtonOnClick()
    {
        StartCoroutine("WaitAfterClick");
        resourceBank.ChangeResource(Resource.Gold, 1);
    }

    private IEnumerator WaitAfterClick()
    {
        yield return new WaitForSeconds(_productionTime);
    }
}