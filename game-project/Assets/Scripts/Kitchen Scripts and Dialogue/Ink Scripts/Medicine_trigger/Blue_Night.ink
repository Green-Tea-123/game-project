EXTERNAL addEveningMeds(string)
EXTERNAL getMEDICINE_BLUE()
-> start_dialogue
===start_dialogue===
#speaker: Mother #portrait:Happymother
(Do I eat the pink pill?)
*[yes]
~addEveningMeds(getMEDICINE_BLUE())
Ahh, why is this pill so big
-> END
*[no]
-> END