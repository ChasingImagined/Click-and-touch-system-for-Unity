using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class InputTest : MonoBehaviour
{
    EventBinding<E_OnClickStart> eb_OnClickStart;
    EventBinding<E_OnClickStay>  eb_OnClickStay;
    EventBinding<E_OnclickStop>  eb_OnclickStop;

    private void Awake()
    {
        eb_OnClickStart = new EventBinding<E_OnClickStart>(OnclickStartFunction);
        EventBus<E_OnClickStart>.Subscribe(eb_OnClickStart);

        eb_OnClickStay = new EventBinding<E_OnClickStay>(OnClickStayFunction);
        EventBus<E_OnClickStay>.Subscribe(eb_OnClickStay);

        eb_OnclickStop = new EventBinding<E_OnclickStop>(OclickStopFunction);
        EventBus<E_OnclickStop>.Subscribe(eb_OnclickStop);
    }

    private void OnDestroy()
    {
        EventBus<E_OnClickStart>.UnSubscribe(eb_OnClickStart);
        EventBus<E_OnClickStay>.UnSubscribe(eb_OnClickStay);
        EventBus<E_OnclickStop>.UnSubscribe(eb_OnclickStop);
    }

    void OnclickStartFunction( E_OnClickStart value)
    {
        Debug.Log("OnClickStart firstDot: " + value.firstDot );
    }

    void OnClickStayFunction( E_OnClickStay value )
    {
        Debug.LogFormat("OnClickStay firstDot: {0}  lastDot: {1}", value.firstDot, value.lastDot);
    }

    void OclickStopFunction( E_OnclickStop value)
    {
        Debug.LogFormat("OnClickStop firstDot: {0}  lastDot: {1}", value.firstDot, value.lastDot);
    }

}
