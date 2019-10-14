using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;
using Assets.scripts;

public class Tutorial : GameplayPart
{
    public GameObject[] sign1;
    public GameObject[] sign2;
    public GameObject[] sign3;
    public GameObject[] sign4;
    public GameObject[] sign5;
    public int signNumber;
    private GameObject[][] allSigns;
    private Dictionary<GameObject[], KeyCode[]> continueKeys;

    private void Awake()
    {
        allSigns = new[] { sign1, sign2, sign3, sign4, sign5 };
        continueKeys = new Dictionary<GameObject[], KeyCode[]>()
        {
            {sign1,  new[]{KeyCode.E } },
            {sign2,  new[]{KeyCode.E } },
            {sign3,  new[]{KeyCode.E } },
            {sign4,  new[]{  KeyCode.E } },
            {sign5,  new[]{ KeyCode.LeftArrow, KeyCode.RightArrow} }
        };
    }
    
    private void OnEnable()
    {
        SelectSign(allSigns.First());
    }
    
    private void OnDisable()
    {
        SelectSign(null);
    }

    void Update()
    {
        if(signNumber == allSigns.Length)
        {
            Finished();
            return;
        }

        var currentScene = allSigns[signNumber];
        var keys = continueKeys[currentScene];
        var anyKeyDown = keys.Any(k => Input.GetKeyDown(k));

        if (anyKeyDown)
        {
            SelectSign(allSigns[signNumber]);
            signNumber++;
        }
        
    }

    private void SelectSign(GameObject[] sign)
    {
        if (sign == null) sign = new GameObject[0];

        var allObjects = allSigns.SelectMany(s => s);

        foreach (var o in allObjects)
        {
            o.SetActive(false);
        }

        foreach (var o in sign)
        {
            o.SetActive(true);
        }
    }
}
