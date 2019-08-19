using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class genderSceneScript : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public void Man()
    {
        PlayerPrefs.SetInt("gender", 1);
        SceneManager.LoadScene("mngrScene");
    }
    public void Woman()
    {
        PlayerPrefs.SetInt("gender", 2);
        SceneManager.LoadScene("mngrScene");
    }
    public void Third()
    {
        PlayerPrefs.SetInt("gender", 3);
        SceneManager.LoadScene("mngrScene");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print("something");
    }
}
