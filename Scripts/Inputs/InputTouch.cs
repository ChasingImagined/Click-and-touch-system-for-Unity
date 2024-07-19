using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTouch : IInputable
{
    Vector2 firstDot;
    Vector2 lastDot;
    public void RunInput()
    {
       

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            switch(touch.phase)
            {
                case TouchPhase.Began:
                    firstDot = touch.position;
                    lastDot = touch.position;
                    EventBus<E_OnClickStart>.Publish(new E_OnClickStart { firstDot = this.firstDot});

                    break;
                case TouchPhase.Moved:
                case TouchPhase.Stationary:
                    lastDot = touch.position;
                    EventBus<E_OnClickStay>.Publish(new E_OnClickStay { firstDot = this.lastDot , lastDot = this.lastDot });

                    break;
                case TouchPhase.Ended:
                    lastDot = touch.position;
                    EventBus<E_OnclickStop>.Publish(new E_OnclickStop { firstDot = this.firstDot, lastDot = this.lastDot });
                    break;
            }
        }
    }
}
