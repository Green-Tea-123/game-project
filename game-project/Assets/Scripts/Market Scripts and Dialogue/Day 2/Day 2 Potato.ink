EXTERNAL addGroceries(string)
EXTERNAL getGROCERIES_POTATO()
-> start_dialogue

===start_dialogue===
#speaker: Mother #portrait:Happymother
(should I get potatos?)
*[yes]
~addGroceries(getGROCERIES_POTATO())
Halim ah! Can I get some potatos, please? Fresh ones, ah! Thank you!
-> END
*[no]
-> END