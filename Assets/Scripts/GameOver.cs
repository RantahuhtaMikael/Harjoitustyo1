using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    private PlayerController playerControllerScript; //referenssi pelaaja scriptiin
    
    
    void Start()
    {
       gameOverUI.SetActive(false); //varmistuksena ett� Game Over UI ei ole n�kyviss�
       playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();//laitettu jotta voidaan tarkistaa scriptist� onko game over vai ei

    }

    
    void Update()
    {   //tarkastaa onko gameover totta ja jos on niin tuo UI:n n�kyviin
        if (playerControllerScript.gameOver == true)
        {

            gameOverUI.SetActive(true); //tuo UI:n n�kyviin kun peli loppuu

        }
        
    }
}
