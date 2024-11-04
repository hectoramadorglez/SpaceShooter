using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int velocidad;
    [SerializeField] int danhoDisparo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(1,0,0)*3*Time.deltaTime);
    }
    private void Movimiento() 
    { 
        transform.Translate(new Vector3(1,0,0)* velocidad*Time.deltaTime);
    
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemigo")) 
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Enemigo>().RecibirDanho(danhoDisparo);



        }
    }
    
}
