EXTERNAL addTaskDone(task)
EXTERNAL getCLINIC()
-> start_dialogue

===start_dialogue===
#speaker: Mother #portrait:Happymother
Ah, that’s right! Clinic. Ah Boon said he couldn’t take me this week – got to pick up my medicine myself
Hmm, best to get it done now, I suppose. Don’t want to put it off and end up forgetting altogether. Anything else…?
Alright, Ah Mui, just the clinic. Time to go get that medicine. Then can finally go home and rest
Okay collected. 
~addTaskDone(getCLINIC())
Eh I should get some groceries to eat too? Not sure what to cook today. 
I am abit tired…………
Haiyah, just get some chicken at the market lah then go back
->END