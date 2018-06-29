## Word Counter Application

#### Epicodus C#:  6/29/2018

#### By Ryan Putman

## A console application that allows users to enter a singular word and a string of words.  The program will compare the two values and return the number of times the singular word can be found in the string of words. 

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **User inputs singular word that is stored in a new string variable**| Input: "Dog!" | Output: "Dog!" |
| **User inputs list of words to compare against singular word. List of words is stored in new string.**| Input: "Is your dog happ$y" | Output: "Is your dog happ$y" |
| **Program checks that “singular” word input contains only one word**| Input: "Dog!" | Output: "Dog!" |
| **Program checks that “singular” word does not contain any special characters**| Input: "Dog!" | Output: "False" |
| **Program checks that string of words does not contain any special characters**| Input: "Is your dog happ$y" | Output: "False" |
| **Program removes any spaces and special characters from “singular” word (if exists)**| Input: "Dog!" | Output: "Dog" |
| **Program removes special characters from string of words (if exists)**| Input: "Is your dog happ$y" | Output: "Is your dog happy" |
| **Program converts singular word to lowercase new string for matching**| Input: "Dog" | Output: "dog" |
| **Program converts string of words to lowercase new string for matching**| Input: "Is your dog happy" | Output: "is your dog happy" |
| **Program checks list of words against singular word for a match**| Input: "dog | is your dog happy" | Output: "True" |
| **If program finds match, program will return number of times matched word appears in string of words.**| Input: "dog | is your dog happy" | Output: "1" |
| **Program returns “Singular” word, String of words and number of times matches appear.**| Input: "Dog | Is your dog happy | 1" | Output: "Dog | Is your dog happy | 1" |

## Setup/Contribution Requirements

1. Follow the instructions for downloading C#, .NET Core 1.1 and Mono from: https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c
1. Clone the repo at https://github.com/putman10/Word-Counter
1. Make a new branch
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .NET Core 1.1 SDK
* .NET runtime
* Mono

## Links

* _[Here](https://github.com/putman10/Word-Counter) is the link to the Word Counter repository._

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Ryan Putman**