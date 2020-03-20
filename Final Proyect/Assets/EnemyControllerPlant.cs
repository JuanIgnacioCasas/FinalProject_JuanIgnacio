using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerPlant : MonoBehaviour
{
   // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
   
    }
void OnTriggerEnter2D(Collider2D col){
if(col.gameObject.tag == "Player"){
col.SendMessage("EnemyKnockBack", transform.position.x);

}


}
}
