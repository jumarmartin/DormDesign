using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;

public class NetworkUI : MonoBehaviour
{

    [SerializeField] private Button hostButton;
    [SerializeField] private Button clientButton;
    [SerializeField] private Button serverButton;
    private void Awake()
    {
        hostButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartHost();

        });

        serverButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartServer();
        });

        clientButton.onClick.AddListener(() =>
        {
            print("Starting client");
            NetworkManager.Singleton.StartClient();
        });
    }

    void Start()
    {
#if UNITY_WEBGL
            NetworkManager.Singleton.StartClient();
#endif

#if UNITY_EDITOR
        NetworkManager.Singleton.StartHost();
#endif

#if UNITY_SERVER
            Debug.Log("I am a server :)");
            NetworkManager.Singleton.StartServer();
#endif
    }

    // Update is called once per frame
    void Update()
    {

    }
}