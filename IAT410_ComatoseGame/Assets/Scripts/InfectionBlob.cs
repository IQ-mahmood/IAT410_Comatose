using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectionBlob : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private int health;

    void Awake()
    {
        health =3;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <=0)
        {
            //destroy infection blob
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "PlayerAttack"){
           
            health-=1;
            Debug.Log("hit infection");
            
        }
    }
}
