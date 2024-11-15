using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using UnityEditor.Experimental.GraphView;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class Externalfunction
{
    public void bind(Story story)
    {
        story.BindExternalFunction("getBreakfast", () => {
            return MainManager.BREAKFAST;
        });
        story.BindExternalFunction("getMEDICINE_PINK", () => {
            return MainManager.MEDICINE_PINK;
        });
        story.BindExternalFunction("getMEDICINE_BLUE", () => {
            return MainManager.MEDICINE_BLUE;
        });
        story.BindExternalFunction("getMEDICINE_GREEN", () => {
            return MainManager.MEDICINE_GREEN;
        });
        story.BindExternalFunction("getMEDICINE_YELLOW", () => {
            return MainManager.MEDICINE_YELLOW;
        });
        story.BindExternalFunction("getTAICHI", () => {
            return MainManager.TAICHI;
        });
        story.BindExternalFunction("getMAHJONG", () => {
            return MainManager.MAHJONG;
        });
        story.BindExternalFunction("getCLINIC", () => {
            return MainManager.CLINIC;
        });
        story.BindExternalFunction("getGROCERIES_FISH", () => {
            return MainManager.GROCERIES_FISH;
        });
        story.BindExternalFunction("getGROCERIES_FRUIT", () => {
            return MainManager.GROCERIES_FRUIT;
        });
        story.BindExternalFunction("getGROCERIES_CABBAGE", () => {
            return MainManager.GROCERIES_CABBAGE;
        });
        story.BindExternalFunction("getGROCERIES_POTATO", () => {
            return MainManager.GROCERIES_POTATO;
        });
        story.BindExternalFunction("getGROCERIES_CARROT", () => {
            return MainManager.GROCERIES_CARROT;
        });
        story.BindExternalFunction("getGROCERIES_BEEF", () => {
            return MainManager.GROCERIES_BEEF;
        });
        story.BindExternalFunction("getGROCERIES_CHICKEN", () => {
            return MainManager.GROCERIES_CHICKEN;
        });
        story.BindExternalFunction("getGROCERIES_GINGER", () => {
            return MainManager.GROCERIES_GINGER;
        });
        story.BindExternalFunction("getGROCERIES_CARDAMOM", () => {
            return MainManager.GROCERIES_CARDAMOM;
        });
        story.BindExternalFunction("getGROCERIES_PRAWN", () => {
            return MainManager.GROCERIES_PRAWN;
        });
        story.BindExternalFunction("getGROCERIES_WATERMELON", () => {
            return MainManager.GROCERIES_WATERMELON;
        });
        story.BindExternalFunction("getGROCERIES_PORK", () => {
            return MainManager.GROCERIES_PORK;
        });
        story.BindExternalFunction("addTaskDone", (string task) => {
            MainManager.instance.addTaskDone(task);
        });
        story.BindExternalFunction("addGroceries", (string task) => {
            MainManager.instance.addGroceries(task);
        });
        story.BindExternalFunction("addMorningMeds", (string task) => {
            MainManager.instance.addMorningMeds(task);
        });
        story.BindExternalFunction("addEveningMeds", (string task) => {
            MainManager.instance.addEveningMeds(task);
        });

        story.BindExternalFunction("incrementDementiaCounter", () => {
            MainManager.instance.incrementDementiaCounter();
        });

        story.BindExternalFunction("colomnappear", (string filePath) => {
            GameObject box = GameObject.Find(filePath);
            box.SetActive(true);
        });

        story.BindExternalFunction("colomndisappear", (string filePath) => {
            GameObject box = GameObject.Find(filePath);
            box.SetActive(false);
        });

        story.BindExternalFunction("notesappear", () => {
            UnityEngine.Debug.Log("note appear called");
            GameObject note = DialogueManager.GetInstance()
            .getChildObject("Canvas/Note");
            UnityEngine.Debug.Log(note);
            note.SetActive(true);
        });

        story.BindExternalFunction("notesdisappear", () => {
            UnityEngine.Debug.Log("note disappear called");
            GameObject note = DialogueManager.GetInstance()
            .getChildObject("Canvas/Note");
            UnityEngine.Debug.Log(note);
            note.SetActive(false);
        });

        story.BindExternalFunction("caliingnotes", (string filePath) =>
        {
            GameObject note = DialogueManager.GetInstance().getChildObject(filePath);
            if (note != null)
            {
                note.SetActive(true);
            }
            else
            {
                UnityEngine.Debug.LogWarning("note");
            }
        });

        story.BindExternalFunction("goodendingscene", (string endingz) =>
        {
            SceneManager.LoadScene(endingz);
        });




        }

    public void unbind(Story story)
    {
        story.UnbindExternalFunction("getBreakfast");
        story.UnbindExternalFunction("getMEDICINE_PINK");
        story.UnbindExternalFunction("getMEDICINE_BLUE");
        story.UnbindExternalFunction("getMEDICINE_GREEN");
        story.UnbindExternalFunction("getMEDICINE_YELLOW");
        story.UnbindExternalFunction("getTAICHI");
        story.UnbindExternalFunction("getMAHJONG");
        story.UnbindExternalFunction("getCLINIC");
        story.UnbindExternalFunction("getGROCERIES_FISH");
        story.UnbindExternalFunction("getGROCERIES_FRUIT");
        story.UnbindExternalFunction("getGROCERIES_CABBAGE");
        story.UnbindExternalFunction("getGROCERIES_POTATO");
        story.UnbindExternalFunction("getGROCERIES_CARROT");
        story.UnbindExternalFunction("getGROCERIES_BEEF");
        story.UnbindExternalFunction("getGROCERIES_CHICKEN");
        story.UnbindExternalFunction("getGROCERIES_GINGER");
        story.UnbindExternalFunction("getGROCERIES_CARDAMOM");
        story.UnbindExternalFunction("getGROCERIES_PRAWN");
        story.UnbindExternalFunction("getGROCERIES_WATERMELON");
        story.UnbindExternalFunction("getGROCERIES_PORK");
        story.UnbindExternalFunction("addTaskDone");
        story.UnbindExternalFunction("addGroceries");
        story.UnbindExternalFunction("addMorningMeds");
        story.UnbindExternalFunction("addEveningMeds");
        story.UnbindExternalFunction("incrementDementiaCounter");
        story.UnbindExternalFunction("colomnappear");
        story.UnbindExternalFunction("colomndisappear");


    }
    
}
