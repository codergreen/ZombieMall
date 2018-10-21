using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellSpawn : MonoBehaviour {

	public int value = 6;

	// Use this for initialization
	void Start () {
		int newNum;
		System.Int32.TryParse( gameObject.name[gameObject.name.Length - 1].ToString(), out newNum );

		if (newNum != 0) {
			GameObject newCell = new GameObject ();
			newNum++;
			newCell.name = "Cell" + newNum.ToString ();
			newCell.transform.position = new Vector3 (gameObject.transform.position.x + 5, gameObject.transform.position.y, gameObject.transform.position.z);
			newCell.AddComponent<CellSpawn> ();
			newCell.AddComponent<Image> ();
			Image newImage = newCell.GetComponent<Image> ();
			newCell.transform.SetParent (GameObject.FindGameObjectWithTag ("Canvas").transform, false);

			if (--newNum <= value) { //Filled cell
				//newImage = Resources.Load ("Images/CharacterCreation/SkillCell");
			} else { //Empty cell
				//newImage = Resources.Load ("Images/CharacterCreation/EmptySkillCell");
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
