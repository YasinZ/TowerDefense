using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public GameObject canvas;

    private int HP = 10;
    private Vector3 direction;

	// Use this for initialization
	void Start () {
        canvas = GameObject.FindWithTag("Canvas");

        direction = new Vector3(0, -0.01f, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(direction);
	}



    public void ChangeDirection(int direct)
    {
        switch (direct)
        {
            case 0: // Up
                break;
            case 1: // Right
                direction = new Vector3(0.01f, 0, 0);
                break;
            case 2: // Down
                direction = new Vector3(0, -0.01f, 0);
                break;
            case 3: // Left
                direction = new Vector3(-0.01f, 0, 0);
                break;
            case 4: // Done
                Destroy(gameObject, 0);
                canvas.GetComponent<CanvasController>().TakeDamange();
                break;
            default:
                break;
        }
    }

    public int GetHP()
    {
        return HP;
    }



}
