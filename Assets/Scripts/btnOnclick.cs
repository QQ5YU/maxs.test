using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnOnclick : MonoBehaviour
{
    public GameObject hotdogPanel;
    public GameObject hotdogCanvas;
    public GameObject buyItem;
    // public Animator animator;

    void Start()
    {
        hotdogPanel.transform.localScale = Vector2.zero;
    }

    public void onClick() {
        buyItem.SetActive(true);
        hotdogPanel.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
    }

    public void close() {
        hotdogPanel.transform.LeanScale(Vector2.zero, 1f).setEaseInBack();
    }
}
