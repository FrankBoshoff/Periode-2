using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HeadMovement))]
public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSen = 3f;
    private HeadMovement head;

    private void Start()
    {
        head = GetComponent<HeadMovement>();
    }

    private void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 movH = transform.right * xMov;
        Vector3 movV = transform.forward * zMov;

        Vector3 _velocity = (movH + movV).normalized * speed;

        head.Move(_velocity);

        float yRot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, yRot, 0f) * lookSen;

        head.Rotate(_rotation);

        float xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 _cameraRot = new Vector3(xRot, 0f, 0f) * lookSen;

        head.RotateCamera(_cameraRot);

    }

}
