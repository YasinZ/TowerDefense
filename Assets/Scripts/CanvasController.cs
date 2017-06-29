using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour {

    public Text tHealth;
    public Text tMoney;
    public Text tNext;
    public Text tTurnCounter;

    private int health = 5;
    private int money  = 100;
    private int turnCounter = 0;

	// Use this for initialization
	void Start () {
        tHealth.text = "" + health;
        tNext.text = "Next";
        tTurnCounter.text = "" + turnCounter;
        tMoney.text = "" + money;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamange()
    {

    }
}
