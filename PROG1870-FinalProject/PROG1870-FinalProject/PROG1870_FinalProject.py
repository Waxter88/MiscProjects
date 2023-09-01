## PROG1870 - Final Project
## By: Jackson Pipe
## Last Modified: 04/14/2022

import json
from pymongo import MongoClient
import pyodbc

try:
    conn = pyodbc.connect(driver='{SQL Server}', server='DESKTOP-HNDIVV5\SQLEXPRESS', database='project', trusted_connection='yes')
    print('Connected to SQL server')
except:
    print('Warning: could not connect to SQL Server')

## Read JSON Data
file_loc = 'c:\project_files\covid_rawdata.json'
print('Loading file from: \n', file_loc, '\n')

file = open(file_loc)

data = json.load(file)
file.close();

## Province Codes 
province_codes = ['AB', 'BC', 'MB', 'ON', 'NB', 'NL', 'NWT', 'NS', 'NU', 'PET', 'QB', 'YT', 'SK']
province = ['Alberta', 'British Columbia', 'Manitoba', 'Ontario', 'New Brunswick', 'Newfoundland and Labrador', 'Northwest Territories', 'Nova Scotia', 'Nunavut', 'Prince Edward Island', 'Quebec', 'Yukon', 'Saskatchewan']

## Convert province names to province code
def provinceNameToCode(province_name):
        for i in province:
            if province_name in province:
                    return province_codes[province.index(province_name)]
            else:
                    return province_name

## Data Structure
data_struct = [
    {'code' : 'AB', 'province' : 'Alberta', 'stats': []},
    {'code' : 'BC', 'province' : 'British Columbia', 'stats': []},
    {'code' : 'MB', 'province' : 'Manitoba', 'stats': []},
    {'code' : 'NB', 'province' : 'New Brunswick', 'stats': []},
    {'code' : 'NL', 'province' : 'Newfoundland and Labrador', 'stats': []},
    {'code' : 'NWT', 'province' : 'Northwest Territories', 'stats': []},
    {'code' : 'NS', 'province' : 'Nova Scotia', 'stats': []},
    {'code' : 'NU', 'province' : 'Nunavut', 'stats': []},
    {'code' : 'PEI', 'province' : 'Prince Edward Island', 'stats': []},
    {'code' : 'QB', 'province' : 'Quebec', 'stats': []},
    {'code' : 'YT', 'province' : 'Yukon', 'stats': []},
    {'code' : 'SK', 'province' : 'Saskatchewan', 'stats': []},
    ]

## Reformat JSON Data
print('Reformatting JSON Data... \n')

for i in data['cases']:
    x = -1
    for p in data_struct:
        x+=1
        if i['province'] == p['province'] or provinceNameToCode(i['province']) == p['code']:
            data_struct[x]['stats'].append ({
                    'cases' : i['cases'],
                    'cumulative_cases' : i['cumulative_cases'],
                    'date_report' : i['date_report']
                })
    
## Write formatted JSON to file
result_file = 'c:\project_files\data.json'
print('Writing formatted JSON data to: \n', result_file)

try:
    with open(result_file, 'w', encoding='utf-8') as f:
        json.dump(data_struct, f, ensure_ascii=False, indent=4)
    print('\nSuccess!\n', 'OUTPUT FILE: ', result_file, '\n')
except:
    print('Error writing file')

## Setup Mongo
client = MongoClient('localhost', 27017)
db = client.project
collection = db.data


print('Inserting into mongo database...')

try:
    with open(result_file) as file:
        data = json.load(file)
    print('Loaded JSON data...')
except:
    print('JSON data could not be loaded!')

try:
    collection.insert_many(data)
    print('Mongo insert complete\n')

except:
    print('Mongo insert failed\n')

## Excecute SQL script
try:
    print('Trying to excecute SQL script file...')
    cursor = conn.cursor()
    with open('C:\project_files\PROG1870-FinalProject') as insert:
        for statement in inserts:
            cursor.execute(statement)

    print('SQL script excecuted, data loaded to SQL Server')
except:
    print('SQL could not be excecuted')