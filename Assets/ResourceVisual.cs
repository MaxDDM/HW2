using Mono.Cecil;
using System;
using TMPro;
using UnityEngine;

public class ResourceVisual : MonoBehaviour
{
    private Resource _resource;

    [SerializeField]
    private TextMeshProUGUI _textHuman;
    [SerializeField]
    private TextMeshProUGUI _textFood;
    [SerializeField]
    private TextMeshProUGUI _textWood;
    [SerializeField]
    private TextMeshProUGUI _textStone;
    [SerializeField]
    private TextMeshProUGUI _textGold;

    public ResourceBank resourceBank;

    private void OnEnable()
    {
        resourceBank._resources[Resource.Humans].OnValueChanged += changeHumanText;
        resourceBank._resources[Resource.Food].OnValueChanged += changeFoodText;
        resourceBank._resources[Resource.Wood].OnValueChanged += changeWoodText;
        resourceBank._resources[Resource.Stone].OnValueChanged += changeStoneText;
        resourceBank._resources[Resource.Gold].OnValueChanged += changeGoldText;
    }
    private void OnDisable()
    {
        resourceBank._resources[Resource.Humans].OnValueChanged -= changeHumanText;
        resourceBank._resources[Resource.Food].OnValueChanged -= changeFoodText;
        resourceBank._resources[Resource.Wood].OnValueChanged -= changeWoodText;
        resourceBank._resources[Resource.Stone].OnValueChanged -= changeStoneText;
        resourceBank._resources[Resource.Gold].OnValueChanged -= changeGoldText;
    }
    private void Start()
    {
        changeHumanText(resourceBank._resources[Resource.Humans].Value);
        changeFoodText(resourceBank._resources[Resource.Food].Value);
        changeWoodText(resourceBank._resources[Resource.Wood].Value);
        changeStoneText(resourceBank._resources[Resource.Stone].Value);
        changeGoldText(resourceBank._resources[Resource.Gold].Value);
    }
    private void changeHumanText(int amount)
    {
        _textHuman.text = amount.ToString();
    }

    private void changeFoodText(int amount)
    {
        _textFood.text = amount.ToString();
    }

    private void changeWoodText(int amount)
    {
        _textWood.text = amount.ToString();
    }

    private void changeStoneText(int amount)
    {
        _textStone.text = amount.ToString();
    }

    private void changeGoldText(int amount)
    {
        _textGold.text = amount.ToString();
    }
}
