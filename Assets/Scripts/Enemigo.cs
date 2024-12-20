using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocidad;
    [SerializeField] float vidas;
    Animator animator;
    [SerializeField] GameObject DisparoenemigoPrefab;
    [SerializeField] GameObject Spawnerdebala;
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(Disparosenemigo());
    }

    
    void Update()
    {
        Movimiento();
        
    }
    void Movimiento() 
    {
        transform.Translate(new Vector2(-1, 0).normalized * velocidad * Time.deltaTime);

    }
    public void RecibirDanho(float danhoRecibido) 
    {
        vidas -= danhoRecibido;
        animator.SetTrigger("blink");
        if (vidas <=0) 
        { 
            Destroy(gameObject);
        
        }
        
    
    }
    private IEnumerator Disparosenemigo() 
    { 
        while (true) 
        { 
            Instantiate(DisparoenemigoPrefab, Spawnerdebala.transform.position,Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    
    }
}
