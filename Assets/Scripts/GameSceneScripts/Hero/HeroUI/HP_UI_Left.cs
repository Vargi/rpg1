using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_UI_Left : MonoBehaviour
{
    public GameObject Portrait;

    private SpriteRenderer RendSprite;

    public Sprite HaveHP;
    public Sprite HaveNoHP;


    void Start()
    {
        RendSprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Portrait.GetComponent<HeroPortrait>().HP > 0)
        {
            RendSprite.sprite = HaveHP;
        }
        if (Portrait.GetComponent<HeroPortrait>().HP <= 0)
        {
            RendSprite.sprite = HaveNoHP;
        }
    }
}
