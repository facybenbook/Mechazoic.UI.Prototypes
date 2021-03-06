using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Weapon")]
public class WeaponObject : ScriptableObject
{
	public string weaponName;
	public GameObject bullet;
	public float damage;
	public float speed;
	public float fireRate;

	[Header("	")]

	[Range(0,1)]
	public float heatPercentage;

	[Range(0,1)]
	public float slowMoModifier;

	public float ammoAmount;

}
