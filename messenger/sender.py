import requests

name = input('Input name: ')


while True:
    text = input('Inpute text: ')
    response = requests.post('http://127.0.0.1:5000/send',
                          json={'name': name, 'text': text})
