using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPortrait : MonoBehaviour
{
    private SpriteRenderer RendSprite;

    public GameObject Hero;
    public GameObject BattleManager;
    public GameObject HeroStats;

    public Sprite Hero1;
    public Sprite Hero2;

    public int HeroID;


    public int HeroSlotActual;
    public int HeroNumber;

    public int Defence;

    public int Attack;
    public int Damage;
    public int FinalDamage;
    public float HP;

    public float Coefficient;
    public float FinalCoefficient;
    public bool SkillSelected;
    public bool ActCompleted;
    public bool ActCompletedOFF;



    void Start()
    {
        HP = Hero.GetComponent<HeroManager>().HPmax;
        HeroNumber = Hero.GetComponent<HeroManager>().HeroNumber;
        HeroID = Hero.GetComponent<HeroManager>().HeroID;
        RendSprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (HeroID == 1)
        {
            RendSprite.sprite = Hero1;
        }
        if (HeroID == 2)
        {
            RendSprite.sprite = Hero2;
        }

        HeroSlotActual = BattleManager.GetComponent<BattleManager>().HeroSlot;
        Defence = HeroStats.GetComponent<HeroStats>().Defence;
        Attack = BattleManager.GetComponent<BattleManager>().Attack;
        Damage = BattleManager.GetComponent<BattleManager>().Damage;
        Hero.GetComponent<HeroManager>().HP = HP;
        SkillSelected = BattleManager.GetComponent<BattleManager>().SkillSelected;

        if (ActCompleted)
        {
            Debug.Log("Complete");
            ActCompleted = false;
        }   
    }

    void OnMouseDown()
    {
     
        Coefficient = Attack - Defence;
        // В будущем сделать в избытке защиты коефицент множителя 3 а не 5!
        FinalCoefficient = Coefficient / 100 * 5;
        FinalDamage = Mathf.FloorToInt(Damage + Damage * FinalCoefficient);


        if(HeroNumber < 4 && HeroSlotActual > 3 && SkillSelected)
        {
            Debug.Log("DAMAGE 2");
            HP = HP - FinalDamage;
            ActCompleted = true;
            BattleManager.GetComponent<BattleManager>().ActCompleted = ActCompleted;

            if (HeroNumber == 1)
                BattleManager.GetComponent<BattleManager>().AnimatorManager = 1;
            if (HeroNumber == 2)
                BattleManager.GetComponent<BattleManager>().AnimatorManager = 2;
            if (HeroNumber == 3)
                BattleManager.GetComponent<BattleManager>().AnimatorManager = 3;
        }        
        if (HeroNumber > 3 && HeroSlotActual < 4 && SkillSelected)
        {
            Debug.Log("DAMAGE");
            HP = HP - FinalDamage;
            ActCompleted = true;
            BattleManager.GetComponent<BattleManager>().ActCompleted = ActCompleted;

            if (HeroNumber == 4)
                BattleManager.GetComponent<BattleManager>().AnimatorManager = 4;
            if (HeroNumber == 5)
                BattleManager.GetComponent<BattleManager>().AnimatorManager = 5;
            if (HeroNumber == 6)
                BattleManager.GetComponent<BattleManager>().AnimatorManager = 6;
        }
        
    }

}
