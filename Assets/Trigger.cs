using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject triggerField;
    public GameObject cutsceneCamera;
    public GameObject playerOld;
    public GameObject playerNew;
    public  bool isDone = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      // if(Input.GetKeyDown(KeyCode.G))
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            triggerField.SetActive(false);
            cutsceneCamera.SetActive(true);
            Destroy(playerOld);
            playerNew.SetActive(true);
        }
    }


}
