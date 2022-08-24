using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    public int counter;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        counter = 3;
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        Debug.Log(gameObject.name+":"+counter);
        
    }
}
