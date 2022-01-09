
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class SpawnMachine : MonoBehaviour
    {
        public GameObject button1;
        public GameObject button2;
        public GameObject button3;

        public GameObject machine1;
        public GameObject machine2;
        public GameObject machine3;

        public GameObject currentGameObject;



        public void button1effect()
        {
            Destroy(currentGameObject);
            Debug.Log("Machine1");
            currentGameObject = Instantiate(machine1, new Vector3(15, 0, -17), Quaternion.identity);
            

        }
        public void button2effect()
        {
            Destroy(currentGameObject);
            
            Debug.Log("Machine2");
            currentGameObject = Instantiate(machine2, new Vector3(15, 0, -17), Quaternion.identity);
            

        }
        public void button3effect()
        {
            Destroy(currentGameObject);            
            Debug.Log("Machine3");
            currentGameObject = Instantiate(machine3, new Vector3(15, 0.06f, -17), Quaternion.identity);
            

        }
    }
}