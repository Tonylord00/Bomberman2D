using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonSO", menuName = "ScriptableObjects/Data", order = 1)]
public class MonScriptableObject : ScriptableObject
{
    public bool m_ColorIsRandom;
    public Color m_DefaultColor;
    public Vector3[] m_SpawnPoints;
}
