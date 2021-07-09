using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class Exercise : ScriptableObject
{
    public string exerciseName;
    public int sets;
    public float reps;
    public List<float> weights;
}
