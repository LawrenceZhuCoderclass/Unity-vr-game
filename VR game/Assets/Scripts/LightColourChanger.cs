using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColourChanger : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    private Light colour1;
    private Light colour2;
    private Light colour3;
    private Light colour4;

    [SerializeField] Color Colour1;
    [SerializeField] Color Colour2;
    [SerializeField] Color Colour3;

    void Start()
    {


        colour1 = Light1.GetComponent<Light>();
        colour2 = Light2.GetComponent<Light>();
        colour3 = Light3.GetComponent<Light>();
        colour4 = Light4.GetComponent<Light>();
    }

    public void Button1Colour()
    {  
        colour1.color = Colour1;
        colour2.color = Colour1;
        colour3.color = Colour1;
        colour4.color = Colour1;
    }
    public void Button2Colour()
    {
        colour1.color = Colour2;
        colour2.color = Colour2;
        colour3.color = Colour2;
        colour4.color = Colour2;
    }
    public void Button3Colour()
    {
        colour1.color = Colour3;
        colour2.color = Colour3;
        colour3.color = Colour3;
        colour4.color = Colour3;
    }
}
