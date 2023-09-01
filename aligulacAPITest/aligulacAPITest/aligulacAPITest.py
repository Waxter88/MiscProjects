# Date: 06/07/2022
# Aligulac API Test - http://aligulac.com/about/api/

import requests as req
import json

api_key = 'VoQho3ieXRkBjQFky9ah'

# Get top ten players by rating
api_url = 'http://aligulac.com/api/v1/player/?current_rating__isnull=false&current_rating__decay__lt=4&order_by=-current_rating__rating&limit=10&apikey=VoQho3ieXRkBjQFky9ah'

# Searching by name
query = input()
api_url_search = 'http://aligulac.com/search/json/?q={}'.format(query)

response = req.get(api_url_search)

data = response.json()
player_list = []

player_count = 0
for players in data['players']:
   if player_count < 1:
    player_data = ('name : ', players['tag'], 'id : ', players['id'], 'race : ', players['race'], 'country : ', players['country'])
    player_list += player_data

    player_count += 1
   
print(str(player_list))
    



#print(json.dumps(response.json(), indent=4))