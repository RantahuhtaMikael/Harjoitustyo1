using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    private PlayerController playerControllerScript; //referenssi pelaaja scriptiin
    
    
    void Start()
    {
       gameOverUI.SetActive(false); //varmistuksena että Game Over UI ei ole näkyvissä
       playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();//laitettu jotta voidaan tarkistaa scriptistä onko game over vai ei

    }

    
    void Update()
    {   //tarkastaa onko gameover totta ja jos on niin tuo UI:n näkyviin
        if (playerControllerScript.gameOver == true)
        {

            gameOverUI.SetActive(true); //tuo UI:n näkyviin kun peli loppuu

        }
        
    }
}
