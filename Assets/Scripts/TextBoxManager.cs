using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;

    public Text theText;

    public TextAsset textfile;
    public string[] textlines;

    public int currentLine;
    public int endLine;

    public CharMover player;

 
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharMover>();
        if (textfile != null)
        {
            textlines = (textfile.text.Split('\n'));
        }

        if(endLine == 0)
        {
            endLine = textlines.Length - 1;
        }

    }

    private void Update()
    {
        theText.text = textlines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine++;
        }

        if(currentLine > endLine)
        {
            textBox.SetActive(false);
        }
    }

}
