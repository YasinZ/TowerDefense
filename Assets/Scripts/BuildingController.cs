using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : MonoBehaviour {
    public GameObject towerPlacement;
    public GameObject trianglePrefab;
    public GameObject canvas;

    private CanvasController canvasController;

    // Use this for initialization
    void Start () {
        canvas = GameObject.FindWithTag("Canvas");
        canvasController = canvas.GetComponent<CanvasController>();
    }
	
	// Update is called once per frame
	void Update () {
        foreach (var touch in Input.touches)
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
              
                if(hit && hit.collider.gameObject.CompareTag("X") && canvasController.CanBuildTower01())
                {
                    Instantiate(trianglePrefab, hit.collider.gameObject.transform.position, Quaternion.identity);
                    Destroy(hit.collider.gameObject);
                    canvasController.BuildTower01();
                }
             

            }
    }
}
