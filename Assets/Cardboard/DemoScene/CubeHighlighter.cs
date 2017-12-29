using UnityEngine;
using System.Collections;

public class CubeHighlighter : MonoBehaviour {

    public Texture FirstTexture;
    public Texture SecondTexture;
    public Renderer ObjectRenderer;

    //üzerine gelinen pozisyon objesini highlight eder.
    public void Highlight()
    {
        ObjectRenderer.material.SetTexture("_MainTex", SecondTexture);
    }

    //üzerine gelinen pozisyon objesini eski haline getirir.
    public void UnHighLight()
    {
        ObjectRenderer.material.SetTexture("_MainTex", FirstTexture);
    }
}
