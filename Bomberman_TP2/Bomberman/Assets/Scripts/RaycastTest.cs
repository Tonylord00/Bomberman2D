using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    public Camera m_Camera;

    public void Update()
    {
        if (Input.GetMouseButton(0))
        {
            TestRaycast();
        }
        else
        {
            m_IsDragging = false;
        }

        if (m_IsDragging)
        {
            Vector3 worldPos = m_Camera.ScreenToWorldPoint(Input.mousePosition);
            worldPos.z -= m_Camera.transform.position.z;
            m_DraggingTransform.transform.position = worldPos;
        }
    }

    private bool m_IsDragging;
    private Transform m_DraggingTransform;

    private void TestRaycast()
    {
        Vector3 origin = m_Camera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = origin - m_Camera.transform.position;

        RaycastHit2D hit = Physics2D.Raycast(origin, direction, Mathf.Infinity, 1 << LayerMask.NameToLayer("Collectable"));

        if (hit.collider != null)
        {
            m_DraggingTransform = hit.transform;
            m_IsDragging = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(m_Camera.ScreenToWorldPoint(Input.mousePosition), 0.5f);

        Gizmos.color = Color.green;
        Gizmos.DrawSphere(m_Camera.ScreenToWorldPoint(Input.mousePosition) - m_Camera.transform.position, 0.5f);

        Debug.DrawLine(m_Camera.ScreenToWorldPoint(Input.mousePosition), m_Camera.ScreenToWorldPoint(Input.mousePosition) - m_Camera.transform.position);
    }
}
