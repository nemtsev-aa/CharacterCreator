using System;
using UnityEngine;

[Serializable]
public class BasicParameter {
    public BasicParameter(BasicParameterTypes type, int value) {
        Type = type;
        Value = value;
    }

    [field: SerializeField] public BasicParameterTypes Type { get; private set; }
    [field: SerializeField] public int Value { get; private set; }

    public void SetType(BasicParameterTypes type) {
        Type = type;
    }

    public void SetValue(int value) {
        Value = value;
    }
}
