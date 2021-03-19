using System.Collections; //자료형
using System.Collections.Generic; //제네릭
using UnityEngine; //엔진

public class RoulletController : MonoBehaviour
{
    float rotSpeed = 0.0f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10.0f;
            
            transform.Rotate(0, 0, -this.rotSpeed);
        }
        //if (this.rotSpeed <= 0.0f)
        //    this.rotSpeed = 0.0f;
        //else
        //    this.rotSpeed -= 0.01f;
        this.rotSpeed *= 0.987f;
        transform.Rotate(0, 0, -this.rotSpeed);
        //while(true)
        //{
        //    if (rotSpeed > 0)
        //    {

        //        transform.Rotate(0, 0, -this.rotSpeed);

        //    }
        //    else
        //        break;
        //}
        if (Input.GetMouseButton(1))
        {
            this.rotSpeed = 0.0f;
            transform.Rotate(0, 0, -this.rotSpeed);
            //for(int i = this.rotSpeed;i>=0;i-=0.01f)

        }
            
        
    }
}
