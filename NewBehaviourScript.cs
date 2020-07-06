using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    float Sum(float a, float b)
    {
        return (a + b);
    }
    float Prod(float a , float b)
    {
        return (a * b);
    }
    float Div(float a , float b)
    {
        
        if(b == 0)
        {
            Debug.Log("Eroor");
        }
    
        return (a / b);
    
    }



}