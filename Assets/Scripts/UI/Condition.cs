using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public float curValue;
    public float StartValue;
    public float maxValue;
    public float passiveValue;
    public Image uiBar;

    void Start()    
    {
        curValue = StartValue;
    }

    // Update is called once per frame
    void Update()
    {
        uiBar.fillAmount = GetPercentage();
    }

    public void Add(float value)
    {
        curValue += Mathf.Min(curValue + value, maxValue);
    }

    public void Subtract(float value)
    {
        curValue = Mathf.Max(curValue - value, 0f);
    }

    float GetPercentage()
    {
        return curValue / maxValue;
    }

}
