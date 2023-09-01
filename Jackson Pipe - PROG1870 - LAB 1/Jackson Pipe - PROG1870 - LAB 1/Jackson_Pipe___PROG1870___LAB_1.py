import re

def vowel_score(string):
	vowel_score = 0
	for word in string.split():
		s = re.findall(r'[aeiou]', word, flags=re.IGNORECASE)

		if len(s) <= 2:
			vowel_score += 1

		if len(s) >= 3:
			vowel_score += 2
	print('Your sentence vowel score is: ', vowel_score)

print('Enter a sentence here: ')
user_input = input()
vowel_score(user_input)

