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
    //We might need an auido source unless we use FMOD again lol


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
    
    public void LoadStoryNode()
    {
        dialogueRunner.yarnProject = project;
    }
}
