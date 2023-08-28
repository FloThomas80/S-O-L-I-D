using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _jumpForce = 5f;
    private bool _isJumping = false;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Déplacements
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * _moveSpeed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        // Saut
        if (Input.GetButtonDown("Jump") && !_isJumping)
        {
            rb.AddForce(new Vector3(0f, _jumpForce, 0f), ForceMode.Impulse);
            _isJumping = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Réinitialise le saut lorsque le joueur touche le sol
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isJumping = false;
        }
    }
    public void IncreaseSpeed(float speed)
    {
        if(_moveSpeed + speed > 1f)
        _moveSpeed += speed;
        else
        _moveSpeed = 1f;
    }
}
