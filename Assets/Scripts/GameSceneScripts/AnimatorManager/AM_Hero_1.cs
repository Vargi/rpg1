using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AM_Hero_1 : MonoBehaviour
{
    public GameObject MightSkill_AM;
    public GameObject BattleManager;

    public float Skill_ID;
    public int AnimatorManager;


    void Update()
    {
        AnimatorManager = BattleManager.GetComponent<BattleManager>().AnimatorManager;
        Skill_ID = BattleManager.GetComponent<BattleManager>().Skill_ID;

   

        if (AnimatorManager == 1)
        {
            if (Skill_ID == 2.1f)
            {
                Instantiate(MightSkill_AM, transform, false);
                MightSkill_AM.transform.localPosition = new Vector3(0, 0, 0);
                
            }

            if (BattleManager.GetComponent<BattleManager>().AnimatorManager > 0)
                BattleManager.GetComponent<BattleManager>().AnimatorManager = 0;

           

        }
    }
}
