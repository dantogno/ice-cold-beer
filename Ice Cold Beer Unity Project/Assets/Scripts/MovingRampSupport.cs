using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampSupport : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public string inputAxisToUse;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float input = Input.GetAxis(inputAxisToUse);
        rigidbody.velocity = Vector2.up * input * moveSpeed;
    }
}
