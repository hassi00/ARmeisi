using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public float moveSpeed;
    private float distance = 0;

    float delta = 0;
    public float span;

    // Update is called once per frame
    void Update()
    {
        if (delta < span)
        {
            transform.Translate(0, 0, moveSpeed);

            this.delta += Time.deltaTime;
        }

    }
}
