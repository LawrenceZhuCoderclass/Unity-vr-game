using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColourChanger : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    private Light colour1;
    private Light colour2;
    private Light colour3;

    private Transform Lamp1;
    private Transform Lamp2;
    private Transform Lamp3;


    [SerializeField] Color Colour1;
    [SerializeField] Color Colour2;
    [SerializeField] Color Colour3;

    void Start()
    {
        Lamp1 = Light1.gameObject.transform.GetChild(0);
        Lamp2 = Light2.gameObject.transform.GetChild(0);
        Lamp3 = Light3.gameObject.transform.GetChild(0);

        colour1 = Lamp1.GetComponent<Light>();
        colour2 = Lamp2.GetComponent<Light>();
        colour3 = Lamp3.GetComponent<Light>();
    }

    public void Button1Colour()
    {
        Debug.Log("blue");
        colour1.color = Color.Lerp(colour1.color, Colour1,1);
        colour2.color = Color.Lerp(colour2.color, Colour1,1);
        colour3.color = Color.Lerp(colour3.color, Colour1,1);
    }
    public void Button2Colour()
    {
        Debug.Log("red");
        colour1.color = Color.Lerp(colour1.color, Colour2, 1);
        colour2.color = Color.Lerp(colour2.color, Colour2, 1);
        colour3.color = Color.Lerp(colour3.color, Colour2, 1);

    }
    public void Button3Colour()
    {
        Debug.Log("green");
        colour1.color = Color.Lerp(colour1.color, Colour3, 1);
        colour2.color = Color.Lerp(colour2.color, Colour3, 1);
        colour3.color = Color.Lerp(colour3.color, Colour3, 1);
    }
}
