EXTERNAL addMorningMeds(string)
EXTERNAL getMEDICINE_BLUE()
-> start_dialogue
===start_dialogue===
#speaker: Mother #portrait:Happymother
(Do I eat the pink pill?)
*[yes]
~addMorningMeds(getMEDICINE_BLUE())
Ahh, why is this pill so sour
-> END
*[no]
-> END