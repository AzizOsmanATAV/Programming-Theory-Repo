using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    private HungerBar hungerBar;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DestroyOutOfBounds();
        
    }

    void Move()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
    void DestroyOutOfBounds()
    {
        if(transform.position.z < -117)
        {
            Destroy(gameObject);
        }
    }

    public virtual void UpdateCurrentHunger()
    {
        playerController._currentHunger += 0.2f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UpdateCurrentHunger();
        }
    }


}
