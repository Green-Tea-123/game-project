using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using UnityEngine;

/**
 * Class that handles all global variables shared between scenes.
 * To use the functions here, call <code>MainManager.instance</code>,
 * followed by the function you want to call.
 */
public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    private int dementiaCounter;
    private int day;
    private HashSet<string> tasks;
    private HashSet<string> tasksDone;
    private HashSet<string> morningMeds;
    private HashSet<string> morningMedsTaken;
    private HashSet<string> eveningMeds;
    private HashSet<string> eveningMedsTaken;
    private HashSet<string> groceries;
    private HashSet<string> groceriesBought;

    // kitchen activities
    public static readonly string BREAKFAST = "Make breakfast";
    public static readonly string MEDICINE_PINK = "Take pink medicine"; // tues and thur, morning
    public static readonly string MEDICINE_BLUE = "Take blue medicine"; // every day, evening
    public static readonly string MEDICINE_GREEN = "Take green medicine"; // every day, morning
    public static readonly string MEDICINE_YELLOW = "Take yellow medicine"; // mon wed fri, evening

    // road activities
    public static readonly string TAICHI = "Attend Taichi session";
    public static readonly string MAHJONG = "Play mahjong";
    public static readonly string CLINIC = "Get medicine at the clinic";

    // groceries
    public static readonly string GROCERIES_FISH = "Buy a fish";
    public static readonly string GROCERIES_FRUIT = "Buy a banana";
    public static readonly string GROCERIES_CABBAGE = "Buy a cabbage";
    public static readonly string GROCERIES_POTATO = "Buy a potato";
    public static readonly string GROCERIES_CARROT = "Buy a carrot";
    public static readonly string GROCERIES_BEEF = "Buy beef";
    public static readonly string GROCERIES_CHICKEN = "Buy a chicken";
    public static readonly string GROCERIES_GINGER = "Buy some ginger";
    public static readonly string GROCERIES_CARDAMOM = "Buy some cardamom";
    public static readonly string GROCERIES_PRAWN = "Buy some prawn";
    public static readonly string GROCERIES_WATERMELON = "Buy some watermelon";
    public static readonly string GROCERIES_PORK = "Buy some pork";

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        this.dementiaCounter = 0;
        this.day = 1;
        getDay1List();
        DontDestroyOnLoad(gameObject);
    }

    public int getDementiaCounter()
    {
        Debug.Log("Dementia counter retrieved."
            + "Value of counter is: " + this.dementiaCounter);
        return this.dementiaCounter;
    }

    public void incrementDementiaCounter()
    {
        this.dementiaCounter++;
        Debug.Log("Dementia counter has been incremented."
            + "Counter is now at: " + this.dementiaCounter);
    }

    public int getDay()
    {
        return this.day;
    }

    public void incrementDay()
    {
        this.day++;
        updateDayList();
        Debug.Log("Day incremented to " + this.day);
    }

    // Define task lists for each day, following the same format
    public void getDay1List()
    {
        this.tasks = new HashSet<string>();
        this.morningMeds = new HashSet<string>();
        this.eveningMeds = new HashSet<string>();
        this.groceries = new HashSet<string>();

        this.tasksDone = new HashSet<string>();
        this.morningMedsTaken = new HashSet<string>();
        this.eveningMedsTaken = new HashSet<string>();
        this.groceriesBought = new HashSet<string>();

        this.tasks.Add(BREAKFAST);
        this.tasks.Add(TAICHI);
        this.groceries.Add(GROCERIES_CABBAGE);
        this.groceries.Add(GROCERIES_POTATO);
        this.groceries.Add(GROCERIES_CHICKEN);
        this.morningMeds.Add(MEDICINE_GREEN);
        this.morningMeds.Add(MEDICINE_PINK);
        this.eveningMeds.Add(MEDICINE_BLUE);
    }

    public void getDay2List()
    {
        this.tasks = new HashSet<string>();
        this.morningMeds = new HashSet<string>();
        this.eveningMeds = new HashSet<string>();
        this.groceries = new HashSet<string>();

        this.tasksDone = new HashSet<string>();
        this.morningMedsTaken = new HashSet<string>();
        this.eveningMedsTaken = new HashSet<string>();
        this.groceriesBought = new HashSet<string>();

        this.tasks.Add(MAHJONG);
        this.tasks.Add(CLINIC);
        this.groceries.Add(GROCERIES_CHICKEN);
        this.morningMeds.Add(MEDICINE_GREEN);
        this.eveningMeds.Add(MEDICINE_BLUE);
        this.eveningMeds.Add(MEDICINE_YELLOW);
    }

    public void getDay3List()
    {
        this.tasks = new HashSet<string>();
        this.morningMeds = new HashSet<string>();
        this.eveningMeds = new HashSet<string>();
        this.groceries = new HashSet<string>();

        this.tasksDone = new HashSet<string>();
        this.morningMedsTaken = new HashSet<string>();
        this.eveningMedsTaken = new HashSet<string>();
        this.groceriesBought = new HashSet<string>();

        this.tasks.Add(BREAKFAST);
        this.groceries.Add(GROCERIES_FISH);
        this.groceries.Add(GROCERIES_GINGER);
        this.morningMeds.Add(MEDICINE_GREEN);
        this.morningMeds.Add(MEDICINE_PINK);
        this.eveningMeds.Add(MEDICINE_BLUE);
    }

    public void getDay4List()
    {
        this.tasks = new HashSet<string>();
        this.morningMeds = new HashSet<string>();
        this.eveningMeds = new HashSet<string>();
        this.groceries = new HashSet<string>();

        this.tasksDone = new HashSet<string>();
        this.morningMedsTaken = new HashSet<string>();
        this.eveningMedsTaken = new HashSet<string>();
        this.groceriesBought = new HashSet<string>();

        this.tasks.Add(BREAKFAST);
        this.groceries.Add(GROCERIES_CARDAMOM);
        this.groceries.Add(GROCERIES_BEEF);
        this.groceries.Add(GROCERIES_CARROT);
        this.morningMeds.Add(MEDICINE_GREEN);
        this.eveningMeds.Add(MEDICINE_BLUE);
        this.eveningMeds.Add(MEDICINE_YELLOW);
    }

    public void addTaskDone(string task)
    {
        this.tasksDone.Add(task);
        Debug.Log("addtask triggered:" + task);
    }

    public void addMorningMeds(string meds) {
        this.morningMedsTaken.Add(meds);
        Debug.Log("addMorningMeds triggered: " + meds);
    }

    public void addEveningMeds(string meds) {
        this.eveningMedsTaken.Add(meds);
        Debug.Log("addEveningMeds triggered: " + meds);
    }

    public void addGroceries(string item) {
        this.groceriesBought.Add(item);
        Debug.Log("addGroceries triggered: " + item);
    }

    public void checkTasks()
    {
        bool allTasksCompleted = this.tasks.SetEquals(this.tasksDone);
        Debug.Log("Tasks checked. All tasks completed: " + allTasksCompleted);
        if (!allTasksCompleted)
        {
            incrementDementiaCounter();
        }

        bool allMorningMedicineTaken = this.morningMeds.SetEquals(this.morningMedsTaken);
        bool allEveningMedicineTaken = this.eveningMeds.SetEquals(this.eveningMedsTaken);
        if (!(allMorningMedicineTaken && allEveningMedicineTaken)) {
            incrementDementiaCounter();
        }

        bool allGroceriesBought = this.groceries.SetEquals(this.groceriesBought);
        if (!allGroceriesBought) {
            incrementDementiaCounter();
        }
    }

    public void updateDayList()
    {
        // Call the appropriate list initializer based on the current day
        switch (this.day)
        {
            case 1:
                getDay1List();
                break;
            case 2:
                getDay2List();
                break;
            case 3:
                getDay3List();
                break;
            case 4:
                getDay4List();
                break;
            default:
                Debug.LogWarning("No list available for day: " + this.day);
                break;
        }
    }
}
