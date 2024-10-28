using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocidad;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }
    void Movimiento() 
    {
        transform.Translate(new Vector2(-1, 0).normalized * velocidad * Time.deltaTime);

    }
}
