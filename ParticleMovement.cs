using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *  Describes the movement of a proton across the screen:
 *  Direction + trail behind proton
 */
public class ParticleMovement : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    private float speed;

    void Start()
    {
        int side = Random.Range(0, 2); //0 is left, 1 is right
        float pos = Random.Range(-4f, 4f); //How high up or down is it
        speed = Random.Range(maxSpeed / 10, maxSpeed);

        if (side == 0)
        {
            transform.position = new Vector3(-12f, pos, 0);
        }
        else
        {
            transform.position = new Vector3(12f, pos, 0);
            speed = speed * -1;
        }
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
        if (speed < 0 && transform.position.x <= -12f)
        {
            Destroy(this.gameObject);
        }else if (speed > 0 && transform.position.x >= 12f)
        {
            Destroy(this.gameObject);
        }
    }
}
