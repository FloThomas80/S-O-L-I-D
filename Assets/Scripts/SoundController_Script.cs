using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController_Script : MonoBehaviour
{

    private static SoundController_Script instance;
    //methode Bobo :​
    /*
     * Créer le gameobject avec l'audiosource intégré
     */
    [SerializeField]
    private GameObject mBackGroundMusic;
    [SerializeField]
    private GameObject mAlerte;
    [SerializeField]
    private GameObject mCollect;

    public SoundController_Script Instance //instance called
    {
        get

        {
            if (instance == null)
            {
                instance = FindObjectOfType<SoundController_Script>();

                if (instance == null)
                {
                    GameObject SoundController_Script = new GameObject("SoundController");
                    instance = SoundController_Script.AddComponent<SoundController_Script>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        Instantiate(mBackGroundMusic);

        //relicat 
        //if (instance != null && instance != this) //singleton, only one instance exist ?
        //{
        //    Destroy(gameObject);
        //    return;
        //}

        //instance = this;
        //DontDestroyOnLoad(gameObject);//don't destroy me, i'm THE SOUND Controller ! (what would be a sailor without a good song ?)
    }

    public void LaunchAlertSound()
    {
        // Indiquer le destroy avec un temps de delete
        Destroy(Instantiate(mAlerte), 2);
    }
    public void LaunchEatSound()
    {
        Destroy(Instantiate(mCollect), 2);
    }
}
