using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : MonoBehaviour {
    public GameObject towerPlacement;
    public GameObject trianglePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        foreach (var touch in Input.touches)
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);

               
                for(int i = 0; i < 3; i++)
                {
                    if(hit && hit.collider.gameObject.CompareTag("X"))
                    {
                        Debug.Log("hereadfssdf");
                        Instantiate(trianglePrefab, hit.collider.gameObject.transform.position, Quaternion.identity);
                        Destroy(hit.collider.gameObject);
                        
                    }
             
                }

                //if (hit && hit.collider.gameObject.CompareTag("X"))
                //{
                //    Debug.Log("hereadfssdf");
                //    Instantiate(trianglePrefab, hit.collider.gameObject.transform.position, Quaternion.identity);
                //    Destroy(gameObject);
                //}

            }
    }
}
