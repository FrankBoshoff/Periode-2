using UnityEngine;

public class Handle : MonoBehaviour {

    private Animator animator;
    public int handle;
    public GameObject door;
        

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnOff(int amount)
    {        
        handle += amount;
        if (handle == 1)
        {         
            HandleConrol("Open");
            door.GetComponent<Cellar_Door>().handleCount += 1;
        }
        if (handle >= 2)
        {
            HandleConrol("Close");
            handle = 0;
            door.GetComponent<Cellar_Door>().handleCount -= 1;
        }

    }

    void HandleConrol(string direction)
    {
        animator.SetTrigger(direction);
    }

}
