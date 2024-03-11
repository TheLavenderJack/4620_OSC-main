using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    public Transform oscObj;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float adsr = oscObj.position.x;
        gameObject.transform.position = new Vector3(0, adsr, 0);
    }
}
