EXTERNAL addTaskDone(string)
-> start_dialogue

===start_dialogue===
#speaker: Mother #portrait:Happymother
(should I get cabbages?)
*[yes]
Halim ah! Can I get some cabbages, please? Fresh ones, ah! Thank you!
~addTaskDone("Buy a cabbage")
zzz
-> END
*[no]
-> END