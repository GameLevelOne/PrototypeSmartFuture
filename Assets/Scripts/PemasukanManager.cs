using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

[System.SerializableAttribute]
public struct Pemasukan{
	public string name;
	public int jumlah;
}

public class PemasukanManager : MonoBehaviour {
	[HeaderAttribute("Content")]
	public GameObject prefabItemPemasukan;
	public RectTransform rtTotalPemasukan;
	public Transform pemasukanPasif;
	public Text textGaji;
	public Text textTotalPemasukan;

	[HeaderAttribute("Current")]
	public List<GameObject> itemPemasukan;
	public List<Pemasukan> pemasukan;
	public int totalPemasukan;
	
	int gaji;

	public void UpdateContent()
	{
		gaji = PlayerData.Instance.Gaji;
		textGaji.text = gaji.ToString("{0:C}");
		CalculateTotalPemasukan();

		UpdateItemPemasukan();
	}

	void UpdateItemPemasukan()
	{
		foreach(GameObject g in itemPemasukan) Destroy(g);
		itemPemasukan.Clear();
		pemasukan.Clear();

		List<Aset> aset = PlayerData.Instance.aset;
		foreach(Aset a in aset){
			if(a.pemasukan > 0){
				//add data
			Pemasukan p = new Pemasukan();
			p.name = a.name;
			p.jumlah = a.pemasukan;

			pemasukan.Add(p);

			//add object
			GameObject tempObj = Instantiate(prefabItemPemasukan,pemasukanPasif) as GameObject;
			
			//content
			ItemPemasukan ip = tempObj.GetComponent<ItemPemasukan>();
			ip.UpdateContent(p.name,p.jumlah);

			//position
			RectTransform trf = tempObj.GetComponent<RectTransform>();
			trf.anchoredPosition = new Vector2(0f,(-100f * itemPemasukan.Count)-50f);
			
			itemPemasukan.Add(tempObj);
			}
		}
		rtTotalPemasukan.anchoredPosition = new Vector2(0f,(-100f * itemPemasukan.Count)-50f);
	}

	void CalculateTotalPemasukan()
	{
		totalPemasukan = gaji;
		foreach(Pemasukan p in pemasukan){
			totalPemasukan += p.jumlah;
		}

		textTotalPemasukan.text = totalPemasukan.ToString();
	}
}