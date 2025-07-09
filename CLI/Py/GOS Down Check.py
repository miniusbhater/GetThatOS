import os
import requests

print("GetThatOS download tester")
print("Build date 09/07/2025")


url = "https://github.com/miniusbhater" # checking github account

try:
    response = requests.get(url, timeout=5)
    if response.status_code == 200:
        print(f"{url} is reachable.")
    else:
        print(f"{url} returned status code {response.status_code}")
except requests.RequestException as exept:
    print(f"Failed to reach {url}. Error: {exept}")

urlurl = "https://github.com/miniusbhater/diskimages"  # checking diskimages repo

try:
    response = requests.get(urlurl, timeout=5)
    if response.status_code == 200:
        print(f"{urlurl} is reachable.")
    else:
        print(f"{urlurl} returned status code {response.status_code}")
except requests.RequestException as exept1:
    print(f"Failed to reach {urlurl}. Error: {exept1}")

  
    



urlurl1 = "https://apple.com" # checking apple

try:
    response = requests.get(urlurl1, timeout=5)
    if response.status_code == 200:
        print(f"{urlurl1} is reachable.")
    else:
        print(f"{urlurl1} returned status code {response.status_code}")
except requests.RequestException as exept11:
    print(f"Failed to reach {urlurl1}. Error: {exept11}")
