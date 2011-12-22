using UnityEngine;
using System.Collections;

public class Script : MonoBehaviour
{
	private	NavMeshAgent nav ;
	// Use this for initialization
	void Start ()
	{
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		nav.Move (Vector3.right * Time.deltaTime);
	}
}
