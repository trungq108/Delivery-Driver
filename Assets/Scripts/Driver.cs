using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed ;
    [SerializeField] float moveSpeed ;
    [SerializeField] float slowSpeed ;
    [SerializeField] float boostSpeed ;
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward * -horizontal);
        transform.Translate(Vector3.up * vertical);
    }
    private void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.tag =="Boost")
        {
            moveSpeed += boostSpeed;
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (moveSpeed > 10)
        {
        moveSpeed = slowSpeed;
        }
    }
}
