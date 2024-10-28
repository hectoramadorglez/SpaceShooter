using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject enemigoPrefab;
    void Start()
    {
        StartCoroutine(SpawnearNaves());    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator SpawnearNaves() 
    {
        while (true) 
        {

            Instantiate(enemigoPrefab, new Vector3(transform.position.x, Random.Range(-4.4f,4.4f) ,0), Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
        

    }
}
