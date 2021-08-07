using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialogueManager : MonoBehaviour
{
    public TextAsset inkFile;
    public GameObject dialogueBox;
    public GameObject choiceButton;
    public GameObject choiceBox;
    public bool isTalking = false;
    private float dialogueSpeed = 50f;

    static Story story;
    Text speakerName;
    Text dialogueText;
    List<string> tags;
    static Choice choiceSelected;


    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkFile.text);
        speakerName = dialogueBox.transform.GetChild(0).GetComponent<Text>();
        dialogueText = dialogueBox.transform.GetChild(1).GetComponent<Text>();
        tags = new List<string>();
        choiceSelected = null;

        InitializeRP();

        // Automatically start dialogue from first speaker when starting the scene
        AdvanceDialogue();
    }

    //
    void rpListener()
    {
        story.ObserveVariable("relationshipPoints", (arg, value) =>
            {
                Debug.Log($"Value updated. Relationship Points: {value}");
            });
    }

    //
    private int _rp;
    public int relationshipPoints
    {

        get => _rp;
        private set
        {
            Debug.Log($"Updating relationship points value. Old value: {_rp}, new value: {value}");
            _rp = value;
        }
    }

    //
    private void InitializeRP()
    {
        relationshipPoints = (int)story.variablesState["relationshipPoints"];

        story.ObserveVariable("relationshipPoints", (arg, value) =>
        {
            relationshipPoints = (int)value;
        });

    }

    //
    private void Update()
    {

        rpListener();

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {

            //Is there more to the story?
            if (story.canContinue)
            {
                AdvanceDialogue();

                //Are there any choices?
                if (story.currentChoices.Count != 0)
                {
                    StartCoroutine(ShowChoices());
                }

            }
            else
            {
                FinishDialogue();
            }
        }
    }

    // Indicate that the dialogus is finished
    private void FinishDialogue()
    {
        Debug.Log("End of Dialogue!");
        // changeScene();
    }

    // Advance through the story
    void AdvanceDialogue()
    {
        string currentSentence = story.Continue();
        ParseTags();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(currentSentence));
    }

    // Dialogue speed and typewriter effect
    IEnumerator TypeSentence(string sentence)
    {
        float t = 0;
        int charIndex = 0;

        while (charIndex < sentence.Length)
        {
            t += Time.deltaTime * dialogueSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, sentence.Length);

            dialogueText.text = sentence.Substring(0, charIndex);

            yield return null;
        }
    }

    // Create then show the choices on the screen until one got selected
    IEnumerator ShowChoices()
    {
        Debug.Log("There are choices need to be made here!");
        List<Choice> _choices = story.currentChoices;

        for (int i = 0; i < _choices.Count; i++)
        {
            GameObject temp = Instantiate(choiceButton, choiceBox.transform);
            temp.transform.GetChild(0).GetComponent<Text>().text = _choices[i].text;
            temp.AddComponent<Selectable>();
            temp.GetComponent<Selectable>().element = _choices[i];
            temp.GetComponent<Button>().onClick.AddListener(() => { temp.GetComponent<Selectable>().Decide(); });
        }

        choiceBox.SetActive(true);

        yield return new WaitUntil(() => { return choiceSelected != null; });

        AdvanceFromDecision();
    }

    // Tells the story which branch to go to
    public static void SetDecision(object element)
    {
        choiceSelected = (Choice)element;
        story.ChooseChoiceIndex(choiceSelected.index);
    }

    // After a choice was made, turn off the panel and advance from that choice
    void AdvanceFromDecision()
    {
        choiceBox.SetActive(false);
        for (int i = 0; i < choiceBox.transform.childCount; i++)
        {
            Destroy(choiceBox.transform.GetChild(i).gameObject);
        }
        choiceSelected = null; // Forgot to reset the choiceSelected. Otherwise, it would select an option without player intervention.
        AdvanceDialogue();
    }

    // Parse my dick
    void ParseTags()
    {
        tags = story.currentTags;

        foreach (string t in tags)
        {
            speakerName.text = t;
            SetSpeakerSprite(t);
            Debug.Log(t + " is speaking!");
        }
    }

    // Call speaker sprite method from character manager class
    void SetSpeakerSprite(string _name)
    {
        CharacterManager charManager = GameObject.FindObjectOfType<CharacterManager>();
        charManager.SwitchSpeakerSprite(_name);
    }

    // Call change scene from scene changer class
    void changeScene()
    {
        SceneChanger sceneChanger = GameObject.FindObjectOfType<SceneChanger>();
        sceneChanger.FuckScene();
    }


}


