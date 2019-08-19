using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nameSceneScript : MonoBehaviour
{

    public InputField nameBox;

    public void saveButton()
    {
        PlayerPrefs.SetString("name", nameBox.text);
        if (!(PlayerPrefs.HasKey("gender")))
        {
            SceneManager.LoadScene("genderScene");
        }
        else
        {
            SceneManager.LoadScene("mngrScene");
        }
    }
}