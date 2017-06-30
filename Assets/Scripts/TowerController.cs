using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour {
    public GameObject bullet;

    private bool canShoot = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(canShoot)
        {
            Vector2 point = new Vector2(transform.position.x, transform.position.y);

            Collider2D hit = Physics2D.OverlapCircle(point, 1);

            if(hit.CompareTag("Enemy"))
            {
                Destroy(hit.gameObject);
            }

            Cooldown();
        }

	}

    void Cooldown()
    {
        canShoot = false;
        Invoke("EnableShoot", .5f);
    }

    void EnableShoot()
    {
        canShoot = true;
    }
}
