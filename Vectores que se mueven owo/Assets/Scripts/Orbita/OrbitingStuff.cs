using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingStuff : MonoBehaviour
{
    [SerializeField]
    private float accelerationMag;
    [SerializeField]
    private Vector3 velocidadOrbita;
    [SerializeField]
    private Transform target;
    [SerializeField, Range(0f, 15f)]
    private float nyoom;
  
    private void FixedUpdate()
    {
        MoverOrbita();
    }
    public void MoverOrbita()
    {
        Vector3 accelerationOrbita = (target.position - transform.position).normalized * accelerationMag;
        velocidadOrbita += accelerationOrbita * Time.deltaTime;
        transform.position += velocidadOrbita * Time.deltaTime;
    }
}
