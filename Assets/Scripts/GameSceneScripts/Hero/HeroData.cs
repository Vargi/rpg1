using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroData : MonoBehaviour
{
    private SpriteRenderer rend;

    public int GM;

    public Sprite Empty;
    public Sprite Varg;

    public void Start()
    {
        rend = GetComponent<SpriteRenderer>();

        GM = 1;
    }


    public void Update()
    {
            if (GM == 0)
            {
                rend.sprite = Empty;
            }

            if (GM == 1)
            {
                rend.sprite = Varg;
            }
    }
}
