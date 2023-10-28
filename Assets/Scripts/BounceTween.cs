using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BounceTween : MonoBehaviour
{
    [SerializeField] private float movement;
    [SerializeField] private LeanTweenType easeType;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float duration;
    [SerializeField] private float delay;
    public UnityEvent onCompleteCallback;

     void Start()
    {
        if(easeType == LeanTweenType.animationCurve)
        {
            LeanTween.moveY(gameObject, movement, duration).setDelay(delay).setLoopPingPong().setEase(curve);
        }
        else
        {
            LeanTween.moveY(gameObject, movement, duration).setDelay(delay).setLoopPingPong().setEase(easeType);

        }
    }


   

    public void OnComplete()
    {
        if (onCompleteCallback != null)
        {

            onCompleteCallback.Invoke();

        }
    }
    /*public void OnMovePingPong()
    {
        LeanTween.moveY(gameObject, movement[0], movement[1]).setLoopPingPong();
    }*/

}
