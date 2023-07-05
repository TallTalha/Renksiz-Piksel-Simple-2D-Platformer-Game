using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuzakObjesi : MonoBehaviour
{
    public GameObject baslangicNoktasi;
    public GameObject oyuncu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {   
       
        if (other.gameObject.CompareTag("Player"))
        {
            oyuncu.transform.position = baslangicNoktasi.transform.position;
        }
    }
}
