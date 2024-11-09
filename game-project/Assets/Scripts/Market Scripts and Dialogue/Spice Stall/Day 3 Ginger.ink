-> start_dialogue

===start_dialogue===
#speaker: Mr Lim #portrait:Mrlim
Good morning, Auntie! What brings you here today? You look like you’re on a mission!

#speaker: Mother #portrait:Happymother
Morning, Mr. Lim! Didn’t expect to find spices at your stall, but look! 
Fresh ginger, just what I need for tonight’s fried fish!

#speaker: Mr Lim #portrait:Mrlim
Ah, yes, yes! Not everyone knows I keep these
Fresh from the supplier this morning – only the best quality, auntie

#speaker: Mother #portrait:Happymother
(get ginger?)
*[yes]
-> correct_choice
*[no]
-> wrong_choice

===correct_choice===
#speaker: Mother #portrait:Happymother
Mr. Lim, these are fresh, right? I'll get some then

#speaker: Mr Lim #portrait:Mrlim
Alright, some strong and firm giner for you
Won't find any better around here!

#speaker: Mother #portrait:Happymother
Thank you, Mr. Lim! Now I know where to go for the good stuff
-> END

===wrong_choice===
#speaker: Mother #portrait:Happymother
Hmm... Maybe I won't get this for today
-> END