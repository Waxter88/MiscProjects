## Jikan REST API beta
import requests
import os

## Anime Search
def getAnimeSearch(search):
    url = "https://api.jikan.moe/v3/search/anime?q=" + search
    response = requests.get(url)
    return response.json()

## Get user to input search
def getUserSearch():
    search = input("Enter search: ")
    return search

## getAnimeStatistics
def getAnimeStatistics(mal_id):
    url = "https://api.jikan.moe/v3/anime/" + str(mal_id)
    response = requests.get(url)
    return response.json()

def display(anime):
    for item in anime['results']:
        print("Title: ", item['title'])
        print("MAL ID ", item['mal_id'])
        print("Synopsis: ", item['synopsis'])
        print("Score: ", item['score'])
        print("Type: ", item['type'])
        print("Episodes: ", item['episodes'])
        print("Airing: ", item['airing'])
        print("Image URL: ", item['image_url'])
        print("URL: ", item['url'])
        print("\n")
    return item['mal_id']

## Let user choose an anime by ID
def getUserAnime(anime_list):
    for item in anime_list['results']:
        print(item['mal_id'], item['title'])
    user_input = input("Enter anime ID: ")
    return user_input

## getAnimeByID
def getAnimeByID(mal_id):
    url = "https://api.jikan.moe/v3/anime/" + str(mal_id)
    response = requests.get(url)
    return response.json()

## Display getAnimeByID
def displayAnimeByID(anime_list):
    id_input = getUserAnime(anime_list)
    anime = getAnimeByID(id_input)
    print("Title: ", anime['title'])
    print("Synopsis: ", anime['synopsis'])
    print("Score: ", anime['score'])
    print("Type: ", anime['type'])
    print("Episodes: ", anime['episodes'])
    print("Airing: ", anime['airing'])
    print("Image URL: ", anime['image_url'])
    print("URL: ", anime['url'])
    print("\n")
    return anime['mal_id']

##Get file directory to save to
def getFileDirectory():
    #file_directory = input("Enter file directory: ")
    return 'favorites.txt'

## Save to file as a list of integers, using getFileDirectory. If nothing is entered, use default directory. 
def saveToFile(mal_id):
    file_directory = getFileDirectory()
    if file_directory == "":
        file_directory = "favorites.txt"
    with open(file_directory, "a") as file:
        file.write(str(mal_id) + "\n")

## Open file using getFileDirectory. If nothing is entered, use default directory. 
def openFile():
    file_directory = getFileDirectory()
    if file_directory == "":
        file_directory = "favorites.txt"
    with open(file_directory, "r") as file:
        return file.read()
## Ask user if they would like to add anime from displayAnimeByID to their a list of their favorite anime. If they would, add return this value.
def addToList(mal_id):
    user_input = input("Would you like to add this anime to your list of favorite anime? (y/n): ")
    if user_input == "y":
        saveToFile(mal_id)
        print("Added to favorites!")
        return mal_id
    elif user_input == "n":
        return False
    else:
        print("Invalid input")
        return addToList()

## Open text file in Notepad
def openFileNotepad():
    file_directory = getFileDirectory()
    if file_directory == "":
        file_directory = "favorites.txt"
    os.system("notepad " + file_directory)
    
## Using the results of openFile, use displayAnimeByID to show details about each favorite anime.
def viewFavorites():
    favorites = openFile()
    for favorite in favorites.splitlines():
        anime = getAnimeByID(favorite)
        print("Title: ", anime['title'])
        print("Score: ", anime['score'])
        print("Type: ", anime['type'])
        print("Episodes: ", anime['episodes'])
        print("URL: ", anime['url'])
        print("\n")

## DisplayAnimeByID Sub-Menu
def animeSubMenu():
    print("1. View Anime Details")
    print("2. Add to Favorites")
    print("3. Exit")
    user_input = input("Enter your choice: ")
    return user_input

def animeSubMenu_logic(user_input, anime_id):
    if user_input == "1":
        ## View Anime Details
        displayAnimeByID(anime_id)
    elif user_input == "2":
        ## Add to Favorites
        mal_id = displayAnimeByID(anime_id)
        addToList(mal_id)
    elif user_input == "3":
        ## Exit
        return
    else:
        print("Invalid input")
        return animeSubMenu_logic(user_input, anime_id)

## Main Menu. Option to search for an anime or to exit.
def menu():
    print("1. Search for an anime")
    print("2. View Favorites")
    print("3. Exit")
    user_input = input("Enter your choice: ")
    return user_input

def menu_logic(user_input):
    if user_input == "1":
        ## Search for an anime
        search = getUserSearch()

        ## Get anime search results
        anime_list = getAnimeSearch(search)

        ## Display anime search results
        anime_id = display(anime_list)
        
        ## Display anime by ID
        displayAnimeByID(anime_id)

        ## Display Anime Sub-Menu
        user_input = animeSubMenu()
        animeSubMenu_logic(user_input, anime_id)
        
        #animeSubMenu_logic(user_input, mal_id)
    elif user_input == "2":
        ## View favorites
        viewFavorites()
    elif user_input == "3":
        ## Exit
        return
    else:
        print("Invalid input")
        return menu_logic(user_input)

def main():
     menu_logic(menu())
    
    

    
main()