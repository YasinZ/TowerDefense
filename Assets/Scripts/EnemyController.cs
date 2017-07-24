using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public GameObject canvas;
    public int index;
    public GameObject healthBar;

    private float HP = 4;
    private float maxHP = 4;
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

    public void SetHP(float hp)
    {
        HP = hp;
        maxHP = hp;
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

    public float GetHP()
    {
        return HP;
    }

    public void TakeDamange(int dmg)
    {
        HP -= dmg;
        if (HP < 1)
            Die();
        
        float xPos = -1.2664f - healthBar.transform.localPosition.x;
        xPos /= 2.0f;
        xPos -= -1.2664f;
        xPos *= -1;

        Vector3 pos = new Vector3(xPos, healthBar.transform.localPosition.y, 0);
        Vector3 scale = new Vector3((healthBar.transform.localScale.x * (HP / maxHP)), healthBar.transform.localScale.x, 0);

        healthBar.transform.localScale = scale;
        healthBar.transform.localPosition = pos;
    }

    void Die()
    {
        Destroy(gameObject);
        canvasController.IncreaseBalance();
    }

}
