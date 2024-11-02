using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; //tekee sen ett‰ vain yksi instanssi Scoremanager luokasta voi olla olemassa

    //Muuttujat
    public TMP_Text currentScoreText;
    public TMP_Text highScoreText;

    public int score;
    public int highScore;

    private void Awake()//awake kutsutaan ennen starttia
    {
        
        instance = this; //tehd‰‰n t‰st‰ scriptist‰ instanssi

    }


    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0); //tallennettu highscore, default 0 jos ei ole aikaisempaa tallennettuna
        highScoreText.text = highScore.ToString() + " POINTS"; //n‰ytt‰‰ game overissa highscoren
        
        
  
    }

    public void AddPoint() //funktiota kutsutaan spawnmanagerissa ja aina kun siell‰ kutsutaan-
    { //-lis‰t‰‰n yksi piste
        score += 1;
        currentScoreText.text = score.ToString() + " POINTS"; //n‰ytt‰‰ game overissa nykyiset pisteet
        
        if (highScore < score) //jos nykyinen score on suurempi kuin edellinen high score, -
            //nykyisest‰ tehd‰‰n uusi high score
        {
            PlayerPrefs.SetInt("HighScore", score);
        }

        
    }


}
