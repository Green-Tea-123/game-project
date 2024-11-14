EXTERNAL addGroceries(string)
EXTERNAL getGROCERIES_BEEF()

-> start_dialogue

===start_dialogue===
#speaker: Uncle Fong #portrait:Unclefong
Hey Auntie, what do you want to get?
*[Beef]
-> Beef
*[Chicken]
-> Chicken
*[Pork]
-> Pork

===Beef===
#speaker: Mother #portrait:Happymother
~addGroceries(getGROCERIES_BEEF())
I get the best beef you have for curry

#speaker: Uncle Fong #portrait:Unclefong
OK Auntie, coming right up
-> END

===Chicken===
#speaker: Mother #portrait:Happymother
Get me a chicken lah

#speaker: Uncle Fong #portrait:Unclefong
OK Auntie, coming right up
-> END

===Pork===
#speaker: Mother #portrait:Happymother
Get me some pork lah

#speaker: Uncle Fong #portrait:Unclefong
OK Auntie, coming right up
-> END