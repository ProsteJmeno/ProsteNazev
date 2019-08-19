using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mngrsceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Awake()
    {
        //PlayerPrefs.DeleteAll();
    }
    public int level;
    private void Start()
    {
        if (!(PlayerPrefs.HasKey("name")))
        {
            SceneManager.LoadScene("nameScene");
        }
        else if (!PlayerPrefs.HasKey("gender"))
        {
            SceneManager.LoadScene("genderScene");
        }
        else
        {
            joinGame();
        }
    }
    public void joinGame()
    {

        //if (!PlayerPrefs.HasKey("level"))
        //{
        //    SceneManager.LoadScene("level1");
        //    PlayerPrefs.SetInt("level", 1);
        //}
        //else
        //{
        //    string levelToJoin = "level" + PlayerPrefs.GetInt("level");
        //    SceneManager.LoadScene(levelToJoin);
        //}
        print("something");
    }
}
