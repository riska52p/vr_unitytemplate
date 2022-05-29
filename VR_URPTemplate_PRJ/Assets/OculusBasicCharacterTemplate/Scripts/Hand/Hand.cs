using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    Animator handAnimator;

    private void Start()
    {
        handAnimator = GetComponent<Animator>();
    }

    internal void SetGrip(float gripValue)
    {
        handAnimator.SetFloat("Grip", gripValue);
    }

    internal void SetTrigger(float triggerValue)
    {
        handAnimator.SetFloat("Trigger", triggerValue);
    }
}
