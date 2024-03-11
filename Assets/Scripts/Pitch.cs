using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitch : MonoBehaviour
{
    public Transform oscObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pitch = oscObj.position.x;
        gameObject.transform.position = new Vector3(-5, pitch*3, 0);
        gameObject.transform.localScale = new Vector3(1+pitch, 1+pitch, 1+pitch);
    }
}
