using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public MonScriptableObject m_ScriptableObject;

    private List<Light> m_LightList;

    public void Start()
    {
        m_LightList = new List<Light>();

        foreach (Vector3 spawnPoint in m_ScriptableObject.m_SpawnPoints)
        {
            GameObject light = new GameObject("Light");
            light.AddComponent<Light>();

            light.transform.position = spawnPoint;
            light.GetComponent<Light>().enabled = false;

            if (m_ScriptableObject.m_ColorIsRandom)
            {
                light.GetComponent<Light>().color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            }
            else
            {
                light.GetComponent<Light>().color = m_ScriptableObject.m_DefaultColor;
            }

            m_LightList.Add(light.GetComponent<Light>());
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (Light light in m_LightList)
            {
                light.enabled = !light.enabled;
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            UpdateLights();
        }

    }

    void UpdateLights()
    {
        foreach (var myLight in m_LightList)
        {
            myLight.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
}
