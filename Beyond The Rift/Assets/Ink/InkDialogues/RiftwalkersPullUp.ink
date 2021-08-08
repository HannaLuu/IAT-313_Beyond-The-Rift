// //VAR relationshipPoints = 0
// // INCLUDE MasterFile.ink

// //  -> BeginConfrontation

// //  == BeginConfrontation
// #Rogue Riftwalker Leader
// Bjorn Ironhand. You possess the power of a God. Come with us. Help us rebuild the guild that was once the greatest of them all. With your power...we can rule the world.

// { relationshipPoints > 7:
// #Khajiit D'Amelio
// Bjorn, don’t listen to him, he’s just trying to--
// }

// { relationshipPoints == 5:
// #Khajiit D'Amelio
// Bjorn, get back!
// }

// { relationshipPoints <= 1:
// #Khajiit D'Amelio
// Bjorn, don’t! You’re not capable of controlling your powers yet, you must-- 
// }

// #Rogue Riftwalker Leader
// Damn cat. Stay out of my way or I’ll kill you too.

// #Bjorn Ironhand
// (What will I say?)

// + [Never. I will not be another champion of evil. Leave, now.]
// ~relationshipPoints+=2
// -> LeaderRetaliates

// + [You must have mistaken me for another. Please, just leave us be...]
// -> LeaderRetaliates

// + [You’re making a grave mistake. You don’t know what you’re dealing with...]
// ~relationshipPoints-=2
// -> LeaderRetaliates

// == LeaderRetaliates
// #Rogue Riftwalker Leader
// Don’t play coy with me, boy. We have been watching you from the shadows. My patience wears thin - kill them all.

// -> END