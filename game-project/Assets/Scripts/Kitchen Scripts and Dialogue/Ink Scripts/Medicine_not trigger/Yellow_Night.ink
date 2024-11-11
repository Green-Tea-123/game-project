EXTERNAL incrementDementiaCounter()
-> start_dialogue
===start_dialogue===
#speaker: Mother #portrait:Happymother
(Do I eat the pink pill?)
*[yes]
~incrementDementiaCounter()
Ahh, why this pill tastes so funny
-> END
*[no]
-> END