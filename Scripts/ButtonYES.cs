using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonYES : MonoBehaviour
{
    public NameData nameData;
    public TextMeshProUGUI List_Text;
    public TextMeshProUGUI total_text;
    public TextMeshProUGUI PeopleLeftTotal, LeftToSigh;
    public CloseAllWindowsAtStart AccessToButton;

    public Sprite Bad, NotBad, Mid, Good; //Source images
    public Image IntScaleImage, SSScaleImage, CreativityScaleImage; //To apply
    
    public int InteligencePoints, SSPoints, CreativePoints, total;
    int f1, f2, f3;
    void Start()
    {
        List_Text.text = " ";  
        PeopleLeftTotal.text = " ";
        LeftToSigh.text = " ";

    }
    public TextMeshProUGUI Text_Count;
    public void Down()
    {
        rollnext_yes();
        showtotal();
    }
    public void rollnext_yes()
    {   
        InteligencePoints = Random.Range(0,4);
        SSPoints = Random.Range(0,4);
        CreativePoints = Random.Range(0,4);

        Text_Count.text = nameData.txt1 + nameData.Trait_Inteligence[InteligencePoints] + ", " +
            nameData.txt2 + nameData.Trait_SocialSkill[SSPoints] + ", " + nameData.txt3 + 
                    nameData.Trait_Creativity[CreativePoints];

        switch (InteligencePoints)
        {
            case 0:
                IntScaleImage.sprite = Bad;
                break;
            case 1:
                IntScaleImage.sprite = NotBad;
                break;
            case 2:
                IntScaleImage.sprite = Mid;
                break;
            case 3:
                IntScaleImage.sprite = Good;
                break;
        }
        switch (SSPoints)
        {
            case 0:
                SSScaleImage.sprite = Bad;
                break;
            case 1:
                SSScaleImage.sprite = NotBad;
                break;
            case 2:
                SSScaleImage.sprite = Mid;
                break;
            case 3:
                SSScaleImage.sprite = Good;
                break;
        }
        switch (CreativePoints)
        {
            case 0:
                CreativityScaleImage.sprite = Bad;
                break;
            case 1:
                CreativityScaleImage.sprite = NotBad;
                break;
            case 2:
                CreativityScaleImage.sprite = Mid;
                break;
            case 3:
                CreativityScaleImage.sprite = Good;
                break;
        }
    }
    public void SaveNum()
    {
        f1 = InteligencePoints;
        f2 = SSPoints;
        f3 = CreativePoints;

    }
    public void addtotal()
    {
        total += f1 + f2 + f3;
        total_text.text = total.ToString();
    }
    public void showtotal()
    {        
        List_Text.text = InteligencePoints.ToString() + ", " + SSPoints.ToString() + ", " + CreativePoints.ToString();
    }

    private int Peoples_Left, NeedToSigh;
    public void resetStartButton()
    {
        Peoples_Left = 30;
        NeedToSigh = 10;

        PeopleLeftTotal.text = "Peoples left: " + Peoples_Left;
        LeftToSigh.text = "how many people are left to hire: " + NeedToSigh;
    }
    public void CountUpdatePeople()
    {
        PeopleLeftTotal.text = "Peoples left: " + Peoples_Left;
        LeftToSigh.text = "how many people are left to hire: " + NeedToSigh;
    }
    public void YesAccept_Count()
    {
        Peoples_Left--;
        NeedToSigh--;
        howManyLeft();
    }
    public void NoDecline_Count()
    {
        howManyLeft();
        Peoples_Left--;
    }
    public void howManyLeft()
    {
        if(Peoples_Left == NeedToSigh)
        {
            if(AccessToButton.No.interactable != false)
            AccessToButton.unInteractableButtons_No_False();
            
            if(Peoples_Left == 0)
            {
                if(AccessToButton.Print.interactable != true)
                AccessToButton.Print.interactable = true;
            }
            return;
        }
        if(NeedToSigh == 0)
        {
            if(AccessToButton.No.interactable != false)
            AccessToButton.unInteractableButtons_No_False();

            AccessToButton.Yes.interactable = false;
            
            if(AccessToButton.Print.interactable != true)
            AccessToButton.Print.interactable = true;
            return;
        }
    }
}
