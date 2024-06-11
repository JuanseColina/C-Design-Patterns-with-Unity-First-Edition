using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get    
        {
            // 3
            if (_instance == null)    
            {
                _instance = FindAnyObjectByType<T>();    
                // 4
                if(_instance == null)    
                {
                    var singletonGO = new GameObject();    
                    singletonGO.name = typeof(T).Name + " (Persists)";
                    _instance = singletonGO.AddComponent<T>();    
                    DontDestroyOnLoad(singletonGO);    
                    Debug.Log("New instance created!");  
                }
            }
            // 6
            return _instance;    
        }
    }

}
