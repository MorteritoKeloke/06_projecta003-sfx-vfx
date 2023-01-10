using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;
    private bool isOnTheGround = true;
    private Rigidbody _rigidbody;
    public bool gameOver;
    private Animator _animator;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround && !gameOver)
        {
            isOnTheGround = false;
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
           if (otherCollider.gameObject.CompareTag ("Obstacle"))
        {
            gameOver = true;
        }
            isOnTheGround = true;
    }
}
