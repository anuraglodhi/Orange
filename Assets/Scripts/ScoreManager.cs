using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour {
    public TextMeshProUGUI scoreText;
    [HideInInspector]
    public float score;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	public void ScoreUpdate () {
        score += 1;
        scoreText.text = "Score:" + score.ToString();
	}
}
