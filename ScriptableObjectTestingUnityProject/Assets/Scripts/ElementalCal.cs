using ScriptableObjects.Definition;
using TMPro;
using UnityEngine;

public class ElementalCal : MonoBehaviour
{
    // the element that this script is attached to.
    // .. e.g. if this gameObject is paper, the element should be paper
    public AttackElement element;

    // A label, above the element, we can distinguish it from other elements
    public TextMeshProUGUI label;

    private void OnEnable()
    {
        label.text = element.name;
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherElement = other.gameObject.GetComponent<ElementalCal>();

        if (!otherElement) return;

        // if the other element contains attack element of this gameObject, it means it means it can kill it.
        // e.g. this object is rock and the other is scissor that has rock as its attack element.
        // .. so scissor gameObject onTriggerEnter should be disabled.
        // remember that this script is on each of three elements. So it will be called two times, e.g. on trigger enter
        // .. between rock and scissor, first it checks if rock is attack element of scissor, if yes, disable scissor,
        // .. if not check if scissor is attack element of rock, if so disable rock.
        if (otherElement.element.DefeatedElements.Contains(element))
        {
            otherElement.gameObject.SetActive(false);
        }
    }
}