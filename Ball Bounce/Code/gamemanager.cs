using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gamemanager : MonoBehaviour
{
    public static gamemanager instance;
    int score;
   public Text scoreText;
    public GameObject gamestartui;

    private void Awake()
    {
        instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gamestart()
    {
        gamestartui.SetActive(false);
        scoreText.gameObject.SetActive(true); 
    }



    public void Restart()
    {
        SceneManager.LoadScene("game");
    }
    public void scoreup()
    {
      
        score++;
        scoreText.text = score.ToString();
    }

}
