#PROG1870 - Pythonic Coding Challenge #3
#DATE: 01/21/2022
#BY: Jackson Pipe

#PART B

def isAnagram(word1, word2):
    if(sorted(word1) == sorted(word2)):
        print("The strings are anagrams.")
    else:
        print("The strings are NOT anagrams.")

isAnagram('dog', 'god')
isAnagram('silent', 'listen')
isAnagram('sesames', 'same')
isAnagram('dealer', 'deal')
