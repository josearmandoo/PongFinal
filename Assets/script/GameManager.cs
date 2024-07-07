using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int scorego;
    public int scoreend;
    
    public TMP_Text uIScoreGo;
    
    public TMP_Text uIScoreEnd;

    public TMP_Text uIWinTextCont;

    public GameObject uIWinLose;
   
    public static GameManager Instance;

    public SceneManagement sceneManagement;

    public void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void Score(string sideWallName)
    {
        if (sideWallName == "SideWallGo")
        {
            scoreend += 10;
            uIScoreEnd.text = scoreend.ToString();
            ScoreCheck();
        }
        else
        {
            scorego += 10;
            uIScoreGo.text = scorego.ToString();
            ScoreCheck();
        }    
            
    }

    private void Delay()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
    private void ScoreCheck()
    {
        if (scorego == 20)
        {
            uIWinLose.SetActive(true);
            uIWinTextCont.text = "Go Win!";
            Invoke("Delay", 2.0f);

        }
        else if (scoreend == 20)
        {
            uIWinLose.SetActive(true);
            uIWinTextCont.text = "End Win!";
            Invoke("Delay", 2.0f);
        }
    }

}
