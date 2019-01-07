using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class PengeluaranManager : MonoBehaviour {
[HeaderAttribute("Content")]
	public GameObject prefabItemPengeluaran;
	public RectTransform rtTotalPengeluaran;
	public Transform trfCicilan;
	public Text textBiayaHidup;
	public Text textBiayaTransportasi;
	public Text textSewaApartemen;
	public Text textTotalPengeluaran;

	[HeaderAttribute("Current")]
	public List<GameObject> itemPengeluaran;

	public int totalPengeluaran;

	public void UpdateContent()
	{
		textBiayaHidup.text = PlayerData.Instance.BiayaHidup.ToString("{0:C}");
		textBiayaTransportasi.text = PlayerData.Instance.BiayaTransport.ToString("{0:C}");
		textSewaApartemen.text = PlayerData.Instance.SewaApartemen.ToString("{0:C}");
	}

	void UpdateItemPengeluaran()
	{
		foreach(GameObject g in itemPengeluaran) Destroy(g);
		itemPengeluaran.Clear();

		List<Cicilan> cicilan = PlayerData.Instance.cicilan;
		foreach(Cicilan c in cicilan){
			GameObject tempObj = Instantiate(prefabItemPengeluaran,trfCicilan) as GameObject;

			ItemPengeluaran ip = tempObj.GetComponent<ItemPengeluaran>();
			ip.UpdateContent(c.name,c.jumlah,c.biayaCicil);

			RectTransform trf = tempObj.GetComponent<RectTransform>();
			trf.anchoredPosition = new Vector2(0f,(-100f * itemPengeluaran.Count) -50f);

			itemPengeluaran.Add(tempObj);
		}
		rtTotalPengeluaran.anchoredPosition = new Vector2(0f,(-100f * itemPengeluaran.Count)-50f);
		
	}

	void CalculateTotalPengeluaran()
	{
		int pengeluaranTetap = PlayerData.Instance.BiayaHidup + PlayerData.Instance.BiayaTransport + PlayerData.Instance.SewaApartemen;

	}
}
