using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroManager: MonoBehaviour
{
    public GameObject Counter;
    //UI
    public GameObject Hero;
    public Image HPbar;
    public Slider Slider;
    public float HP;
    public float HPmax;
    public bool Alive;

    //Turns
    public bool HeroTurn;
    public bool EndHeroTurn;
    public bool HaveAction;

    //Инициатива для счетчика
    public int InitiateHero;




    public int HeroID;
    public int HeroNumber;
    public int SumHaveActions;

    void Start()
    {
        Alive = true;
        HaveAction = true;
        HeroTurn = false;

        HeroNumber = Hero.GetComponent<HeroStats>().HeroID;


        if (HeroNumber == 1)
        {
            HeroID = GameManager.HeroID_1;
        }

        if (HeroNumber == 2)
        {
            HeroID = GameManager.HeroID_2;
        }
        if (HeroNumber == 3)
        {
            HeroID = GameManager.HeroID_3;
        }

        if (HeroNumber == 4)
        {
            HeroID = GameManager.HeroID_4;
        }
        if (HeroNumber == 5)
        {
            HeroID = GameManager.HeroID_5;
        }

        if (HeroNumber == 6)
        {
            HeroID = GameManager.HeroID_6;
        }

        HPmax = Hero.GetComponent<HeroStats>().HPmax;

        HP = HPmax;
    }

    void Update()
    {


        if (!HaveAction)
            HeroTurn = false;
            SumHaveActions = 0;

        if (HaveAction)
            SumHaveActions = 1;

        if (HeroNumber == 1)
            Counter.GetComponent<TurnCounter>().HeroHaveAction1 = HaveAction;
        if (HeroNumber == 2)
            Counter.GetComponent<TurnCounter>().HeroHaveAction2 = HaveAction;
        if (HeroNumber == 3)
            Counter.GetComponent<TurnCounter>().HeroHaveAction3 = HaveAction;
        if (HeroNumber == 4)
            Counter.GetComponent<TurnCounter>().HeroHaveAction4 = HaveAction;
        if (HeroNumber == 5)
            Counter.GetComponent<TurnCounter>().HeroHaveAction5 = HaveAction;
        if (HeroNumber == 6)
            Counter.GetComponent<TurnCounter>().HeroHaveAction6 = HaveAction;


        InitiateHero = Hero.GetComponent<HeroStats>().Initiate;

        HPbar.fillAmount = HP / HPmax;
        Slider.value = HP / HPmax;


       if (HP > HPmax)
        {
            HP = HPmax;
        }

        if (HP <= 0)
        {
            Alive = false;
            HaveAction = false;
        }
       
    }
}
