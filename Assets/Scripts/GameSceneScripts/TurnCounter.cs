using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class TurnCounter : MonoBehaviour
{
    public GameObject[] Players;
    //public bool[] HaveActions;
    //public int MaxValue;
    //public GameObject BattleManager;
    //public bool ActCompleted;
    //
    public int Rounds;

    public int TurnNumber;
    public bool NewTurnCounter;


    public GameObject Hero1;
    public GameObject Hero2;
    public GameObject Hero3;
    public GameObject Hero4;
    public GameObject Hero5;
    public GameObject Hero6;

    public int HeroInitiate1;
    public int HeroInitiate2;
    public int HeroInitiate3;
    public int HeroInitiate4;
    public int HeroInitiate5;
    public int HeroInitiate6;

    public bool HeroHaveAction1;
    public bool HeroHaveAction2;
    public bool HeroHaveAction3;
    public bool HeroHaveAction4;
    public bool HeroHaveAction5;
    public bool HeroHaveAction6;

    public bool HeroCurrentTurn1;
    public bool HeroCurrentTurn2;
    public bool HeroCurrentTurn3;
    public bool HeroCurrentTurn4;
    public bool HeroCurrentTurn5;
    public bool HeroCurrentTurn6;


    public bool HeroAlive1;
    public bool HeroAlive2;
    public bool HeroAlive3;
    public bool HeroAlive4;
    public bool HeroAlive5;
    public bool HeroAlive6;

    public int HeroMax;

    public int SumHaveActions;
    public int SumHaveActions1;
    public int SumHaveActions2;
    public int SumHaveActions3;
    public int SumHaveActions4;
    public int SumHaveActions5;
    public int SumHaveActions6;

    public int SumHeroAlive;
    public int SumHeroAlive1;
    public int SumHeroAlive2;
    public int SumHeroAlive3;
    public int SumHeroAlive4;
    public int SumHeroAlive5;
    public int SumHeroAlive6;



    public bool StartTurn;

    void Start()
    {
        Players = GameObject.FindGameObjectsWithTag("Hero");

        StartTurn = true;

        HeroAlive1 = Hero1.GetComponent<HeroManager>().Alive;
        HeroAlive2 = Hero2.GetComponent<HeroManager>().Alive;
        HeroAlive3 = Hero3.GetComponent<HeroManager>().Alive;
        HeroAlive4 = Hero4.GetComponent<HeroManager>().Alive;
        HeroAlive5 = Hero5.GetComponent<HeroManager>().Alive;
        HeroAlive6 = Hero6.GetComponent<HeroManager>().Alive;

        HeroInitiate1 = Hero1.GetComponent<HeroManager>().InitiateHero;
        HeroInitiate2 = Hero2.GetComponent<HeroManager>().InitiateHero;
        HeroInitiate3 = Hero3.GetComponent<HeroManager>().InitiateHero;
        HeroInitiate4 = Hero4.GetComponent<HeroManager>().InitiateHero;
        HeroInitiate5 = Hero5.GetComponent<HeroManager>().InitiateHero;
        HeroInitiate6 = Hero6.GetComponent<HeroManager>().InitiateHero;

        HeroHaveAction1 = Hero1.GetComponent<HeroManager>().HaveAction;
        HeroHaveAction2 = Hero2.GetComponent<HeroManager>().HaveAction;
        HeroHaveAction3 = Hero3.GetComponent<HeroManager>().HaveAction;
        HeroHaveAction4 = Hero4.GetComponent<HeroManager>().HaveAction;
        HeroHaveAction5 = Hero5.GetComponent<HeroManager>().HaveAction;
        HeroHaveAction6 = Hero6.GetComponent<HeroManager>().HaveAction;

        Rounds = 1;
        TurnNumber = 1;
    }


    void Update()
    {
        SumHaveActions1 = Hero1.GetComponent<HeroManager>().SumHaveActions;
        SumHaveActions2 = Hero2.GetComponent<HeroManager>().SumHaveActions;
        SumHaveActions3 = Hero3.GetComponent<HeroManager>().SumHaveActions;
        SumHaveActions4 = Hero4.GetComponent<HeroManager>().SumHaveActions;
        SumHaveActions5 = Hero5.GetComponent<HeroManager>().SumHaveActions;
        SumHaveActions6 = Hero6.GetComponent<HeroManager>().SumHaveActions;

        SumHaveActions = SumHaveActions1 + SumHaveActions2 + SumHaveActions3 + SumHaveActions4 + SumHaveActions5 + SumHaveActions6;

        HeroCurrentTurn1 = Hero1.GetComponent<HeroManager>().HeroTurn;
        HeroCurrentTurn2 = Hero2.GetComponent<HeroManager>().HeroTurn;
        HeroCurrentTurn3 = Hero3.GetComponent<HeroManager>().HeroTurn;
        HeroCurrentTurn4 = Hero4.GetComponent<HeroManager>().HeroTurn;
        HeroCurrentTurn5 = Hero5.GetComponent<HeroManager>().HeroTurn;
        HeroCurrentTurn6 = Hero6.GetComponent<HeroManager>().HeroTurn;

        HeroAlive1 = Hero1.GetComponent<HeroManager>().Alive;
        HeroAlive2 = Hero2.GetComponent<HeroManager>().Alive;
        HeroAlive3 = Hero3.GetComponent<HeroManager>().Alive;
        HeroAlive4 = Hero4.GetComponent<HeroManager>().Alive;
        HeroAlive5 = Hero5.GetComponent<HeroManager>().Alive;
        HeroAlive6 = Hero6.GetComponent<HeroManager>().Alive;

        HeroInitiate1 = Hero1.GetComponent<HeroManager>().InitiateHero;
        HeroInitiate2 = Hero2.GetComponent<HeroManager>().InitiateHero;
        HeroInitiate3 = Hero3.GetComponent<HeroManager>().InitiateHero;
        HeroInitiate4 = Hero4.GetComponent<HeroManager>().InitiateHero;
        HeroInitiate5 = Hero5.GetComponent<HeroManager>().InitiateHero;
        HeroInitiate6 = Hero6.GetComponent<HeroManager>().InitiateHero;

        if (HeroAlive1)
            SumHeroAlive1 = 1;
        else if(!HeroAlive1)
            SumHeroAlive1 = 0;
        if (HeroAlive2)
            SumHeroAlive2 = 1;
        else if (!HeroAlive2)
            SumHeroAlive2 = 0;
        if (HeroAlive3)
            SumHeroAlive3 = 1;
        else if (!HeroAlive3)
            SumHeroAlive3 = 0;
        if (HeroAlive4)
            SumHeroAlive4 = 1;
        else if (!HeroAlive4)
            SumHeroAlive4 = 0;
        if (HeroAlive5)
            SumHeroAlive5 = 1;
        else if (!HeroAlive5)
            SumHeroAlive5 = 0;
        if (HeroAlive6)
            SumHeroAlive6 = 1;
        else if (!HeroAlive6)
            SumHeroAlive6 = 0;

        SumHeroAlive = SumHeroAlive1 + SumHeroAlive2 + SumHeroAlive3 + SumHeroAlive4 + SumHeroAlive5 + SumHeroAlive6;

        NewTurnCounter = false;

        HeroMax = SumHeroAlive;

        

        if (SumHaveActions == 1 && StartTurn)
        {
            Debug.Log("hod!");
            for (int i = 0; i < Players.Length; i++)
            {
                if (Players[i].GetComponent<HeroManager>().HaveAction)
                {

                    Players[i].GetComponent<HeroManager>().HeroTurn = true;
                    StartTurn = false;
                }
            }
        }

        if (SumHaveActions > 1 && StartTurn)
        {
            for (int i = 0; i < Players.Length; i++)
            {
                if (Players[i].GetComponent<HeroManager>().HaveAction)
                {
                    int thisIndex = i;
                    for (int j = 1; j < Players.Length; j++)
                    {
                        if (Players[j].GetComponent<HeroManager>().HaveAction == false)
                            continue;

                        if (Players[thisIndex].GetComponent<HeroManager>().InitiateHero < Players[j].GetComponent<HeroManager>().InitiateHero)
                        {
                            Players[thisIndex].GetComponent<HeroManager>().HeroTurn = false;
                            thisIndex = j;

                        }
                        else if (Players[thisIndex].GetComponent<HeroManager>().InitiateHero == Players[j].GetComponent<HeroManager>().InitiateHero)
                        {
                            Debug.Log("Инициируем рандом");

                            if (Random.Range(0f, 10f) <= 5f)
                            {
                                Debug.Log("j");
                                Players[thisIndex].GetComponent<HeroManager>().HeroTurn = false;
                                thisIndex = j;
                            }
                            else
                            {
                                Debug.Log("thisIndex");
                                Players[j].GetComponent<HeroManager>().HeroTurn = false;
                            }
                        }
                    }
                    Players[thisIndex].GetComponent<HeroManager>().HeroTurn = true;



                    Debug.Log("Mаксимальная инициативау Героя с индексом массиве = " + thisIndex);
                    StartTurn = false;
                }
                else
                {
                    continue;
                }

                break;
            }
        }

      

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnMouseDown();
        }

       

    }

    void OnMouseDown()
    {
        Players = GameObject.FindGameObjectsWithTag("Hero");

        StartTurn = true;


        if (HeroCurrentTurn1 && SumHaveActions > 1)
            Hero1.GetComponent<HeroManager>().HaveAction = false;
        if (HeroCurrentTurn2 && SumHaveActions > 1)
            Hero2.GetComponent<HeroManager>().HaveAction = false;
        if (HeroCurrentTurn3 && SumHaveActions > 1)
            Hero3.GetComponent<HeroManager>().HaveAction = false;
        if (HeroCurrentTurn4 && SumHaveActions > 1)
            Hero4.GetComponent<HeroManager>().HaveAction = false;
        if (HeroCurrentTurn5 && SumHaveActions > 1)
            Hero5.GetComponent<HeroManager>().HaveAction = false;
        if (HeroCurrentTurn6 && SumHaveActions > 1)
            Hero6.GetComponent<HeroManager>().HaveAction = false;

        if (HeroCurrentTurn1 && SumHaveActions == 1)
            Hero1.GetComponent<HeroManager>().HeroTurn = false;
        if (HeroCurrentTurn2 && SumHaveActions == 1)
            Hero2.GetComponent<HeroManager>().HeroTurn = false;
        if (HeroCurrentTurn3 && SumHaveActions == 1)
            Hero3.GetComponent<HeroManager>().HeroTurn = false;
        if (HeroCurrentTurn4 && SumHaveActions == 1)
            Hero4.GetComponent<HeroManager>().HeroTurn = false;
        if (HeroCurrentTurn5 && SumHaveActions == 1)
            Hero5.GetComponent<HeroManager>().HeroTurn = false;
        if (HeroCurrentTurn6 && SumHaveActions == 1)
            Hero6.GetComponent<HeroManager>().HeroTurn = false;




        if (TurnNumber == HeroMax)
        {
            Debug.Log("New Turn");
            TurnNumber = 0;
            Rounds += 1;
            NewTurnCounter = true;
            Hero1.GetComponent<HeroManager>().HaveAction = true;
            Hero2.GetComponent<HeroManager>().HaveAction = true;
            Hero3.GetComponent<HeroManager>().HaveAction = true;
            Hero4.GetComponent<HeroManager>().HaveAction = true;
            Hero5.GetComponent<HeroManager>().HaveAction = true;
            Hero6.GetComponent<HeroManager>().HaveAction = true;

        }






   

   


        TurnNumber += 1;
    }
}
