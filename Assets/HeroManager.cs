using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            animator.SetBool("isAttacking", true);
        }
    }

    void OnCompleteAnimation() //攻撃のアニメーションが終わったら関数を作ってあげて、攻撃アニメーションを終える
    {
        animator.SetBool("isAttacking", false);
    }
}
