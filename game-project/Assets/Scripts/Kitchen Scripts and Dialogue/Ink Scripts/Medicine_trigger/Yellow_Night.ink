EXTERNAL addEveningMeds(string)
EXTERNAL getMEDICINE_YELLOW()
-> start_dialogue
===start_dialogue===
#speaker: Mother #portrait:Happymother
(Do I eat the pink pill?)
*[yes]
~addEveningMeds(getMEDICINE_YELLOW())
Ahh, why this pill tastes so funny
-> END
*[no]
-> END