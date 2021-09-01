using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private Text poeni, highScore;
    private static GameOver instanca;


    private void Update()
    {
        poeni.text = Level.Get_intanca().get_poeni().ToString();
        highScore.text = "Highscore: " + Highscore.getHighscore().ToString();
    }

    private void Start()
    {
        poeni = transform.Find("Poeni_tekst").GetComponent<Text>();
        highScore = transform.Find("Highscore_tekst").GetComponent<Text>();
    }

    private void Awake()
    {
        instanca = this;
        
    }

    

    public static GameOver Getinstanca() {
        return instanca;
    }

    

    public void GameOver_ekran(bool upali) {//metoda koja prkazuje i skanja gameover ekran
        if (upali == false) {
            this.gameObject.SetActive(false);
        }
        else
            this.gameObject.SetActive(true);
    }

    public void restartuj() { // metoda koja se dodeljuje dugmetu pokusaj ponovo
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    public void pocetni_ekran()//metoda koja prebacuje na pocetni ekran kad se klikne pocetni meni
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("PocetniEkran");
    }

}
