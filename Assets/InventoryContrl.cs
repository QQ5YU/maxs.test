using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Canvas))]
public class InventoryContrl : MonoBehaviour, IPointerClickHandler
{

    public Sprite selectImage, deSelectImage;
    private void Awake()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject currSelect = eventData.rawPointerPress.transform.parent.gameObject;
        GameObject initImageObj = currSelect.transform.Find("BK").gameObject;
        Image initImage = initImageObj.GetComponent<Image>();
        select(initImage);
        Debug.Log(initImage.sprite);
    }

    private void select(Image initImage)
    {
        initImage.sprite = selectImage;
    }

    private void deSelect(Image initImage)
    {
        initImage.sprite = deSelectImage;
    }
}
