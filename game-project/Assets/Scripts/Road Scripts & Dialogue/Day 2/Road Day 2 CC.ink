EXTERNAL addTaskDone(task)
EXTERNAL getMAHJONG()

-> start_dialogue

===start_dialogue===
#speaker: Mother #portrait:Happymother
That’s right! Siew Fong’s house is under renovation, so we’re meeting at the CC today.
Good thing I remembered before wandering off somewhere else. Let’s go – my lucky day awaits
~addTaskDone(getMAHJONG())
#speaker: Auntiesiewfong #portrait:Auntiesiewfong
Eh, late today, ah, Ah Mui! Forgot where my house is, ah? AHAH!
#speaker: Mother #portrait:Happymother
Aiyah… no, no, just a bit of mix-up, lah. Almost ended up at your place instead!
#speaker: Auntiesiewfong #portrait:Auntiesiewfong
Never mind, never mind – come, sit down. We all waiting here already. Ready to lose, or what?
#speaker: Mother #portrait:Happymother
Ok lai
->END