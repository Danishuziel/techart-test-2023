using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScaleDownTween : MonoBehaviour
{
    [SerializeField] private LeanTweenType outType;
    [SerializeField] private float delay;
    public UnityEvent onCompleteCallback;


    

    public void OnClose()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f).setDelay(delay).setEase(outType);
    }

    
}
