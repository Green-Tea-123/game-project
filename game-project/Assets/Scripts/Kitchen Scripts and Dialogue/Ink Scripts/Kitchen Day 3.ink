EXTERNAL incrementDementiaCounter()
-> start_dialogue

===start_dialogue===
#speaker: Mother #portrait:Happymother
Alright, simple breakfast today… bread, soft-boiled eggs, and a nice cup of teh
Just enough to keep this old lady going
Going to meet Auntie Siew Hong later… good thing got her around lah
So many friends from back then… they all have their families, go off here and there 
Children take them out, grandchildren visit them… but here I am, left to my own thoughts
Sometimes, I wonder… these children grow up, make their own lives, and forget about us, the old folks 
Like me and Auntie Siew Hong – just two old ladies walking around the market, trying to remember the good old days
Even Ah Boon… always so busy lah, always in a hurry
Don’t know if one day he’ll also just… leave me behind, like everyone else
Will he be like that too, ah?
Aiyoh! Water’s ready already! Old lady daydreaming too much… need to focus
Okay, okay… enough of that, Ah Mui 
Got breakfast, got plans, got the whole day ahead, dont need think so hard
Oh ya, wait! I need to take my medication! Almost forgot
Today is Thursday, so it's green capsule and… green capsule and what ah?
*[Pink]
-> correct_choice
*[Blue]
-> wrong_choice
*[Yellow]
-> wrong_choice

===correct_choice===
#speaker: Mother #portrait:Happymother
Ah yes, and pink tablet in the morning. Good thing I caught that—can't be skipping these
Alright, that's better, now I'm all set for the day!
-> END
===wrong_choice===
#speaker: Mother #portrait:Happymother
Hmm… Wah it seems like it, but also not leh
~incrementDementiaCounter()
Just guess lor

-> END