using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMusic : MonoBehaviour
{
    public static BackMusic Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            return;
        } else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
