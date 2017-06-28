using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private int HP = 10;

    private int next = 1;

	// Use this for initialization
	void Start () {
        Invoke("MoveToNextWayPoint", 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void MoveToNextWayPoint()
    {
        if (next == 13)
            return;

        string point = "point" + next;
        Debug.Log(point);

        float step = .1f;
        Vector2 destination = GameObject.Find(point).gameObject.transform.position;

        
        transform.position = Vector2.MoveTowards(transform.position, destination, step);
        

        next++;
        Invoke("MoveToNextWayPoint", 1);
    }

    private void Wait()
    {
        // dead function
    }

    public int GetHP()
    {
        return HP;
    }
}
