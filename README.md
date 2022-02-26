# SumOfPossibleSubstringsByDistinctCharValues
Problem Statement -

Given input password string e.g. test
Calculate sum of all possible substrings of given input string with distict values

********* Sample Input 1 => test
All possible combinations would be

Substring     Count of Distinct Characters
test => t     1
test => te    2
test => tes   3
test => test  3
test => e     1
test => es    2
test => est   3
test => s     1
test => st    2
test => t     1

Output => Sum (Count of Distinct Characters from possible substrings of a given input string)
          (1 + 2 + 3 + 3 + 1 + 2 + 3 + 1 + 2 + 1) = 19


********* Sample Input 2 => good
All possible combinations would be

Substring     Count of Distinct Characters
good => g     1
good => go    2
good => goo   2
good => good  3
good => o     1
good => oo    1
good => ood   2
good => o     1
good => od    2
good => d     1

Output => Sum (Count of Distinct Characters from possible substrings of a given input string)
          (1 + 2 + 2 + 3 + 1 + 1 + 2 + 1 + 2 + 1) = 16
