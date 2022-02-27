using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHP_Bar : MonoBehaviour
{
    public GameObject Portrait;


    void Start()
    {
        
    }


    void Update()
    {
        if(Portrait.GetComponent<HeroPortrait>().HP <= 0)
            Destroy(gameObject);
    }
}
