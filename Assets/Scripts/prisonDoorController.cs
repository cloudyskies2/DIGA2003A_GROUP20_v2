using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class prisonDoorController : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Sword;
    [SerializeField] GameObject prisonDoor;

    [SerializeField] private TMP_Text prisonDoorText;
    public bool locked;

    void Start()
    {
        locked = true;
        prisonDoorText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            prisonDoorText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            prisonDoorText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Q) && Sword == null)
        {
            Destroy(prisonDoor);
            locked = false;
            prisonDoorText.gameObject.SetActive(false);
        }
    }
}
