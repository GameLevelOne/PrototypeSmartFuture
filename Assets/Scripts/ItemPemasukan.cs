using UnityEngine.UI;
using UnityEngine;

public class ItemPemasukan : MonoBehaviour {

	public Text textName;
	public Text textJumlah;

	public void UpdateContent(string name, int jumlah)
	{
		textName.text = name;
		textJumlah.text = jumlah.ToString("{0:C}");
	}
}
