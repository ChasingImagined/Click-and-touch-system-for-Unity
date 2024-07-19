using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEventBus : MonoBehaviour
{
    EventBinding<DemoEvent_1> deneme;
    EventBinding<DemoEvent_2> deneme2;

    
    private void Start()
    {
        deneme = new EventBinding<DemoEvent_1>(TestFonksiyon);
        EventBus<DemoEvent_1>.Subscribe(deneme);
        deneme2 = new EventBinding<DemoEvent_2>(TestFonksiyon2);
        EventBus<DemoEvent_2>.Subscribe(deneme2);
       

    }

   
    public void TestFonksiyon()
    {
        Debug.Log("Test");
    }

    public void TestFonksiyon2()
    {
        Debug.Log("Test 2");
    }

    private void Update()
    {
       // EventBus<DemoEvent_1>.Publish(new DemoEvent_1());
       // EventBus<DemoEvent_2>.Publish(new DemoEvent_2());
    }


    private void OnDisable()
    {
        EventBus<DemoEvent_1>.UnSubscribe(deneme);
        EventBus<DemoEvent_2>.UnSubscribe(deneme2);

        
    }

    

}
