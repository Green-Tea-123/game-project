EXTERNAL addGroceries(string)
EXTERNAL getGROCERIES_CABBAGE()
->start_dialogue
===start_dialogue===
#speaker: Mother #portrait:Happymother
(should I get cabbages?)
*[yes]
~addGroceries(getGROCERIES_CABBAGE())
Halim ah! Can I get some cabbages, please? Fresh ones, ah! Thank you!
-> END
*[no]
-> END