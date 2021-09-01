using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameAssets : MonoBehaviour
{
    private static GameAssets instanca;
    public Transform prefPipeHead, prefPipeBody, prefGround;
    public AudioZvuk[] nizZvukova;


    public static GameAssets GetInstancu() {
        return instanca;
    }

    private void Awake()
    {
        instanca = this;
    }


    



    [System.Serializable]
    public class AudioZvuk
    {
        public Sound.Zvuk zvuk;
        public AudioClip audioklip;
    }

}

