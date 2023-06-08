using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour, IJumpable
{
    [SerializeField] private Rigidbody m_rigidbody;
    [SerializeField] private float m_jumpForce = 0.1f;
    [SerializeField] private Inputs _inputs;
    public void Jump()
    {
        if (_inputs.jump)
        {
            m_rigidbody.AddForce(Vector3.up * m_jumpForce, ForceMode.Impulse);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Jump();
    }
}
