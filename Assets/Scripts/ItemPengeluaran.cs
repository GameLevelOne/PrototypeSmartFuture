using UnityEngine;
using UnityEngine.UI;

public class ItemPengeluaran : MonoBehaviour {

	public Text textName;
	public Text textJumlah;
	public Button buttonBayar;

	public int biayaCicil;

	void Enable()
	{
		buttonBayar.onClick.AddListener( ()=> ButtonBayarOnClick() );
	}

	public void UpdateContent(string name, int jumlah,int biayaCicil)
	{
		textName.text = name;
		textJumlah.text = jumlah.ToString("{0:C}");
		this.biayaCicil = biayaCicil;
	}

	public void ButtonBayarOnClick()
	{

	}
}
