using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public int Speed;
    [SerializeField] public int RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 offset = new Vector3(h, 0, v) *Speed* Time.deltaTime;
        transform.Translate(offset);


        float yRotate = Input.GetAxis("Mouse X");

        transform.Rotate(0, yRotate * RotationSpeed +Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(offset * 3);
        }    








    }

}
