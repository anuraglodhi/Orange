using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour {
    public GameObject orange;
    public GameObject[] ducks = new GameObject[3];
    private GameObject knife;
    private GameObject scoreManager;
    private GameObject gameOverManager;
    private bool fire = false;
    private bool knifeAvail;

    private void Start()
    {
        orange = GameObject.FindGameObjectWithTag("Orange");
        scoreManager = GameObject.Find("ScoreManager");
        gameOverManager = GameObject.Find("GameOverManager");
        knife = gameObject;
        DuckInstantiate();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonUp(0) && !fire)
        {
            fire = true;
        }
        Fire();
	}

    private void Fire()
    {
        if (fire)
        {
            knife.transform.Translate(0, 0.2f, 0);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Orange")
        {
            scoreManager.GetComponent<ScoreManager>().ScoreUpdate();
        }
        else if(collision.tag == "Duck")
        {
            //gameOverManager.GetComponent<GameOver>().GameOverFunc();
            gameOverManager.GetComponent<GameOver>().alpha = true;
            Destroy(orange);
            DestroyDucks(ducks);
        }
        else if(collision.tag == "Wall")
        {
            Destroy();
        }
        Destroy();
    }

    private void DestroyDucks(GameObject[] ducks)
    {
        foreach(GameObject duck in ducks)
        {
            Destroy(duck);
        }
    }

    private void Destroy()
    {
        GameObject.Destroy(knife);
    }

    void DuckInstantiate()
    {
        ducks[0] = GameObject.Find("SlowDuck");
        ducks[1] = GameObject.Find("MedSpeedDuck");
        ducks[2] = GameObject.Find("FastDuck");
    }
}
