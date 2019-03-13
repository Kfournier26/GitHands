using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour {
    public GameObject leftHand, rightHand;
    public List<string> animations = new List<string>();

    void AnimateHand(GameObject hand, string animationName)
    {
        animations.Add(animationName);

        Animator animator = hand.GetComponent<Animator>();

        animator.speed = 0.1f;

        animator.Play(animationName);
    }
    public void AnimatePointer()
    {
        AnimateHand(rightHand, "PointerAni");
    }

    public void AnimateThumb()
    {
        AnimateHand(rightHand, "ThumbAni");
    }

    public void AnimateThree()
    {
        AnimateHand(rightHand, "AnimateThree");
    }

    public void AnimateNone()
    {
        Animator animator = rightHand.GetComponent<Animator>();

        animator.speed = -1;
        animator.StartPlayback();
    }
}
