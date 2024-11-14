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
Mr. Lim, I want some cardamom to make my famous curry

#speaker Mr. Lim #portrait:Mrlim
Here Auntie, some fresh cardamom for you
Great for curry!

#speaker: Mother #portrait:Happymother
Wah thanks ah Mr. Lim, maybe I give some to you tomorrow lah

#speaker Mr. Lim #portrait:Mrlim
Wah Auntie so kind, I'll look forward to it ah
-> END