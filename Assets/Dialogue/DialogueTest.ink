Hello there! #speaker:NPC1 #portrait:NPC1_neutral
-> main

=== main ===
How are you feeling today?
+ [Happy]
    That makes me happy as well! #portrait:NPC1_happy
+ [Sad]
    Oh, well, that makes me sad, too... #portrait:NPC1_sad
    
- Don't trust him, he doesn't actually care! #speaker:NPC2 #portrait:NPC2_angry

Never mind that. Do you have any more questions? #speaker:NPC1 #portrait:NPC1_neutral
+ [Yes]
    -> main
+ [No]
    Goodbye, then!
    -> END