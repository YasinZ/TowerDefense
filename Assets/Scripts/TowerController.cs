using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour {
    public GameObject bullet;

    private bool canShoot = true;
    private GameObject obj;
    private GameObject bulletCreated;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(canShoot)
        {
            Vector2 point = new Vector2(transform.position.x, transform.position.y);

            Collider2D hit = Physics2D.OverlapCircle(point, 1f);

            if(hit.CompareTag("Enemy"))
            {
                obj = hit.gameObject;
                Shoot();
            }

            canShoot = false;
            Cooldown();
        }

	}

    void Cooldown()
    {
        Invoke("EnableShoot", 1);
    }

    void Shoot()
    {
        bulletCreated = Instantiate(bullet, transform.position, Quaternion.identity);
        //bulletCreated.transform.LookAt(obj.transform);
        //Invoke("FollowTarget", 1);

    }

    void FollowTarget()
    {
        while(bulletCreated.transform.position != obj.transform.position)
        {
            bulletCreated.transform.position = Vector2.MoveTowards(bulletCreated.transform.position, obj.transform.position, 0.01f);
        }
    }

    void EnableShoot()
    {
        canShoot = true;
    }
}
