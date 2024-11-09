-> start_dialogue

===start_dialogue===
#speaker: Mother #portrait:Happymother
Wah quite busy today. Hmm what do I need again?
*[Ginger]
-> wrong_choice_1
*[Cardamom]
->correct_choice_1
*[******]
-> dont_rmb

===dont_rmb===
Ah, I feel like I'm missing something out
Try to remember again Ah Mui
*[Ginger]
-> wrong_choice_1
*[Cardamom]
->correct_choice_1

===correct_choice_1===
#speaker: Mother #portrait:Happymother
Ah that's right cardamom
-> choice_2

===wrong_choice_1===
#speaker: Mother #portrait:Happymother
I feel like that's not right leh
Aiya just guess
-> choice_2

===choice_2===
#speaker: Mother #portrait:Happymother
What meat do I need to buy ah?
*[Fish]
-> wrong_choice_2
*[Chicken]
-> wrong_choice_2
*[Beef]
-> correct_choice_2

===correct_choice_2===
#speaker: Mother #portrait:Happymother
Maybe that's right? I think so
-> choice_3

===wrong_choice_2===
#speaker: Mother #portrait:Happymother
Ahhh... Cannot remember if it's right or not
-> choice_3

===choice_3===
Anything else I need to buy?
*[Cabbage]
-> wrong_choice_3
*[Carrot]
-> correct_choice_3
*[Nothing]
-> wrong_choice_3

===correct_choice_3===
Ah yes, almost forgot about the carrots
Time to go and buy them
-> END

===wrong_choice_3===
Hmm... All this thinking is going to make my head go kaput
Just go and buy what I think is right lah
-> END


