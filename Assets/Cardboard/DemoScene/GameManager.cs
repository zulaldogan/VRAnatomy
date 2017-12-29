using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    private Teleport _currentBodyPart;

    public void SetCurrentBodyPart(Teleport currentBodyScript)
    {
        _currentBodyPart = currentBodyScript;
    }

    //Cardboard'un kenarındaki mıknatıs
    //Current objenin görüşünü değiştirir.
    public void Transformation()
    {
        //TODO : setGazeAt fonksiyonu projeye uyarlanacak.
    }
}
