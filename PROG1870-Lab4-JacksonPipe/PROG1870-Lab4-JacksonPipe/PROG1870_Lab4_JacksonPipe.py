from pymongo import MongoClient as mc
from pymongo import ASCENDING as asc
from os import system as sys

#PROG1870 - LAB 4
#BY : Jackson Pipe
#Date : 03/25/2022

def get_coll():
    try:
        conn = mc("localhost", 27017)
        db = conn.lab4;
        return db.movies;
    except:
        return None

pc = get_coll()
exit = 0

def get_movies_by_plot(plot_keyword):
    movie_dict = pc.find(
                            {"plot": {"$regex" : plot_keyword, "$options" : "i"}},
                            {"title" : True, "_id" : False}
                        )
    if(movie_dict):
        return "\n".join(sorted([m["title"] for m in movie_dict]))
    else:
        return f"No movies matched for keyword {plot_keyword}"

def search_by_plot():
    input_plot = input("Enter a search word for plot: ")
    sys("cls")
    return f"Results for {input_plot}\n\n{get_movies_by_plot(input_plot)}\n\n"


def get_movies_by_imdbid(imdbid):
    movie_dict = pc.find_one(
                                {"imdb_id": {"$regex":imdbid}},
                                {"_id": False, "title": True, "imdb_id": True}
                            )
    if(movie_dict):
        return "{title} : {imdb_id}".format(**movie_dict)
    else:
        return f"The IMDB ID {imdbid} was not found in the database"

def search_by_imdbid():
    input_imdbid = input("Input an IMDB ID: ")
    sys("cls")
    return f"Results for IMDB ID: {input_imdbid}\n\n{get_movies_by_imdbid(input_imdbid)}\n\n"

if get_coll:
    while exit == 0:
        choice = input("PROG1224 - Lab 4 \nBy: Jackson Pipe\n\n\nFind movies by\n1. Imdb ID\n2. Plot\n3. Stop Search\n")
        sys("cls")
        if choice == "1":
            result = search_by_imdbid()
        elif choice == "2":
            result = search_by_plot()
        elif choice == "3":
            result = "Goodbye."
            exit = 1
        else:
            result = "Invalid Choice"
        print(result)
else:
    print("could not connect")