using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lfoPos : MonoBehaviour
{
    public Transform oscObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float lfo = oscObj.position.x;
        gameObject.transform.position = new Vector3(5, lfo, 0);
    }
}
