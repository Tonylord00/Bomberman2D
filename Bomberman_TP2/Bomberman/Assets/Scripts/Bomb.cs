using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
    public GameObject explosionPrefab;
    public LayerMask masklevel;
    private bool exploded = false;

	// Use this for initialization
	void Start () {
        Invoke("Explode", 3f);
	}
	
    void Explode()
    {

        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        StartCoroutine(CreateExplosions(Vector2.up));
        StartCoroutine(CreateExplosions(Vector2.left));
        StartCoroutine(CreateExplosions(Vector2.right));
        StartCoroutine(CreateExplosions(Vector2.down));

        GetComponent<MeshRenderer>().enabled = false;
        exploded = true;
        transform.FindChild("Collider").gameObject.SetActive(false);
        Destroy(gameObject, .3f);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!exploded && other.CompareTag("Explosion"))
        {
            CancelInvoke("Explode");
            Explode();
        }
    }

    private IEnumerator CreateExplosions(Vector3 direction)
    {
        for(int i =1; i<3; i++)
        {
            RaycastHit hit;

            Physics.Raycast(transform.position + new Vector3(0, .5f), direction, out hit, i, masklevel);
            
            if(!hit.collider)
            {
                Instantiate(explosionPrefab, transform.position + (i * direction), explosionPrefab.transform.rotation);
            }
            else
            {
                break;
            }
            yield return new WaitForSeconds(.05f);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
