using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellSpawn : MonoBehaviour {

	public int value = 6;
	public GameObject container;

	// Use this for initialization
	void Start () {
		int newNum;
		System.Int32.TryParse( gameObject.name[gameObject.name.Length - 1].ToString(), out newNum );

		if (newNum != 0) {
			GameObject newCell = new GameObject ();
			newCell.transform.position = new Vector3(gameObject.transform.position.x + 50, gameObject.transform.position.y, gameObject.transform.position.z);

			System.Int32.TryParse( gameObject.name[ gameObject.name.Length - 1 ].ToString(), out newNum);
			newNum++;
			newCell.name = "Cell" + newNum.ToString ();

			newCell.AddComponent<CellSpawn> ();
			newCell.GetComponent<CellSpawn> ().container = container;
			newCell.GetComponent<CellSpawn> ().value = value;

			newCell.AddComponent<CanvasRenderer> ();

			newCell.AddComponent<Image> ();

			if (--newNum <= value) { //Filled cell
				newCell.GetComponent<Image>().sprite = Resources.Load<Sprite>( "Images/CharacterCreation/SkillCell" );
			}
					else{ //Empty cell
				newCell.GetComponent<Image>().sprite = Resources.Load<Sprite>( "Images/CharacterCreation/EmptySkillCell" );
			}

			Instantiate (newCell, container.transform);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
