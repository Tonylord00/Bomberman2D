
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volcano : MonoBehaviour
{
    public GameObject m_BallPrefab;
    public Transform m_SpawnTransform;

    public float m_SpawnInterval;

    public float m_VelocityMinX;
    public float m_VelocityMaxX;

    public float m_VelocityMinY;
    public float m_VelocityMaxY;

    private float m_Counter;

	// Update is called once per frame
	void Update ()
    {
        m_Counter += Time.deltaTime;
        if (m_Counter >= m_SpawnInterval)
        {
            m_Counter = 0f;
            SpawnCollectable();
        }
    }

    private void SpawnCollectable()
    {
        GameObject go = Instantiate(m_BallPrefab);
        go.transform.position = m_SpawnTransform.position;

        Rigidbody2D rigidbody = go.GetComponent<Rigidbody2D>();

        Vector2 randomForce = new Vector2(Random.Range(m_VelocityMinX, m_VelocityMaxX), Random.Range(m_VelocityMinY, m_VelocityMaxY));
        rigidbody.AddForce(randomForce);
    }
}
