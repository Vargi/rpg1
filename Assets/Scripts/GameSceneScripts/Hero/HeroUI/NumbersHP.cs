using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumbersHP : MonoBehaviour
{
    public TextMeshProUGUI Numbers;
    public GameObject Hero;
    public float HP;
    public float HPmax;

    void Update()
    {
        HPmax = Hero.GetComponent<HeroManager>().HPmax;
        HP = Hero.GetComponent<HeroManager>().HP;

        Numbers.GetComponent<TextMeshProUGUI>().text = HP.ToString() + "/" + HPmax.ToString();
    }
}
