using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController playerController;
    private Rigidbody2D rb;

    [SerializeField] private float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        playerController = new PlayerController();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue inputValue)
    {
        rb.velocity = inputValue.Get<Vector2>() * moveSpeed;
    }
}
