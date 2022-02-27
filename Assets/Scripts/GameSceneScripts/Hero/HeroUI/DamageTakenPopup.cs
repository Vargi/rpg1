using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageTakenPopup : MonoBehaviour
{
    public GameObject Hero;
    public float FinalDamage;

    Animator animator;
    public TextMeshProUGUI TMPro;

    public GameObject AnimatorDMGtaken;


    void Start()
    {
        animator = AnimatorDMGtaken.GetComponent<Animator>();
    }

    void Update()
    {
        FinalDamage = Hero.GetComponent<HeroPortrait>().FinalDamage;

        if (Hero.GetComponent<HeroPortrait>().ActCompleted)
        {
            TMPro.GetComponent<TextMeshProUGUI>().text = FinalDamage.ToString();

            animator.SetTrigger("DamageTaken");
        }
    }
}
