using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStuff : MonoBehaviour
{
    [SerializeField]
    private Vector3 acceleration;
    private Color colorAcc = new Color(1, 1, 0);
    [SerializeField]
    private Vector3 velocidad;
    private Color colorVel = new Color(1,1,1);
    [SerializeField]
    private Vector3 posicion;
    private Color colorPos = new Color(1,0,1);
    [SerializeField]
    private float rebotar;
    private void Start()
    {
        posicion = transform.position;
    }
    void Update()
    {
        if(posicion.x >= 4.5 || posicion.x <= -4.5)
        {
            velocidad.x = velocidad.x * -rebotar;
            if(posicion.x <= -4.5)
                posicion.x = -4.5f;
            if (posicion.x >= 4.5)
                posicion.x = 4.5f;
        }
        if (posicion.y >= 4.5 || posicion.y <= -4.5)
        {
            velocidad.y = velocidad.y * -rebotar;
            if (posicion.y <= -4.5)
                posicion.y = -4.5f;
            if (posicion.y >= 5)
                posicion.y = 4.5f;
        }
        if (velocidad.y < 0.001f && posicion.y <= -4.5)
            acceleration.y = 0;
        Mover();
        //dibujación
        Debug.DrawLine(posicion, new Vector3(), colorPos);
        Debug.DrawLine(velocidad, new Vector3(), colorVel);
        Debug.DrawLine(acceleration, new Vector3(), colorAcc);
    }
    public void Mover()
    {
        velocidad += acceleration * Time.deltaTime; //esto es lo mismo que decir velocidad = vel + aceler*tiempo pero más op
        posicion += velocidad * Time.deltaTime;
        transform.position = posicion;
    }   

}
