# AlphabetteeSpaghetti

This is a bit of a pointless project but something but just something that I can hook upto CI tools such as Travis CI and AppVeyor to see how they work

The purpose of the program (Console only at time of writing) is to get all possible permuations of a word of _n_ length without any duplicates.

For example, asking for a length of 1 would return 26 possible permutations, **A** through **Z**

But for 2, it would be **AA** through **ZZ**, a combinition of 676 possibilities

And for three, a whopping 17,576 combinations. 

A calculation of ***26<sup>^n</sup>***

### Build Statuses

|Provider|Status|
|:------:|:----:|
|Travis CI|![](https://travis-ci.org/cmjchrisjones/AlphabetteeSpaghetti.svg?branch=master)|
|AppVeyor |![](https://ci.appveyor.com/api/projects/status/1q36m6uphk25ct0g?svg=true)|
|VSTS|