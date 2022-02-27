using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillScript : MonoBehaviour
{
    [Space]
    public float Skill_ID;

    public GameObject BattleManager;

    public int HeroSlotActual;
    public int HeroSlot;
    //Статусы скилла

    public bool IsCoolDown;
    private int CoolDownCounter;
    private bool NewTurnCounter;
    public bool Selected;
    public bool ActCompleted;

    public bool SkillStarted;

    public bool CanUse;

    public bool SkillAct;
    //Keys
    public int ButtonNumber;



    //AnimatorManager
    public int AnimatorManager;


    //HeroStats
    public int Attack;
    public int CriticalChance;
    public float MultiCrit;

    public int FinalDamage;
    public int RandomNumber;
    public bool CriticalStrike;
    public float Multiplier;

 


    //Статистика скилла 

    public bool SkillPassive = false;
    public bool SkillActive = false;
    public bool CanEnemyTarget = false;
    public bool CanMyselfTarget = false;
    public int Damage;
    public int Heal;
    public float CoolDown;
    public int MaxCharges;
    public bool ChargeSystem;
    //Заряды скилла
    public int Charges;
    public bool HaveCharges;
    public bool FullCharges;




    //Спрайты скилла 

    private SpriteRenderer RendSprite;
    public Image ImageSkill;
    public Sprite SpriteSelected;
    public Sprite SpriteHold;
    public Sprite SpriteEmpty;



    //Аудио скилла

    public AudioSource HitAudio;



    void Start()
    {
        BattleManager = GameObject.Find("BattleManager");
        AnimatorManager = 0;

        Charges = MaxCharges;
        CoolDownCounter = 0;
        ImageSkill.fillAmount = 1;
        IsCoolDown = false;
        RendSprite = GetComponent<SpriteRenderer>();
        SkillStarted = false;
    }




    void Update()
    {
        //if(BattleManager.GetComponent<BattleManager>.AnimatorManager == 1)


        HeroSlotActual = BattleManager.GetComponent<BattleManager>().HeroSlot;

        NewTurnCounter = BattleManager.GetComponent<BattleManager>().NewTurn;

        if (HeroSlot == HeroSlotActual && Selected)
        {
            ActCompleted = BattleManager.GetComponent<BattleManager>().ActCompleted;
        }

        if (HeroSlot == HeroSlotActual)
        {
            if (!IsCoolDown || IsCoolDown && HaveCharges)
                CanUse = true;
            if (IsCoolDown && !ChargeSystem || IsCoolDown && !HaveCharges)
                CanUse = false;
        }
        if(HeroSlot != HeroSlotActual)
            CanUse = false;

        if (Selected && HeroSlot == HeroSlotActual)
        {
            RendSprite.sprite = SpriteSelected;
            BattleManager.GetComponent<BattleManager>().SkillSelected = true;
        }

        if (CanUse)
        {
            Attack = BattleManager.GetComponent<BattleManager>().Attack;
            CriticalChance = BattleManager.GetComponent<BattleManager>().CriticalChance;
            MultiCrit = BattleManager.GetComponent<BattleManager>().MultiCrit;
        } 

        //CHARGES и их логика
        if (ChargeSystem == true)
        {
            if (Charges >= MaxCharges)
            {
                Charges = MaxCharges;
                FullCharges = true;
            }
            if (Charges < MaxCharges)
            {
                FullCharges = false;
            }
            if (Charges <= 0)
            {
                Charges = 0;
                HaveCharges = false;
            }
            if (Charges > 0)
            {
                HaveCharges = true;
            }
            if (FullCharges == true)
            {
                IsCoolDown = false;
            }
            if (!FullCharges)
            {
                IsCoolDown = true;
            }
        }
        if(ChargeSystem == false)
        {
            HaveCharges = false;
        }

        //Отображение откатов
        if (ImageSkill.fillAmount >= 1)
        {
            ImageSkill.fillAmount = 1;
        }

        if(ChargeSystem == false && ImageSkill.fillAmount == 1)
        {
            IsCoolDown = false;
        }

        //Отображение откатов при КД и НЕ КД
        if (IsCoolDown == true && !HaveCharges)
        {
                ImageSkill.fillAmount = 1 / CoolDown * CoolDownCounter;
        }

        if(IsCoolDown == false)
        {
            ImageSkill.fillAmount = 1;
            CoolDownCounter = 0;
        }


        if (NewTurnCounter == true)
        {
            CoolDownCounter += 1;

            print("otkat");

            if (ChargeSystem == false)
            {
                if (CoolDownCounter == CoolDown)
                {
                    ImageSkill.fillAmount += 1 / CoolDown;
                    CoolDownCounter = 0;
                }
            }

            if (ChargeSystem == true)
            {

                if (CoolDownCounter == CoolDown)
                {
                    ImageSkill.fillAmount += 1 / CoolDown;
                    CoolDownCounter = 0;
                    Charges += 1;
                    Debug.Log("+1");
                }
  
            }
        }


        // Действия при юзания скила
        if (ActCompleted && HeroSlot == HeroSlotActual && Selected )
        {

            Debug.Log("CD");
            if (IsCoolDown == false)
            {
                IsCoolDown = true;

                HitAudio.Play();

                ImageSkill.fillAmount = 0;

                BattleManager.GetComponent<BattleManager>().ActCompleted = false;

                if (HaveCharges == true)
                {
                    Charges -= 1;
                    Debug.Log("-1");
                    SkillStarted = true;
                }
            }


            //Откаты при юзания скила
            if (IsCoolDown == true)
            {
                
                HitAudio.Play();
                
                if (HaveCharges == true)
                {
                    ImageSkill.fillAmount = 1;
                    CanUse = true;
                    Debug.Log("!!!!!!!!!!!");
                }
                   
                if (HaveCharges == true && FullCharges == false)
                {
                    Debug.Log("&&&&&&&&&&&&");
                    Charges -= 1;
                    SkillStarted = true; 

                    if(Charges == 0)
                    {
                        CanUse = false;
                    }
                }

                if (HaveCharges == false)
                {
                    ImageSkill.fillAmount = 1 / CoolDown * CoolDownCounter;
                    BattleManager.GetComponent<BattleManager>().ActCompleted = false;
                    CanUse = false;
                }

              
                BattleManager.GetComponent<BattleManager>().SkillSelected = false;
                BattleManager.GetComponent<BattleManager>().ActCompleted = false;
            }
        }

        if (!CanUse)
        {
            RendSprite.sprite = SpriteEmpty;
            Selected = false;
        }

        //Проверка на новый ход
        if (NewTurnCounter == true)
        {
            SkillStarted = false;
        }

        //Нажатие на скилл

        if (SkillActive == true && CanUse && HeroSlot == HeroSlotActual)
        {
            if(Input.GetButtonDown("ButtonSkill1") && ButtonNumber == 1)
                if (IsCoolDown == false || IsCoolDown == true && HaveCharges == true)
                {
                    OnMouseDown();
                }
            if (Input.GetButtonDown("ButtonSkill2") && ButtonNumber == 2)
                if (IsCoolDown == false || IsCoolDown == true && HaveCharges == true)
                {
                    OnMouseDown();
                }
        }

        if (ActCompleted)
        {
            Selected = false;
            ActCompleted = false;
            RendSprite.sprite = SpriteEmpty;
        }

        //Дополнительные
        if(SkillActive == false)
        {
            CanEnemyTarget = false;
            CanMyselfTarget = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "HeroSlot1.1")
        {
            HeroSlot = 1;
            ButtonNumber = 1;
        }
        if (collider.gameObject.tag == "HeroSlot1.2")
        {
            HeroSlot = 1;
            ButtonNumber = 2;
        }

        if (collider.gameObject.tag == "HeroSlot2.1")
        {
            HeroSlot = 2;
            ButtonNumber = 1;
        }
        if (collider.gameObject.tag == "HeroSlot3.1")
        {
            HeroSlot = 3;
            ButtonNumber = 1;
        }
        if (collider.gameObject.tag == "HeroSlot4.1")
        {
            HeroSlot = 4;
            ButtonNumber = 1;
        }
        if (collider.gameObject.tag == "HeroSlot5.1")
        {
            HeroSlot = 5;
            ButtonNumber = 1;
        }
        if (collider.gameObject.tag == "HeroSlot6.1")
        {
            HeroSlot = 6;
            ButtonNumber = 1;
        }
    }

    public void OnMouseOver()
    {
        if (CanUse)
            RendSprite.sprite = SpriteSelected;
    }

    public void OnMouseExit()
    {
        if (CanUse)
            RendSprite.sprite = SpriteEmpty;
    }

    void OnMouseDrag()
    {
        if (CanUse)
            RendSprite.sprite = SpriteSelected;
    }

    void OnMouseDown()
    {
        if (!Selected)
        {
            RandomNumber = Random.Range(1, 100);
            BattleManager.GetComponent<BattleManager>().Skill_ID = Skill_ID;
        }



        if (CriticalChance >= RandomNumber)
        {
            CriticalStrike = true;
            BattleManager.GetComponent<BattleManager>().CriticalStrike = true;

        }
        else if (CriticalChance < RandomNumber)
        {
            CriticalStrike = false;
            BattleManager.GetComponent<BattleManager>().CriticalStrike = false;
        }

        Multiplier = MultiCrit / 100;

        if (!CriticalStrike)
            FinalDamage = Damage;
        else if (CriticalStrike)
            FinalDamage = Mathf.FloorToInt(Damage + Damage * Multiplier);

        BattleManager.GetComponent<BattleManager>().Damage = FinalDamage;

        if (Selected && !SkillAct)
        {
            Selected = false;
            SkillAct = true;
            RendSprite.sprite = SpriteEmpty;
            BattleManager.GetComponent<BattleManager>().SkillSelected = false;
        }

        if (SkillActive == true && CanUse && !Selected && !SkillAct)
        {                 
            if (IsCoolDown == false)
            {
                Selected = true;
            }

            if (IsCoolDown == true && HaveCharges == true)
            {
                Selected = true;
            }
        }

        SkillAct = false;

    }
}
