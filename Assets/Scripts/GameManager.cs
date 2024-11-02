using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{ 

    public void StartGame()//assignataan START GAME -nappulaan menussa
    {
        //siirtyy itse pelitasoon kun painaa start game nappulaa
        SceneManager.LoadScene("Prototype 3");

    }
    

    public void QuitGame()//assignataan QUIT-nappulaan menussa
    {
        //sulkee pelin kun painaa quit nappulaa aloitus menussa
        Application.Quit();

    }

    public void Retry() //assignataan Retry-nappulaan Game Over näytössä
    {
        //aloittaa tason alusta
        SceneManager.LoadScene("Prototype 3");

    }

    public void QuitMenu()//assignataan menu-nappulaan Game Over näytössä
    {
        //palaa menuun
        SceneManager.LoadScene("Menu");

    }





}
