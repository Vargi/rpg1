using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargesSkill : MonoBehaviour
{
    public GameObject SkillObject;

    public Sprite Charges2_AllReady;
    public Sprite Charges2_Ready1;
    public Sprite Charges2_AllCD;

    public Sprite Charges3_AllReady;
    public Sprite Charges3_Ready2;
    public Sprite Charges3_Ready1;
    public Sprite Charges3_AllCD;

    private SpriteRenderer RendSprite;




    public int MaxCharges;
    public int Charges;

    void Start()
    {
        RendSprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        MaxCharges = SkillObject.GetComponent<SkillScript>().MaxCharges;
        Charges = SkillObject.GetComponent<SkillScript>().Charges;


        if (MaxCharges == 3)
        {
            if (Charges == 3)
            {
                RendSprite.sprite = Charges3_AllReady;
            }
            if (Charges == 2)
            {
                RendSprite.sprite = Charges3_Ready2;
            }
            if (Charges == 1)
            {
                RendSprite.sprite = Charges3_Ready1;
            }
            if (Charges == 0)
            {
                RendSprite.sprite = Charges3_AllCD;
            }
        }
        if (MaxCharges == 2)
        {
            if (Charges == 2)
            {
                RendSprite.sprite = Charges2_AllReady;
            }
            if (Charges == 1)
            {
                RendSprite.sprite = Charges2_Ready1;
            }
            if (Charges == 0)
            {
                RendSprite.sprite = Charges2_AllCD;
            }
        }
    }
}
