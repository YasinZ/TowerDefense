using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private int HP = 10;


    private Vector3 direction;

	// Use this for initialization
	void Start () {
        direction = new Vector3(-0.01f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(direction);
	}



    public void ChangeDirection(int direction)
    {
        switch (direction)
        {
            case "left":
                direction = new Vector3(-0.01f, 0, 0);
        }
    }

    public int GetHP()
    {
        return HP;
    }



}
