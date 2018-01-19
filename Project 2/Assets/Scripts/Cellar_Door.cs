using UnityEngine;

public class Cellar_Door : MonoBehaviour {

    Animator animator;
    public int handleCount;
    bool one;
	
	void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	public void Update()
    {
        if (handleCount >= 2 && one == true)
        {
            Activate("Open");
            print("open");
            one = false;
        }
        if(handleCount <= 1 && one == false)
        {
            Activate("Close");
            print("dicht");
            one = true;
        }
    }

    void Activate(string direction)
    {
        animator.SetTrigger(direction);
    }
}
