using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchEvent : MonoBehaviour
{
    public GameObject hotdogPanel;
    public GameObject hotdogCanvas;
    public GameObject btn;
    // public Animator animator;

    // Start is called before the first frame update
    private void Start()
    {
        hotdogPanel.transform.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if( Physics.Raycast(ray, out hit))
            {
            // ---------------------- cube changeColor code ----------------------------
                // Color newColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
                // hit.collider.GetComponent<MeshRenderer>().material.color = newColor; 
            // ---------------------- cube changeColor code ----------------------------  
                if( hit.collider.gameObject.name == "hotdog")
                {
                    btn.SetActive(true);
                    hotdogCanvas.SetActive(true);
                    hotdogPanel.transform.LeanScale(Vector2.one, 0.8f);
                }

            }
        } 
    }

}
