using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EaseInPositionTween : MonoBehaviour
{
    [SerializeField] private float movementX,movementY;
    [SerializeField] private float delay;
    void Start()
    {
        LeanTween.moveLocal(gameObject, new Vector3(movementX, movementY,2f), .7f).setDelay(delay).setEase(LeanTweenType.easeInOutCubic);
    }
}
