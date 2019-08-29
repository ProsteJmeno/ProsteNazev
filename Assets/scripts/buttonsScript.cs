using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonsScript : MonoBehaviour
{
    public GameObject sign;
    public float signDelay;
    private void Start()
    {
        sign.SetActive(false);
    }
    public void easyButton()
    {
        SceneManager.LoadScene("easy-level-selector-0-40");
    }
    public void mediumButton()
    {
        SceneManager.LoadScene("medium-level-selector-0-40");
    }
    public void hardButton()
    {
        sign.SetActive(true);
        StartCoroutine(signDisable(signDelay));
    }
    private IEnumerator signDisable(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        sign.SetActive(false);
    }
}
