using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    private int damage = 1;

    private int indexToFollow;
    private GameObject [] objsToFollow;
    private GameObject objToFollow;


    // Use this for initialization
    void Start () {
		    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, objToFollow.transform.position, 0.05f);
    }

    public void setFollowIndex(int index)
    {
        indexToFollow = index;
        objsToFollow = GameObject.FindGameObjectsWithTag("Enemy");

        foreach(GameObject obj in objsToFollow)
        {
            if(obj.GetComponent<EnemyController>().index == indexToFollow)
            {
                objToFollow = obj;
            }
        }

    }

    public void SetDamage(int dmg)
    {
        if (dmg < 0 || dmg > 10)
            return;

        damage = dmg;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            other.GetComponent<EnemyController>().TakeDamange(damage);
        }
    }
}
