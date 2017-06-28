﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointController : MonoBehaviour {

    public int direction = 2;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        other.GetComponent<EnemyController>().ChangeDirection(direction);
    }
}
