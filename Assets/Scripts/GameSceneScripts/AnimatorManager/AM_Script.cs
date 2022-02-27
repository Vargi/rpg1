using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AM_Script : MonoBehaviour
{
    Animator animator;
    public GameObject Animation;

    public int Time;

    void Start()
    {
        animator = Animation.GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetTrigger("Hit");
        StartCoroutine(Delete());
    }

    IEnumerator Delete()
    {
        yield return new WaitForSeconds(Time);
        Destroy(gameObject);

    }

}
