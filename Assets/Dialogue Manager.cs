using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private DialogueRunner dialogueRunner;
    [SerializeField] private string nodeToLoad;
    [SerializeField] private YarnProject project;
    [SerializeField] private Image leftCharacterImage;
    [SerializeField] private Image rightCharacterImage;
    [SerializeField] Color fullColor;
    [SerializeField] Color dullColor;
    //You might need new variables for the heart and sweat sprites!


    private void Awake()
    {
        LoadStoryNode();
    }

    private void Start()
    {
        dialogueRunner.StartDialogue(nodeToLoad);
    }


    [YarnCommand("ActiveLeft")]
    public void ActiveLeft()
    {
        leftCharacterImage.color = fullColor;
        rightCharacterImage.color = dullColor;
    }

    [YarnCommand("ActiveRight")]
    public void ActiveRight()
    {
        rightCharacterImage.color = fullColor;
        leftCharacterImage.color = dullColor;

    }

    //Add the heart and sweat macros here!
    
    public void LoadStoryNode()
    {
        dialogueRunner.yarnProject = project;
    }
}
