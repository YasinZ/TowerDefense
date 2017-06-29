using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointController : MonoBehaviour {

    public int direction = 2;
    private Collider2D obj;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        obj = other;
        Invoke("Change", 1);
    }

    void Change()
    {
        obj.GetComponent<EnemyController>().ChangeDirection(direction);
    }
}
