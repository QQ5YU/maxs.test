using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bompUp : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    private void Start()
    {
        gameObject.transform.localScale = Vector2.zero;
    }

    public void Open()
    {
        gameObject.transform.LeanScale(Vector2.one, 0.5f);
    }

    public void slowOpen()
    {
        gameObject.transform.LeanScale(Vector2.one, 1.2f);
    }

    // Update is called once per frame
    public void Close()
    {
        gameObject.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
    }
}
