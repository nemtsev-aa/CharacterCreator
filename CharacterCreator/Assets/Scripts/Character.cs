using System.Linq;
using UnityEngine;

public class Character : MonoBehaviour {
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public Birthplaces Birthplace { get; private set; }
    [field: SerializeField] public BasicParameters BasicParameters { get; private set; }

    public void SetName(string name) {
        Name = name;
    }

    public void SetBirthplaces(Birthplaces places) {
        Birthplace = places;
    }

    public void SetBasicParameters(BasicParameters parameters) {
        BasicParameters = parameters;
    }

    public void SetBasicParameterValue(BasicParameterTypes type, int value) {
        BasicParameters.Parameters.FirstOrDefault(t => t.Type == type).SetValue(value);
    }
}
