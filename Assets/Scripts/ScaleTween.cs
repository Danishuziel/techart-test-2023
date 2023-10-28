using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScaleTween : MonoBehaviour
{

    [SerializeField] private LeanTweenType inType;
    [SerializeField] private LeanTweenType outType;
    [SerializeField] private float delay;
    public UnityEvent onCompleteCallback;

    public void OnEnable()
    {
        transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(gameObject, new Vector3(1, 1, 1), 0.25f).setDelay(delay).setOnComplete(OnComplete).setEase(inType);
    }

    public void OnComplete()
    {
        if(onCompleteCallback != null)
        {

            onCompleteCallback.Invoke();

        }
    }
    public void OnClose()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f).setEase(outType);//.setOnComplete(DestroyMe);
    }

    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
