using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public GameObject Counter;

    public GameObject HeroStats1;
    public GameObject HeroStats2;
    public GameObject HeroStats3;
    public GameObject HeroStats4;
    public GameObject HeroStats5;
    public GameObject HeroStats6;

    public bool NewTurn;
    public bool HeroTurn1;
    public bool HeroTurn2;
    public bool HeroTurn3;
    public bool HeroTurn4;
    public bool HeroTurn5;
    public bool HeroTurn6;

    public int Initiate;
    public int Attack;
    public int Defence;
    public float HP;
    public int CriticalChance;
    public int MultiCrit;
    public int HeroSlot;
    public bool SkillSelected;

    public int Damage;
    public bool CriticalStrike;
    public bool ActCompleted;
    public bool ActCompletedOFF;

    public int AnimatorManager;
    public float Skill_ID;

    void Start()
    {
        
    }

    void Update()
    {
        NewTurn = Counter.GetComponent<TurnCounter>().NewTurnCounter;
        HeroTurn1 = Counter.GetComponent<TurnCounter>().HeroCurrentTurn1;
        HeroTurn2 = Counter.GetComponent<TurnCounter>().HeroCurrentTurn2;
        HeroTurn3 = Counter.GetComponent<TurnCounter>().HeroCurrentTurn3;
        HeroTurn4 = Counter.GetComponent<TurnCounter>().HeroCurrentTurn4;
        HeroTurn5 = Counter.GetComponent<TurnCounter>().HeroCurrentTurn5;
        HeroTurn6 = Counter.GetComponent<TurnCounter>().HeroCurrentTurn6;

        if (HeroTurn1)
        {
            Initiate = HeroStats1.GetComponent<HeroStats>().Initiate;
            Attack = HeroStats1.GetComponent<HeroStats>().Attack;
            Defence = HeroStats1.GetComponent<HeroStats>().Defence;
            HP = HeroStats1.GetComponent<HeroStats>().HPmax;
            CriticalChance = HeroStats1.GetComponent<HeroStats>().CriticalChance;
            MultiCrit = HeroStats1.GetComponent<HeroStats>().MultiCrit;
            HeroSlot = HeroStats1.GetComponent<HeroStats>().HeroID;
        }

        if (HeroTurn2)
        {
            Initiate = HeroStats2.GetComponent<HeroStats>().Initiate;
            Attack = HeroStats2.GetComponent<HeroStats>().Attack;
            Defence = HeroStats2.GetComponent<HeroStats>().Defence;
            HP = HeroStats2.GetComponent<HeroStats>().HPmax;
            CriticalChance = HeroStats2.GetComponent<HeroStats>().CriticalChance;
            MultiCrit = HeroStats2.GetComponent<HeroStats>().MultiCrit;
            HeroSlot = HeroStats2.GetComponent<HeroStats>().HeroID;
        }

        if (HeroTurn3)
        {
            Initiate = HeroStats3.GetComponent<HeroStats>().Initiate;
            Attack = HeroStats3.GetComponent<HeroStats>().Attack;
            Defence = HeroStats3.GetComponent<HeroStats>().Defence;
            HP = HeroStats3.GetComponent<HeroStats>().HPmax;
            CriticalChance = HeroStats3.GetComponent<HeroStats>().CriticalChance;
            MultiCrit = HeroStats3.GetComponent<HeroStats>().MultiCrit;
            HeroSlot = HeroStats3.GetComponent<HeroStats>().HeroID;
        }

        if (HeroTurn4)
        {
            Initiate = HeroStats4.GetComponent<HeroStats>().Initiate;
            Attack = HeroStats4.GetComponent<HeroStats>().Attack;
            Defence = HeroStats4.GetComponent<HeroStats>().Defence;
            HP = HeroStats4.GetComponent<HeroStats>().HPmax;
            CriticalChance = HeroStats4.GetComponent<HeroStats>().CriticalChance;
            MultiCrit = HeroStats4.GetComponent<HeroStats>().MultiCrit;
            HeroSlot = HeroStats4.GetComponent<HeroStats>().HeroID;
        }

        if (HeroTurn5)
        {
            Initiate = HeroStats5.GetComponent<HeroStats>().Initiate;
            Attack = HeroStats5.GetComponent<HeroStats>().Attack;
            Defence = HeroStats5.GetComponent<HeroStats>().Defence;
            HP = HeroStats5.GetComponent<HeroStats>().HPmax;
            CriticalChance = HeroStats5.GetComponent<HeroStats>().CriticalChance;
            MultiCrit = HeroStats5.GetComponent<HeroStats>().MultiCrit;
            HeroSlot = HeroStats5.GetComponent<HeroStats>().HeroID;
        }

        if (HeroTurn6)
        {
            Initiate = HeroStats6.GetComponent<HeroStats>().Initiate;
            Attack = HeroStats6.GetComponent<HeroStats>().Attack;
            Defence = HeroStats6.GetComponent<HeroStats>().Defence;
            HP = HeroStats6.GetComponent<HeroStats>().HPmax;
            CriticalChance = HeroStats6.GetComponent<HeroStats>().CriticalChance;
            MultiCrit = HeroStats6.GetComponent<HeroStats>().MultiCrit;
            HeroSlot = HeroStats6.GetComponent<HeroStats>().HeroID;
        }

        if (ActCompleted)
        {
            Debug.Log("BMcompleted");
        }
    }
}
