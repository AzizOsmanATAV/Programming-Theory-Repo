using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] float speed = 5;
    [SerializeField] float boundValue = 5;
    [SerializeField] HungerBar hungerBar;
    public float hungerDecreaseRate = 0.07f;
    

    public float minHunger = 1;
    public float _currentHunger;
    public float currentHunger
        
    {
        get { return _currentHunger; }
        set
        {
            if (_currentHunger > 1)
            {
                //currentHunger cant be more than 1
                _currentHunger = 1;
            }
            else
            {
                
            }
        }

        //Encapsulation
    }



    // Start is called before the first frame update
    void Start()
    {
        _currentHunger = 1;
        transform.position = new Vector3(0, 0, -111);
        hungerBar.UpdateHungerBar(minHunger, currentHunger);
    }

    // Update is called once per frame
    void Update()
    {
        
        Move();
        CheckBoundaries();
        
        hungerBar.UpdateHungerBar(minHunger, _currentHunger);
    }

    void Move()
    {
        //Abstraction
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        DecreaseHunger();
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

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Ground"))
        {
            Destroy(other.gameObject);
        }

    }

    void DecreaseHunger()
    {
        _currentHunger -= hungerDecreaseRate * Time.deltaTime;
    }
   
}
