using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BasicParameters {
    public BasicParameters(List<BasicParameter> parameters) {
        Parameters = parameters;
    }

    [field: SerializeField] public List<BasicParameter> Parameters { get; private set; }
}
