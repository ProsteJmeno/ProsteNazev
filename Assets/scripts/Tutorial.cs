using UnityEngine;
using System.Linq;
using Assets.scripts;

public class Tutorial : MonoBehaviour
{
    private int signNumber = 0;
    public Sign[] allSigns;

    private void Awake()
    {
        Time.timeScale = 0;
        SelectSign(allSigns.First());
    }
    
    void Update()
    {
        var currentScene = allSigns[signNumber];
        var anyKeyDown = currentScene.continueKeys.Any(k => Input.GetKeyDown(k));
        if (anyKeyDown)
        {
            if (signNumber == allSigns.Length - 1)
            {
                Time.timeScale = 1;
                Destroy(gameObject);
                return;
            }

            signNumber++;
            SelectSign(allSigns[signNumber]);
        }
        
    }
    
    private void SelectSign(Sign sign)
    {
        foreach (var s in allSigns)
        {
            s.gameObject.SetActive(false);
        }
        sign.gameObject.SetActive(true);
    }
}
