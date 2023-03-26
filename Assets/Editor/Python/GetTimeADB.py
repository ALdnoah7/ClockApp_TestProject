import requests
import UnityEngine
import os
import json


urlTimeDB = 'http://api.timezonedb.com/v2.1/get-time-zone?key='

key = '2OU0YV1DF3G7' + '&format=json&by=zone&zone='

country = 'Asia/Yekaterinburg'

r = requests.get(urlTimeDB + key + country)
response_json = json.dumps(r.json())
data = json.loads(response_json)

my_json_path = os.path.join(
    os.path.dirname(UnityEngine.Application.persistentDataPath + '/'), "data.json")

UnityEngine.Debug.Log(UnityEngine.Application.persistentDataPath)
with open(my_json_path, "w+") as outfile:
   json.dump(data, outfile)

name = 'asdf'