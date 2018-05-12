using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSpeedManager : MonoBehaviour{
    public GameObject[] ducks;
    public GameObject scoreManager;

    private float speedToAdd;
    //private float speed = ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        speedToAdd = scoreManager.GetComponent<ScoreManager>().score * 0.1f;
		for(int i = 1; i == 3; i++)
        {
            ducks[i].GetComponent<DuckMovement>().speedToAdd += speedToAdd;
            Debug.Log(ducks[i].name);
        }
	}
}
