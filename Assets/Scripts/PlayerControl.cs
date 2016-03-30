using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{

    public GameObject player;
    public float speed;

	// Use this for initialization
	void Start ()
	{	    
	}
	
	// Update is called once per frame
	void Update () {
	    Controls();
	}

    void Controls()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, (player.transform.position.z + speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, (player.transform.position.z - speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position = new Vector3(player.transform.position.x - speed * Time.deltaTime, player.transform.position.y, (player.transform.position.z));
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position = new Vector3((player.transform.position.x + speed * Time.deltaTime), player.transform.position.y, player.transform.position.z);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + speed * Time.deltaTime, player.transform.position.z);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            player.transform.position = new Vector3(player.transform.position.x, (player.transform.position.y - speed * Time.deltaTime), player.transform.position.z);
        }
    }
}
