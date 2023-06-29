using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public GameObject pfLaser;
    public float tempoDeDisparo = 0.3f;
    private float cooldownDuration = 0.8f;
    private float cooldownTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        if (cooldownTimer <= 0f)
        {
            Instantiate(pfLaser, transform.position + new Vector3(0, 0, 1.1f), Quaternion.identity);
            cooldownTimer = tempoDeDisparo;
        }
        else
        {
            cooldownTimer -= Time.deltaTime;
        }
    }
}
