EXTERNAL addGroceries(string)
EXTERNAL getGROCERIES_CHICKEN()
-> start_dialogue

===start_dialogue===
#speaker: Mother #portrait:Happymother
(What meat should i get?)
*[Chicken]
Uncle Fong! Still got chicken? 
Ah, okay, okay… how much ah? Wah, price go up again… lucky this chicken soup sedap!
~addGroceries(getGROCERIES_CHICKEN())
-> END
*[Pork]
Uncle Fong! Still got Pork? 
Ah, okay, okay… how much ah? Wah, price go up again… lucky this pork soup sedap!
-> END
*[Beef]
Uncle Fong! Still got Beef? 
Ah, okay, okay… how much ah? Wah, price go up again… lucky this beef soup sedap!
-> END