# Shopping list application

## Overview
This application should let user enter items to buy ("Eggs", "Flour", "Paper towels", etc.) and when the user stops entering them it should print them in nice fashion.

## Very important announcement
Do not, I REPEAT DO NOT, change the signature of the functions in `ShoppingList` class. You can add new ones, you can change the implementation of the functions, but do not change the signatures!

## Tasks
1. Download and run the code, it should fail due to `NotImplementedException` errors in `ShoppingList` class
2. Implement the methods in `ShoppingList` class, such that the program will run correctly
   - Use the `ItemsToBuy` array for storing, well, items to buy :)
   - The way this implementation is going to work is as follows:
     1. When we `AddItem`, we will use `CountOfItems` as the index in `ItemsToBuy` array, where this new item should go
     2. When we get `Size`, we will return `CountOfItems`
     3. When we `GetList`, we will return the string formatted in the following way:
     ```
     1x Eggs
     1x Flour
     1x Paper towels
     ```
3. Our application will crash if we add more than 5 items. Correct it - when we try to add new item outside the bounds of the array:
    - Create new array of size 2*size of the old array
    - Copy the existing items to this new array
    - Replace old array with this new one
    - Add this new item
4. Refactor the code - switch `string[]` to `List<string>` for storing Items to buy. For reference on how to use List use google (i.e. https://www.tutorialsteacher.com/csharp/csharp-list)
5. With lists on the way, now when we `GetList`, return the string sorted alphabetically
6. It would be nice, if we could "group" same items, so that instead of displaying `1x Eggs 1x Eggs` we just get `2x Eggs`. To do so, refactor your code once again, this time using `Dictionary<string, int>`.