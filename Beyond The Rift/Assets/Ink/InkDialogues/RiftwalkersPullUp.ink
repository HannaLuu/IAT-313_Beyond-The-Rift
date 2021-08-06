VAR relationshipPoints = 1

-> Begin

== Begin
#Rogue Riftwalker Leader
Bjorn Ironhand. You possess the power of a God. Come with us. Help us rebuild the guild that was once the greatest of them all. With your power...we can rule the world.

{relationshipPoints >= 7:
#Khajiit D'Amelio
Bjorn, don’t listen to him, he’s just trying to--
}

{relationshipPoints == 5:
#Khajiit D'Amelio
Bjorn, get back!
}

{relationshipPoints <= 3:
#Khajiit D'Amelio
Bjorn, don’t! You’re not capable of controlling your powers yet, you must-- 
}

-> END