import requests
import json

## Print Time, Date, weather

url = 'https://api.open-meteo.com/v1/forecast?latitude=43.27&longitude=-79.86&hourly=temperature_2m&daily=temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,sunrise,sunset,precipitation_sum,precipitation_hours,windspeed_10m_max,windgusts_10m_max&current_weather=true&timezone=Europe%2FLondon'
r = requests.get(url)
data = json.loads(r.text)

#print('weather: ', json.dumps(data, indent=4))

def get_current_weather():
    temp = data['current_weather']['temperature']
    time = data['current_weather']['time']
    wind_direction = data['current_weather']['winddirection']
    wind_speed = data['current_weather']['windspeed']
    weather_code = data['current_weather']['weathercode']

    current_weather = {'temp' : temp, 'time' : time, 'wind_direction' : wind_direction, 'wind_speed' : wind_speed, 'weather_code' : weather_code}
    return current_weather


    
