using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 target = new Vector3(4.03f, 0, 0.04f);
    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target, 1f);

        //Vector3 velo = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        //transform.position = Vector3.Lerp(transform.position, target, 1f);

        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
