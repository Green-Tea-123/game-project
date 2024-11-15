EXTERNAL addGroceries(string)
EXTERNAL getGROCERIES_CARDAMOM()

-> start_dialogue

===start_dialogue===
#speaker: Mother #portrait:Happymother
(get the cardamom?)
*[yes]
-> correct_choice
*[no]
-> END

===correct_choice===
~addGroceries(getGROCERIES_CARDAMOM())
#speaker: Mother #portrait:Happymother
Halim, I want some cardamom to make my famous curry

#speaker Halim #portrait:Halim
Here Auntie, some fresh cardamom for you
Great for curry!

#speaker: Mother #portrait:Happymother
Wah thanks ah Halim, maybe I give some to you tomorrow lah

#speaker Halim #portrait:Halim
Wah Auntie so kind, I'll look forward to it ah
-> END