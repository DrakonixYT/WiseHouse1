using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class goceneManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        void OnEnter(Collision collision)
        {

            if (collision.gameObject.tag == "Niga")
            {
                SceneManager.GetSceneByBuildIndex(0);
            }
        }

    }

    }



    

