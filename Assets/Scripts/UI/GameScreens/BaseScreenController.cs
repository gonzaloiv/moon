using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseScreenController : MonoBehaviour {

    #region Public Behaviour

    public virtual void Show () {
        gameObject.SetActive(true);
    }

    public virtual void Hide () {
        gameObject.SetActive(false);
    }

    #endregion
	
}
