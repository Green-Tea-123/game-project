EXTERNAL addMorningMeds(string)
EXTERNAL getMEDICINE_PINK()
-> start_dialogue
===start_dialogue===
#speaker: Mother #portrait:Happymother
(Do I eat the pink pill?)
*[yes]
~addMorningMeds(getMEDICINE_PINK())
Ahh, why is this pill so bitter
-> END
*[no]
-> END