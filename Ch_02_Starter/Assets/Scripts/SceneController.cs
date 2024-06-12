using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Button start;

    private void Start()
    {
        start.onClick.AddListener(SOManager.Instance.StartGame);
    }
}
