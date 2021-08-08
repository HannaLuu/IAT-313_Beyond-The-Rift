//  INCLUDE MasterFile.ink
// // VAR relationshipPoints = 0

// // ->BeginPeak

// // ==BeginPeak
// #Bjorn Ironhand
// By the Gods...I do miss the warm tavern mead.

// #Khajiit D'Amelio
// Bjorn.

// #Bjorn Ironhand
// Khajiit?! I thought you were--

// #Khajiit D'Amelio
// I’m fast, remember?

// #Bjorn Ironhand
// (What will I say?)

// + [About Snowspell...about everything...I’m so sorry, Khajiit. ]
// ~relationshipPoints+=2
// -> KhajiitReconcile

// + [It’s...good to see you. I still don’t know what...I am.]
// -> KhajiitReconcile

// + [You should’ve left me be. I’m too dangerous to be around people.]
// ~relationshipPoints-=2
// -> KhajiitReconcile

// == KhajiitReconcile
// { relationshipPoints > 7:
// #Khajiit D'Amelio
// You are forgiven, Bjorn. That demon inside of you feeds off of rage. You remind me of your Uncle Thoros. So long as you walk a path of mental tranquility, you will be--
// }

// { relationshipPoints == 2:
// #Khajiit D'Amelio
// I should have known Bjorn. That demon inside of you feeds off of rage. Your father, Mace, let his anger fester too... You must walk a path of mental tranquility if you wish to be--
// }

// { relationshipPoints <= 1:
// #Khajiit D'Amelio
// You would not have been able to control it. That demon inside of you feeds off of rage. If only you hadn’t run away, I could have taught you how to control your powers. You must not let--
// }

// #Bjorn Ironhand
// Why are you here, Khajiit? And how did you find me?

// #Khajiit D'Amelio
// I have adopted a daughter. Her name is Mjoll...and she was kidnapped by the Rogue Riftwalkers. No one else wanted to help me, so I tracked your aura to this location. I already know they are setting a trap to capture me, so I need your help.

// + [I help]
// ~relationshipPoints+=2
// -> DONE

// + [Give me time]
// -> DONE

// + [Give me time]
// ~relationshipPoints-=2
// -> DONE