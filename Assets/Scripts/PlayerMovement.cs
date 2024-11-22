using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement 
{
    [SerializeField]
    private float playerSpeed = 2.0f;

    //variablen voor het stemmen op je gameMode
    [SerializeField]
    private bool m_canVote = false;

    [SerializeField]
    private int m_voteCount = 1;

    [CanBeNull]
    [SerializeField]
    private GameObject m_portals, m_bomb, m_bombSpawnPoint;

    public int m_health = 1;
    private Vector2 movementInput = Vector2.zero;

/*    //Rigidbody
    Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }*/

    #region Input
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            movementInput = context.ReadValue<Vector2>();
        }
    }

    #endregion

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(movementInput.x, 0, movementInput.y).normalized * playerSpeed;
/*        Vector3 newPosition = rb.position + move * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);*/


    }
}
