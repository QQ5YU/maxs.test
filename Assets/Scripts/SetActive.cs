using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject gameObject;
    public void Active() 
    {
        if ( !gameObject.activeInHierarchy)
        {
            gameObject.SetActive(true);
        }
        else 
        {
            gameObject.SetActive(false);
        }
        
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
