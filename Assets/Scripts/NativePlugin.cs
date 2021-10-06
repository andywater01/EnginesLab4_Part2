using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class NativePlugin : MonoBehaviour
{
    [DllImport("NativePlugin")]
    private static extern int PrintANumber();

    [DllImport("NativePlugin")]
    private static extern int AddTwoIntegers(int i1, int i2);

    [DllImport("NativePlugin")]
    private static extern float AddTwoFloats(float f1, float f2);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PrintANumber());
        Debug.Log(AddTwoIntegers(2, 2));
        Debug.Log(AddTwoFloats(2.5f, 4f));
    }
}