using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] float speed = 5;
    [SerializeField] float boundValue = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBoundaries();
    }

    void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }

    void CheckBoundaries()
    {
        if(transform.position.x < -boundValue)
        {
            transform.position = new Vector3(-boundValue, transform.position.y, transform.position.z);
        }
        if(transform.position.x > boundValue)
        {
            transform.position = new Vector3(boundValue, transform.position.y, transform.position.z);
        }

    }
}
