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
public class MainManager : MonoBehaviour {
    public static MainManager instance;
    private int dementiaCounter;
    private int day;
    private HashSet<string> tasks;
    private HashSet<string> tasksDone;
    // kitchen activites
    public static readonly string BREAKFAST = "Make breakfast";
    public static readonly string MEDICINE = "Take medicine";

    // road activites
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

    private void Awake() {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }

        instance = this;
        this.dementiaCounter = 0;
        this.day = 1;
        this.tasks = getDay1List();
        this.tasksDone = new HashSet<string>();
        DontDestroyOnLoad(gameObject);
    }

    public int getDementiaCounter() {
        Debug.Log("Dementia counter retrieved." 
            + "Value of counter is: " + this.dementiaCounter);
        return this.dementiaCounter;
    }

    public void incrementDementiaCounter() {
        this.dementiaCounter++;
        Debug.Log("Dementia counter has been incremented."
            + "counter is now at: " + this.dementiaCounter);
    }

    public int getDay() {
        return this.day;
    }

    public void incrementDay() {
        this.day++;
    }

    public static HashSet<string> getDay1List() {
        HashSet<string> list = new HashSet<string>();
        list.Add(BREAKFAST);
        list.Add(MEDICINE);
        list.Add(TAICHI);
        list.Add(GROCERIES_CABBAGE);
        list.Add(GROCERIES_POTATO);
        list.Add(GROCERIES_CHICKEN);
        return list;
    }

    public static HashSet<string> getDay2List() {
        HashSet<string> list = new HashSet<string>();
        list.Add(MEDICINE);
        list.Add(MAHJONG);
        list.Add(CLINIC);
        return list;
    }

    public static HashSet<string> getDay3List() {
        HashSet<string> list = new HashSet<string>();
        list.Add(BREAKFAST);
        list.Add(MEDICINE);
        list.Add(GROCERIES_FISH);
        list.Add(GROCERIES_GINGER);
        return list;
    }

    public static HashSet<string> getDay4List() {
        HashSet<string> list = new HashSet<string>();
        list.Add(BREAKFAST);
        list.Add(MEDICINE);
        list.Add(GROCERIES_CARDAMOM);
        list.Add(GROCERIES_BEEF);
        list.Add(GROCERIES_CARROT);
        return list;
    }

    public void addTaskDone(string task) {
        this.tasksDone.Add(task);
    }

    public void checkTasks() {
        bool isSame = this.tasks.Equals(this.tasksDone);
        if (!isSame) {
            incrementDementiaCounter();
        }
    }

    public void updateDayList() {
        switch (this.day) {
            case 1:
                this.tasks = getDay1List();
                break;
            case 2:
                this.tasks = getDay2List();
                break;
            case 3:
                this.tasks = getDay3List();
                break;
            case 4:
                this.tasks = getDay4List();
                break;
            default:
                Debug.Assert(false);
                break;
        }
    }
}
