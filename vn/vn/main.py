import vn, weather, json
from datetime import datetime
from consolemenu import *
from consolemenu.items import *



## VN LOGIN
#vn.login()
if vn.login() == 1:
    print('VN API Login Sucessful')
else:
    print('VN API Login NOT Sucessful')
active = True

## GET INPUT

## VN Send Command 
##vn.send_cmd('get', 'vn basic (search ~ "clannad")')
##print(vn.receive_data())

## Welcome Message
now = datetime.now()
wea = weather.get_current_weather()
d = now.strftime("%B %d, %Y. %I:%M:%S %p")

## Print Day, current weather
#print(d)
#print('Current weather: %sC, windspeed %skm/h' %(wea['temp'], wea['wind_speed']))
def format_vn_search(vn_json_data: str):
    data = ""
    for key in vn_json_data:
        if key == "":
            pass
        else:
            data = data + key
    

    data = data.replace('results', '')
    return data

def vn_search():
    print("Enter VNDB GET command:")
    user_input = input()
    vn.send_cmd('get', user_input)
    data = vn.receive_data()
    #data.replace('results', ' ')
    #data = json.loads(data)

    print(format_vn_search(data))
    with open(r'C:\coding\vn_search_data.json', 'w') as outfile:
        outfile.write(format_vn_search(data))
    

    PromptUtils(Screen()).enter_to_continue()


def current_weather():
     print(('Current weather: %sC, windspeed %skm/h' %(wea['temp'], wea['wind_speed'])))
     PromptUtils(Screen()).enter_to_continue()

if __name__ == "__main__":
    prog_screen = Screen()
    menu = ConsoleMenu(d, current_weather(), screen = prog_screen)

    menu_item = FunctionItem("VN Search", vn_search)
    menu_weather = FunctionItem("Weather", current_weather)

    menu.append_item(menu_item)
    menu.append_item(menu_weather)

    menu.show()