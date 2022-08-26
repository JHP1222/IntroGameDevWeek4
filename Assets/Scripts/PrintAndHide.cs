using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int counter;
    public Renderer rend;
    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        counter = 3;
        rand = Random.Range(200, 251);
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        Debug.Log(gameObject.name+":"+counter);

        
        if (gameObject.tag =="Red" && counter == 100)
        {
            gameObject.SetActive(false);
        }
        
        if (gameObject.tag == "Blue" && counter == rand)
        {
            rend.enabled = false;
        }
        
    }
}
