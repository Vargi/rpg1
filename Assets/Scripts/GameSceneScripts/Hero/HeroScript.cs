using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroScript : MonoBehaviour
{
    public Image HeroHPbar;
    public float HeroHP;
    public float HeroHPmax;

    void Start()
    {
        HeroHPmax = 200;
        HeroHP = HeroHPmax;
    }

    void Update()
    {
        HeroHPbar.fillAmount = HeroHP / HeroHPmax;

        if (HeroHP > HeroHPmax)
        {
            HeroHP = HeroHPmax;
        }

        if (HeroHP <= 0)
        {
            Debug.Log("Ti SDOH");

        }
    }
}
