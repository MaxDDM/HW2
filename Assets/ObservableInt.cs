using UnityEngine;

public class ObservableInt
{
    public event System.Action<int> OnValueChanged;

    private int _value;
    public int Value
    {
        get { return _value; }
        set
        {
            _value = value;
            OnValueChanged?.Invoke(value);
        }
    }
    public ObservableInt(int value)
    {
        _value = value;
    }
}
