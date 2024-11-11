EXTERNAL addGroceries(string)
EXTERNAL getGROCERIES_CABBAGE()
->start_dialogue
===start_dialogue===
#speaker: Mother #portrait:Happymother
(should I get cabbages?)
*[yes]
Halim ah! Can I get some cabbages, please? Fresh ones, ah! Thank you!
~addGroceries(getGROCERIES_CABBAGE())
-> END
*[no]
-> END