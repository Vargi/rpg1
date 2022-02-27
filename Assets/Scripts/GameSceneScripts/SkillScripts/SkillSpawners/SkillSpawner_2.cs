using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSpawner_2 : MonoBehaviour
{
    public GameObject Hero;
    public GameObject DoubleStrike;

    public int HeroID;

    void Start()
    {
        HeroID = Hero.GetComponent<HeroManager>().HeroID;
        if (HeroID == 1)
        {
            Instantiate(DoubleStrike, transform, false);
            DoubleStrike.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}