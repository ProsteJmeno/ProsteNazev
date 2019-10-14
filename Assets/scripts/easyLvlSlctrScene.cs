using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class easyLvlSlctrScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("INITIALIZING");
        //if (!PlayerPrefs.HasKey("easyHighestLevel"))
        //{
        //    //SceneManager.LoadScene("easyTutorial");
            
        //}
        //else
        {
            GameObject[] buttons = GameObject.FindGameObjectsWithTag("buttons1");
            foreach (GameObject bttn in buttons)
            {
                int maxLevel = PlayerPrefs.GetInt("easyHighestLevel");
                maxLevel = 5;
                string name = bttn.name;
                int index = name.IndexOf("l");
                string finalName = name.Substring(index + 3);
                if (!(maxLevel >= int.Parse(finalName)))
                {
                    //Destroy(bttn);
                    //bttn.enabled = false;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
