using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    //Position should be the same as the car's position
    [SerializeField] GameObject car;

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position + new Vector3(0, 0, -10);
    }
}
