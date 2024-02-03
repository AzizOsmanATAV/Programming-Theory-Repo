using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    [SerializeField] float speed = 8;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        ControlTheGround();
    }

    private void Move()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    private void ControlTheGround()
    {
        if(transform.position.z < -123)
        {
            transform.position = startPos;
        }
    }
}
