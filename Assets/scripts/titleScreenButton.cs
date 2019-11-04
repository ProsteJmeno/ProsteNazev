using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleScreenButton : MonoBehaviour
{
    public void Button()
    {
        SceneManager.LoadScene("menu");
    }
}
