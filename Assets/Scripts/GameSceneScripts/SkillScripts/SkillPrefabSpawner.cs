using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPrefabSpawner : MonoBehaviour
{
    public GameObject DaggerSkill;

    void Start()
    {
        int i = 1;
        if (i == 1)
        {

            Instantiate(DaggerSkill, transform, false);
            DaggerSkill.transform.localPosition = new Vector3(0, 0, 0);

        }
    }
}
