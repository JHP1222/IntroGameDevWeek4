using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    public int counter = 3; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        Debug.Log(gameObject.name + counter);
        
    }
}