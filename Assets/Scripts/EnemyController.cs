using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public GameObject canvas;
    public int index;

    private int HP = 10;
    private Vector3 direction;
    private CanvasController canvasController;

    // Use this for initialization
    void Start () {
        canvas = GameObject.FindWithTag("Canvas");
        canvasController = canvas.GetComponent<CanvasController>();

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
                canvasController.TakeDamage();
                break;
            default:
                break;
        }
    }

    public int GetHP()
    {
        return HP;
    }

    public void TakeDamange(int dmg)
    {
        HP -= dmg;
        if (HP < 1)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
        canvasController.IncreaseBalance();
    }

}
