using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

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
        story.BindExternalFunction("MEDICINE_GREEN", () => {
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

    }

    public void unbind(Story story)
    {
        story.UnbindExternalFunction("getBreakfast");
        story.UnbindExternalFunction("getMEDICINE_PINK");
        story.UnbindExternalFunction("getMEDICINE_BLUE");
        story.UnbindExternalFunction("MEDICINE_GREEN");
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
        story.UnbindExternalFunction("getGROCERIES_Prawn");
        story.UnbindExternalFunction("getGROCERIES_Watermelon");
        story.UnbindExternalFunction("getGROCERIES_Pork");
        story.UnbindExternalFunction("addTaskDone");


    }
    
}