using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int velocidad;
    [SerializeField] GameObject disparo;
    [SerializeField] GameObject spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        LimitarMovimiento();
        Disparar();
    }

    private void Movimiento()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(v, h).normalized * velocidad * Time.deltaTime);
        
    }
    private void LimitarMovimiento() 
    { 
    
       float clampx = Mathf.Clamp(transform.position.x,-8.4f, 8.4f);
       float clampy = Mathf.Clamp(transform.position.y, -4.4f, 4.4f);
        this.gameObject.transform.position = new Vector2(clampx, clampy);


    }
    private void Disparar() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            Instantiate(disparo,spawnPoint.transform.position,Quaternion.identity);
           
        
        }
    
    
    }
}
