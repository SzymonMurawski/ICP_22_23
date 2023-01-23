# Premise
At last Ali Baba said the magic words "open sesame" and a cave full of treasures stood before his eyes. Having brought only a small knapsack he began wondering, how to best pack it, to get out with as much riches as possible. Luckily his loyal companion came up with a C# application `AliBabaHelperApp`, just for this purpose!

# Goal
Your goal is to write a program, that will explore different techniques for a problem of packing a knapsack with items of varying values, weights and volumes

# Rules
1. Do not change any code in the main directory - your coding should focus on the `Packers` folder
2. Knapsack can be filled with treasures. The `Value` of a knapsack is the sum of values of all the treasures inside
3. Knapsack has finite `MaxWeight` and `MaxVolume`. If the items inside knapsack exceed either of those, value of knapsack drops to zero.
4. During the exercise you will develop multiple algorithms for this task - look at how fast they compute the result and what is their calculated value
5. [Do remember - stealing is wrong!](https://www.youtube.com/watch?v=jw3G4JlUoyY)

# Tasks
1. Implement the `FastPacker` - as it name suggest it should do the task fast: for every treasure in the list check, if it will fit in the knapsack and if so add it
2. Add `GreedyValuePacker`. Code will be very similar to `FastPacker`, with one change - `treasures` list should first be ordered by `Values`, as is "always take the most valuable item first". To sort list you can refer to the following code:
```
// this will sort the list with ASCENDING order of Values
treasures.Sort((p, q) => { 
                if (p.Value > q.Value)
                {
                    return 1;
                } else if (p.Value < q.Value){
                    return -1;
                } else
                {
                    return 0;
                }
            });
```
3. Add `GreedyRatioPacker`. Code will be the same as before, but instead of sorting according to values, sort according to something else. Maybe ratio value/(weight*volume)?
4. Add `MonteCarloPacker`. In this technique you will randomly generate a lot of candidate knapsacks and then select the one with greatest value
    - First, inside `MonteCarloPacker` create private function `private Knapsack GetRandomlyFilledKnapsack(int maxWeight, int maxVolume, List<Treasure> treasures)`
    - This function should randomly fill a knapsack. One way of doing it - iterate through list of treasures and then according to some random condition (for example `random.Next() % 2 == 0) either add or not a treasure to knapsack
    - With this function done, main function in this class should look like this: 
        1. generate random knapsack that we will call `bestKnapsack`
        2. 10 000 times generate new random knapsack `contenderKnapsack`
        3. If contender is better than best, replace the best with contender
5. Look around in the folder, you might find some other solutions there:)