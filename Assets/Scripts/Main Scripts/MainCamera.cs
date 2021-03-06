using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRunner;
    [SerializeField] private bool followRotation;
    [SerializeField] private bool followPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followPosition)
        {
            transform.position = new Vector3(myRunner.position.x, myRunner.position.y, transform.position.z);
        }

        if (followRotation)
        {
            transform.rotation = myRunner.transform.rotation;
        }
    }
}
