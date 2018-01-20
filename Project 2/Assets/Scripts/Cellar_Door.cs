using UnityEngine;

public class Cellar_Door : MonoBehaviour {

    Animator animator;
    public int handleCount;
    bool checkActive = true;
	
	void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	public void Update()
    {
        if (handleCount >= 2 && checkActive == true)
        {
            Activate("Open");
            checkActive = false;

        }
        if (handleCount <= 1 && checkActive == false)
        {
            Activate("Close");
            checkActive = true;
        }
        
    }

    public void Activate(string direction)
    {
        animator.SetTrigger(direction);
    }
}
