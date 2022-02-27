using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStats : MonoBehaviour
{
    public int HeroID;

    public int Attack;
    public int Defence;
    public int Initiate;
    public int CriticalChance;
    public int MultiCrit;
    public float HPmax;


    void Awake()
    {
        if (HeroID == 1)
        {
            Attack = GameManager.Hero1_Attack;
            Defence = GameManager.Hero1_Defence;
            Initiate = GameManager.Hero1_Initiate;
            CriticalChance = GameManager.Hero1_CriticalChance;
            MultiCrit = GameManager.Hero1_MultiCrit;
            HPmax = GameManager.Hero1_HPmax;
        }

        if (HeroID == 2)
        {
            Attack = GameManager.Hero2_Attack;
            Defence = GameManager.Hero2_Defence;
            Initiate = GameManager.Hero2_Initiate;
            CriticalChance = GameManager.Hero2_CriticalChance;
            MultiCrit = GameManager.Hero2_MultiCrit;
            HPmax = GameManager.Hero2_HPmax;
        }
        if (HeroID == 3)
        {
            Attack = GameManager.Hero3_Attack;
            Defence = GameManager.Hero3_Defence;
            Initiate = GameManager.Hero3_Initiate;
            CriticalChance = GameManager.Hero3_CriticalChance;
            MultiCrit = GameManager.Hero3_MultiCrit;
            HPmax = GameManager.Hero3_HPmax;
        }

        if (HeroID == 4)
        {
            Attack = GameManager.Hero4_Attack;
            Defence = GameManager.Hero4_Defence;
            Initiate = GameManager.Hero4_Initiate;
            CriticalChance = GameManager.Hero4_CriticalChance;
            MultiCrit = GameManager.Hero4_MultiCrit;
            HPmax = GameManager.Hero4_HPmax;
        }
        if (HeroID == 5)
        {
            Attack = GameManager.Hero5_Attack;
            Defence = GameManager.Hero5_Defence;
            Initiate = GameManager.Hero5_Initiate;
            CriticalChance = GameManager.Hero5_CriticalChance;
            MultiCrit = GameManager.Hero5_MultiCrit;
            HPmax = GameManager.Hero5_HPmax;
        }

        if (HeroID == 6)
        {
            Attack = GameManager.Hero6_Attack;
            Defence = GameManager.Hero6_Defence;
            Initiate = GameManager.Hero6_Initiate;
            CriticalChance = GameManager.Hero6_CriticalChance;
            MultiCrit = GameManager.Hero6_MultiCrit;
            HPmax = GameManager.Hero6_HPmax;
        }
    }
}
