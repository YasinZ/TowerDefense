using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour {

    public Text tHealth;
    public Text tMoney;
    public Text tNext;
    public Text tTurnCounter;


    private bool gameActive = false;
    private int health = 5;
    private int money  = 200;
    private int turnCounter = 0;

	// Use this for initialization
	void Start () {
        tHealth.text = "" + health;
        tNext.text = "Start";
        tTurnCounter.text = "" + turnCounter;
        tMoney.text = "" + money;
	}

    public void TakeDamange()
    {
        health--;

        if(health == 0)
        {
            SceneManager.LoadSceneAsync(0);
        }
                
        tHealth.text = "" + health;
    }

    public void BuildTowerTriangle()
    {
        money -= 50;
        tMoney.text = "" + money;
    }

    public void BuildTowerPentagon()
    {
        money -= 150;
        tMoney.text = "" + money;
    }

    public bool CanBuildTowerTriangle()
    {
        if (money > 49)
            return true;

        return false;
    }

    public bool CanBuildTowerPentagon()
    {
        if (money > 149)
            return true;

        return false;
    }

    public bool IsGameActive()
    {
        return gameActive;
    }

    public void StartGame()
    {
        if (gameActive)
            return;

        gameActive = true;
        GameObject.FindWithTag("Spawnpoint").GetComponent<SpawnController>().StartSpawning();
    }
}
