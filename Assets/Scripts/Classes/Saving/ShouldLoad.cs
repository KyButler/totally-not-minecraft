using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ShouldLoad
{
    private static bool yes;

    public static bool Yes {
        get {
            return yes;
        }
        set {
            yes = value;
        }
    }
}
