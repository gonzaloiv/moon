using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScreenController : MonoBehaviour {

    #region Fields / Properties

    [SerializeField] private Button startButton;

    #endregion

    #region Events

    public delegate void StartButtonClickEventHandler ();
    public static event StartButtonClickEventHandler StartButtonClickEvent = delegate {};

    #endregion

    #region Mono Behaviour

    void Awake () {
        startButton.onClick.AddListener(InvokeStartButtonClickEvent);
    }

    #endregion

    #region Public Behaviour

    public void InvokeStartButtonClickEvent() {
        StartButtonClickEvent.Invoke();
    }

    #endregion

}
