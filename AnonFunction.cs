using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnonFunction : MonoBehaviour
{

    public delegate void TestDelegate();
    private TestDelegate testDelegateFunction;

    void Start()
    {
                                        // anonymous function
        testDelegateFunction = delegate () { Debug.Log("Anonymous method");};
        testDelegateFunction();
        
    }

}
