using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRoffice : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 60.0f;
    public float speed = 3.0f;
    public bool moveForward;

    private CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
    }
}
