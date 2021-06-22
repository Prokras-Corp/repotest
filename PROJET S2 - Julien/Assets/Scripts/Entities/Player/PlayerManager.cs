using UnityEngine;
using Photon.Pun;
using System.IO;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    PhotonView PV;

    public GameObject player;


    private void Awake()
    {
        instance = this;
        PV = GetComponent<PhotonView>();
        /*player = GameObject.FindGameObjectWithTag("Player");*/
    }

    void Start()
    {
        if (FindObjectOfType<EventSystem>() == null)
        {
            var eventSystem = new GameObject("EventSystem", typeof(EventSystem), typeof(StandaloneInputModule));
            //Pour menus
        }
        if (PV.IsMine)
        {
            CreateController();
        }
    }

    void CreateController()
    {
        PhotonNetwork.Instantiate(Path.Combine("Photon Prefabs", "PlayerController"), Vector3.zero, Quaternion.identity);
        //Met le prefab dans la scène
    }

    public void KillPlayer()
    {
        FindObjectOfType<AudioManager>().Play("PlayerDeath");
        GameObject.FindGameObjectWithTag("Respawn Menu").SetActive(true);
    }
}
