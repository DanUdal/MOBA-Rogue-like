using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineHandler : MonoBehaviour
{
    public static CoroutineHandler instance;
    // Start is called before the first frame update
    void Start()
    {
        CoroutineHandler.instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
