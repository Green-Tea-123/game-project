EXTERNAL incrementDementiaCounter()
-> start_dialogue

===start_dialogue===
#speaker: Mother #portrait:Happymother
Okay, breakfast done, let’s go – they’re waiting!
Eh, almost forgot my medicine again! 
What day is it today ah… Wednesday? Or is it Thursday?
*[Wednesday]
-> correct_choice
*[Thursday]
-> wrong_choice

===correct_choice===
#speaker: Mother #portrait:Happymother
Ah yes, that’s right, today’s Wednesday – green now, and blue and yellow later 
Good thing I caught that. Can’t be missing these!
I need to faster take my medicine
-> END
===wrong_choice===
Is it Thursday? I don't know leh
~incrementDementiaCounter()
I cannot remember what pills to take leh
Just guess ah?
-> END