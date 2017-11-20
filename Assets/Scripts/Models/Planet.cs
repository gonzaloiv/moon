using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable] public class Planet {

    #region Fields / Properties

    [SerializeField] private GameObject prefab;
    [SerializeField] private float speed;

    public GameObject Prefab { get { return prefab; } } // Problem: This doesn't admit pooling...
    public float Speed { get { return speed; } }

    #endregion

}