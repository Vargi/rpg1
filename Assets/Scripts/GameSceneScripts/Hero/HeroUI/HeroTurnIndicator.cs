using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroTurnIndicator : MonoBehaviour
{
    public GameObject Counter;
    public GameObject Hero;

    public bool Turn;
    private SpriteRenderer RendSprite;
    public Sprite On;
    public Sprite Off;


    void Start()
    {
        RendSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Turn = Hero.GetComponent<HeroManager>().HeroTurn;

        if(Turn)
            RendSprite.sprite = On;
        if(!Turn)
            RendSprite.sprite = Off;
    }
}
