using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
class voeni : MonoBehaviour
{
    GameObject player;
    public GameObject target;
    public float bSpeed;
	float direction = -1f;
    const float speedMove = 2.0f;
    
    public float TimeToDisable;
    public Rigidbody2D bullet; 
	public Transform gunPoint; 
	public float fireRate = 1; 
	public Transform zRotate;
   
	public float minAngle = -40;
	public float maxAngle = 40;
    private float curTimeout;
 
    void Start()
    {
        player = GameObject.FindWithTag("Player");
		target = GameObject.Find("Player");
        transform.LookAt(target.transform);
	}
 
    void SetRotation()
	{
		Vector3 mousePosMain = Input.mousePosition;
		mousePosMain.z = Camera.main.transform.position.z; 
		Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePosMain);
		lookPos = lookPos - transform.position;
		float angle  = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
		angle = Mathf.Clamp(angle, minAngle, maxAngle);
		zRotate.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}

    void Update()
    {
        float direction = player.transform.position.x - transform.position.x;
		float directionY = player.transform.position.y - transform.position.y;
 
        if (((Mathf.Abs(direction) <25) & (Mathf.Abs(direction) > 1)) & ((Mathf.Abs(directionY) <4)))
        {
            Vector3 pos = transform.position;
            pos.x += Mathf.Sign(direction) * speedMove * Time.deltaTime;
            transform.position = pos;
        }

		if (direction < 0)
		{
			direction *= -1f;
		}
        
        if (Mathf.Abs(direction) > 1)
        {
            if(Input.GetMouseButton(0))
		    {
			    Fire();
		    }
		    else
		    {
			    curTimeout = 100;
		    }

		    if(zRotate) SetRotation();

        }
        void Fire()
	    {
		    curTimeout += Time.deltaTime;
		    if(curTimeout > fireRate)
		    {
		    	curTimeout = 0;
		    	Rigidbody2D clone = Instantiate(bullet, gunPoint.position, Quaternion.identity) as Rigidbody2D;
		    	clone.velocity = transform.TransformDirection(gunPoint.right * bSpeed);
		    	clone.transform.right = gunPoint.right;
		    }
	    }

    }
    
}