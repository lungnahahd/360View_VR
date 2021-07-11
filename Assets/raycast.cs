using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast : MonoBehaviour
{
    public Image gauge;
    float timegone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        raycasting();
    }


    void raycasting(){
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward *1000);
        if(Physics.Raycast(transform.position, forward, out hit)){
            timegone = timegone + Time.deltaTime;
            gauge.fillAmount = timegone / 3;
            if(timegone >= 3){
                hit.transform.GetComponent<Button>().onClick.Invoke();
            }
        }else{
            timegone = 0;
            gauge.fillAmount = timegone / 3;
        }
        Debug.DrawRay(transform.position, forward, Color.blue);
    }
}
