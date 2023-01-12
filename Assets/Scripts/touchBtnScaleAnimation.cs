using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBtnScaleAnimation : MonoBehaviour
{
    public GameObject btn;

    public void click()
    {
        LeanTween.cancel(btn);
        transform.localScale = Vector3.one;
        LeanTween.scale(btn,new Vector3(1.1f, 1.08f, 1.08f), 2).setEasePunch();
    }

}
