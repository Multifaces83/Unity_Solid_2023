using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMovable
{
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float m_speed = 1f;
    [SerializeField] private Inputs _inputs;
    public void Move()
    {
        Vector3 move = new Vector3(_inputs.move.x, 0, _inputs.move.y);
        m_rigidbody.MovePosition(transform.position + move * m_speed);
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
}
