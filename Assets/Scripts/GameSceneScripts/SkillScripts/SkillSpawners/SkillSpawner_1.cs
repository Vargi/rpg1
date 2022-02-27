using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSpawner_1 : MonoBehaviour
{
    public GameObject Hero;
    public GameObject DaggerSkill;
    public GameObject MightSkill;

    public int HeroID;

    void Start()
    {
        HeroID = Hero.GetComponent<HeroManager>().HeroID;
        if (HeroID == 1)
        {
            Instantiate(DaggerSkill, transform, false);
            DaggerSkill.transform.localPosition = new Vector3(0, 0, 0);
        }

        if (HeroID == 2)
        {
            Instantiate(MightSkill, transform, false);
            MightSkill.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
