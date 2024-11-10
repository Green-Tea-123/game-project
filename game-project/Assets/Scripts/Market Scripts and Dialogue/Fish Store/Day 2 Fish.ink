EXTERNAL addGroceries(string)
EXTERNAL getGROCERIES_FISH()
-> start_dialogue

===start_dialogue===
#speaker: Leela #portrait:Leela
Uncle Tan, got anything better? Show us your freshest catch!

#speaker: Uncle Tan #portrait:Uncletan
Aunties, you have good taste! How about this one?
Just came in this morning, still got the shine and everything

#speaker: Leela #portrait:Leela
Ah, this one better! Look at the gills – nice and red
But let’s keep looking, ah, Ah Mui? Got to make sure we’re getting the top choice!
This one’s not bad, and look at this one – see how the flesh bounces back? Means it’s fresh!
Uncle Tan, you really know how to keep quality ah
(get the fish?)
*[yes]
-> correct_choice
*[no]
-> leela_leave

===correct_choice===
#speaker: Mother #portrait:Happymother
Alright, give us two of these beauties – Auntie Leela will not settle for less, you know!
~addGroceries(getGROCERIES_FISH())
-> leela_leave

===leela_leave===
#speaker: Leela #portrait:Leela
Alright, I will go back first ah Mui, you enjoy your shopping

#speaker: Mother #portrait:Happymother
Ok Leela, bye bye
I still need to get some ginger for my fish later
-> END