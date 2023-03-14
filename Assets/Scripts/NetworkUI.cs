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
    // Start is called before the first frame update
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

    }

    // Update is called once per frame
    void Update()
    {

    }
}