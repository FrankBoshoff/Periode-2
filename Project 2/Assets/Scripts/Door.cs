using UnityEngine;

public class Door : MonoBehaviour {

    Animator animator;
    public int handleCount;
    bool checkActive = true;
    public int handleMax = 2;
    private int handleMin;
	
	void Start ()
    {
        animator = GetComponent<Animator>();
        handleMin = handleMax - 1;
	}
	
	public void Update()
    {
        if (handleCount >= handleMax && checkActive == true)
        {
            Activate("Open");
            checkActive = false;

        }
        if (handleCount <= handleMin && checkActive == false)
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
