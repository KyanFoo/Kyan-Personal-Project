using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rgb;

    private void Start()
    {
        rgb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Vector3 pos = rgb.position;
        rgb.position -= transform.forward * Time.deltaTime;
        rgb.MovePosition(pos);
    }
}
