using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    public GameObject enemy;
    public GameObject canvas;

    private CanvasController canvasController;
    private float startingHP = 4;
    private int counter = 0;

    // Use this for initialization
    void Start () {
        canvas = GameObject.FindWithTag("Canvas");
        canvasController = canvas.GetComponent<CanvasController>();

	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void StartSpawning()
    {
        InvokeRepeating("SpawnEnemy", .5f, 1);
    }

    void SpawnEnemy()
    {
        GameObject enemyObj = Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
        enemyObj.GetComponent<EnemyController>().index = counter++;
        enemyObj.GetComponent<EnemyController>().SetHP(startingHP);
        IncreaseDifficulty();
    }

    void IncreaseDifficulty()
    {
        startingHP += .5f;
    }
}
