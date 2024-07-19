using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouse : IInputable
{

    private Vector2 firstDot;
    private Vector2 lastDot;

    public void RunInput()
    {
        if(Input.GetMouseButtonDown(0))
        {
            firstDot = Input.mousePosition;
            lastDot = Input.mousePosition;

            EventBus<E_OnClickStart>.Publish(new E_OnClickStart { firstDot = this.firstDot});
            
        }else if(Input.GetMouseButton(0))
        {
            lastDot = Input.mousePosition;
            EventBus<E_OnClickStay>.Publish(new E_OnClickStay { firstDot = this.firstDot,lastDot = this.lastDot });

        }else if (Input.GetMouseButtonUp(0))
        {
            lastDot = Input.mousePosition;
            EventBus<E_OnclickStop>.Publish(new E_OnclickStop { firstDot = this.firstDot, lastDot = this.lastDot });

        }
        

    }

}
