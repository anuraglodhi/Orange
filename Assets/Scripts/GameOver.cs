using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    public TextMeshProUGUI gameOverText;
    public Image coverImage;

    [HideInInspector]
    public bool alpha = false;
    private Color c;

    /*public void GameOverFunc()
    {
            gameOverText.GetComponent<Animator>().enabled = true;
            coverImage.GetComponent<Animator>().enabled = true;
    }*/

    private void Start()
    {
        c.a = 0.1f;
    }

    private void Update()
    {
        if(alpha)
        {
            StartCoroutine(alphaUpdate());
        }
    }

    public IEnumerator alphaUpdate()
    {
        gameOverText.alpha += 0.1f;
        coverImage.color += c;
        yield return new WaitForSeconds(0.1f) ;
    }
}
