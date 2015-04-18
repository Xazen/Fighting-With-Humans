using UnityEngine;
using System.Collections;

public class VictimBase : MonoBehaviour {

	private VictimCollision _victimCollision;
	public VictimCollision VictimCollision
	{
		get
		{
			if (_victimCollision == null)
			{
				_victimCollision = GetComponent<VictimCollision>();
			}
			return _victimCollision;
		}
	}
}
